using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using umlMaker.Objects;
using umlMaker.SubObjects;

namespace umlMaker
{
    public partial class ClassEditor : Form
    {
        private Preview Preview { get; set; }
        public ClassEditor()
        {
            InitializeComponent();
            AttributesDataGrid.DataSource = Preview.Class.Attributes;
            OperatioinsDataGrid.DataSource = Preview.Class.Operations;
            Preview = new Preview();
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

                Preview.Update(ClassPreviewPictureBox.CreateGraphics(), ClassName.Text);
            }
        }

        private void CloseAttributeButton_Click(object sender, EventArgs e)
        {
            NameAttributTextBox.Text = "";
            DataTypeAttributTextBox.Text = "";
            comboBox1.SelectedItem = null;
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

                Preview.Update(ClassPreviewPictureBox.CreateGraphics(), ClassName.Text);
            }
        }

        private void CloseOperationButton_Click(object sender, EventArgs e)
        {

            NameOperationTextBox.Text = "";
            ReturnOperationTextBox.Text = "";
            ParametrsOperationTextbox.Text = "";
            comboBox2.SelectedItem = null;
        }

        private void ClassName_TextChanged(object sender, EventArgs e)
        {
            Preview.Update(ClassPreviewPictureBox.CreateGraphics(), ClassName.Text);
        }

        private void button2_Click(object sender, EventArgs e)//ok button
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//exit button
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
