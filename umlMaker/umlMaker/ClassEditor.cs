using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using umlMaker.Objects;
using umlMaker.SubObjects;

namespace umlMaker
{
    public partial class ClassEditor : Form
    {
        public Preview Preview { get; set; }
        private bool Focus = false;
        public ClassEditor()
        {
            InitializeComponent();
            Preview = new Preview();
            Prepare();
        }
        public ClassEditor(Class classToEdit)
        {
            InitializeComponent();
            Preview = new Preview(classToEdit);
            ClassName.Text = Preview.Class.Name;
            Prepare();
        }
        private void Prepare()
        {
            AttributesDataGrid.DataSource = Preview.Class.Attributes;
            OperatioinsDataGrid.DataSource = Preview.Class.Operations;

            comboBox1.Items.Add("Public");
            comboBox1.Items.Add("Protected");
            comboBox1.Items.Add("Private");

            comboBox2.Items.Add("Public");
            comboBox2.Items.Add("Protected");
            comboBox2.Items.Add("Private");
        }
        public Class GetClass()
        {
            return Preview.Class;
        }

        private void OkAttributeButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && NameAttributTextBox.Text != "")
            {
                Visibility vis;
                if(comboBox1.SelectedItem.ToString() == "Public")
                    vis = Visibility.PUBLIC;
                else if (comboBox1.SelectedItem.ToString() == "Protected")
                    vis = Visibility.PROTECTED;
                else 
                    vis = Visibility.PRIVATE;
                Attributes at = new Attributes() { Name = NameAttributTextBox.Text, DataType = DataTypeAttributTextBox.Text, Visibility = vis};
                Preview.Class.Attributes.Add(at);

                NameAttributTextBox.Text = "";
                DataTypeAttributTextBox.Text = "";
                comboBox1.SelectedItem = null;

                Preview.Update(ClassPreviewPictureBox, ClassName.Text);
            }
        }

        private void CloseAttributeButton_Click(object sender, EventArgs e)
        {
            Preview.Class.Attributes.RemoveAt(AttributesDataGrid.CurrentCell.RowIndex);
            Preview.Update(ClassPreviewPictureBox, ClassName.Text);
        }

        private void OkOperationButton_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && NameOperationTextBox.Text != "")
            {
                Visibility vis;
                if (comboBox2.SelectedItem.ToString() == "Public")
                    vis = Visibility.PUBLIC;
                else if (comboBox2.SelectedItem.ToString() == "Protected")
                    vis = Visibility.PROTECTED;
                else
                    vis = Visibility.PRIVATE;
                Operations op = new Operations() { Name = NameOperationTextBox.Text, ReturnType = ReturnOperationTextBox.Text, Parametrs = ParametrsOperationTextbox.Text, Visibility = vis };
                Preview.Class.Operations.Add(op);

                NameOperationTextBox.Text = "";
                ReturnOperationTextBox.Text = "";
                ParametrsOperationTextbox.Text = "";
                comboBox2.SelectedItem = null;

                Preview.Update(ClassPreviewPictureBox, ClassName.Text);
            }
        }

        private void CloseOperationButton_Click(object sender, EventArgs e)
        {
            Preview.Class.Operations.RemoveAt(OperatioinsDataGrid.CurrentCell.RowIndex);
            Preview.Update(ClassPreviewPictureBox, ClassName.Text);
        }

        private void ClassName_TextChanged(object sender, EventArgs e)
        {
            Preview.Update(ClassPreviewPictureBox, ClassName.Text);
        }

        private void button2_Click(object sender, EventArgs e)//ok button
        {
            if (Preview.Class.X == 0 || Preview.Class.Y == 0)
            {
                Preview.Class.X = ApplicationGetter.WindowWidth / 2;
                Preview.Class.Y = ApplicationGetter.WindowHeight / 2;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//exit button
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditAttributesButton_Click(object sender, EventArgs e)
        {
            int index = AttributesDataGrid.CurrentCell.RowIndex;
            NameAttributTextBox.Text = Preview.Class.Attributes[index].Name;
            DataTypeAttributTextBox.Text = Preview.Class.Attributes[index].DataType;
            comboBox1.Text = GetVisibility(Preview.Class.Attributes[index].Visibility);
            Preview.Class.Attributes.RemoveAt(AttributesDataGrid.CurrentCell.RowIndex);

        }

        private void EditOperationsButton_Click(object sender, EventArgs e)
        {
            int index = OperatioinsDataGrid.CurrentCell.RowIndex;
            NameOperationTextBox.Text = Preview.Class.Operations[index].Name;
            ParametrsOperationTextbox.Text = Preview.Class.Operations[index].Parametrs;
            ReturnOperationTextBox.Text = Preview.Class.Operations[index].ReturnType;
            comboBox2.Text = GetVisibility(Preview.Class.Operations[index].Visibility);
            Preview.Class.Operations.RemoveAt(OperatioinsDataGrid.CurrentCell.RowIndex);
        }
        private string GetVisibility(Visibility vis)
        {
            string visibility = "";
            if (vis == Visibility.PRIVATE)
                visibility = "Private";
            else if (vis == Visibility.PROTECTED)
                visibility = "Protected";
            else if (vis == Visibility.PUBLIC)
                visibility = "Public";
            return visibility;
        }

        private void ClassEditor_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Focus && Preview.Class.Name != "")
            {
                Focus = true;
                Preview.Update(ClassPreviewPictureBox, Preview.Class.Name);
            }
        }

        private void ClassName_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            // this.errorProvider1.SetError(tb, null);

            if (string.IsNullOrEmpty(tb.Text))
            {
                this.errorProvider1.SetError(tb, "Povinná hodnota!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(tb.Text, @"^[A-Z][A-Za-z0-9_]+[A-Za-z0-9]$"))
            {
                this.errorProvider1.SetError(tb, "Neplatný formát");
                e.Cancel = true;
            }
            else
            {
                foreach (var item in ApplicationGetter.GetClasses())
                {
                    if(item.Name == tb.Text && item != Preview.Class)
                    {
                        this.errorProvider1.SetError(tb, "Třída již existuje");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void TextBoxNull_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            // this.errorProvider1.SetError(tb, null);

            if (!Regex.IsMatch(tb.Text, @"^[A-Za-z0-9_]+[A-Za-z0-9]$"))
            {
                this.errorProvider1.SetError(tb, "Neplatný formát");
                e.Cancel = true;
            }
        }
        private void TextBoxNotNull_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            // this.errorProvider1.SetError(tb, null);

            if (string.IsNullOrEmpty(tb.Text))
            {
                this.errorProvider1.SetError(tb, "Povinná hodnota!");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(tb.Text, @"^[A-Za-z0-9_]+[A-Za-z0-9]$"))
            {
                this.errorProvider1.SetError(tb, "Neplatný formát");
                e.Cancel = true;
            }
        }

        private void class_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            Preview.Class.ClassType = ClassType.CLASS;
            Preview.Update(ClassPreviewPictureBox, Preview.Class.Name);
        }

        private void interface_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            Preview.Class.ClassType = ClassType.INTERFACE;
            Preview.Update(ClassPreviewPictureBox, Preview.Class.Name);
        }

        private void abstract_class_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            Preview.Class.ClassType = ClassType.ABSTRACT;
            Preview.Update(ClassPreviewPictureBox, Preview.Class.Name);
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            // this.errorProvider1.SetError(tb, null);

            if (string.IsNullOrEmpty(cb.Text))
            {
                this.errorProvider1.SetError(cb, "Povinná hodnota!");
                e.Cancel = true;
            }
        }
    }
}
