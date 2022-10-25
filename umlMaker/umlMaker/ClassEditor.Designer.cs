namespace umlMaker
{
    partial class ClassEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClassPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.AttributesDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameAttributTextBox = new System.Windows.Forms.TextBox();
            this.DataTypeAttributTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OperatioinsDataGrid = new System.Windows.Forms.DataGridView();
            this.OkAttributeButton = new System.Windows.Forms.Button();
            this.CloseAttributeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseOperationButton = new System.Windows.Forms.Button();
            this.OkOperationButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ReturnOperationTextBox = new System.Windows.Forms.TextBox();
            this.NameOperationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ParametrsOperationTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EditAttributesButton = new System.Windows.Forms.Button();
            this.EditOperationsButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.interface_radiobutton = new System.Windows.Forms.RadioButton();
            this.abstract_class_radiobutton = new System.Windows.Forms.RadioButton();
            this.class_radiobutton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassPreviewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatioinsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassPreviewPictureBox
            // 
            this.ClassPreviewPictureBox.Location = new System.Drawing.Point(582, 23);
            this.ClassPreviewPictureBox.Name = "ClassPreviewPictureBox";
            this.ClassPreviewPictureBox.Size = new System.Drawing.Size(575, 721);
            this.ClassPreviewPictureBox.TabIndex = 0;
            this.ClassPreviewPictureBox.TabStop = false;
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(12, 43);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(560, 23);
            this.ClassName.TabIndex = 1;
            this.ClassName.TextChanged += new System.EventHandler(this.ClassName_TextChanged);
            this.ClassName.Validating += new System.ComponentModel.CancelEventHandler(this.ClassName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(239, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Attributes";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(239, 383);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 25);
            this.label.TabIndex = 6;
            this.label.Text = "Operations";
            // 
            // AttributesDataGrid
            // 
            this.AttributesDataGrid.AllowUserToAddRows = false;
            this.AttributesDataGrid.AllowUserToDeleteRows = false;
            this.AttributesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttributesDataGrid.Location = new System.Drawing.Point(6, 137);
            this.AttributesDataGrid.Name = "AttributesDataGrid";
            this.AttributesDataGrid.ReadOnly = true;
            this.AttributesDataGrid.RowHeadersWidth = 82;
            this.AttributesDataGrid.RowTemplate.Height = 25;
            this.AttributesDataGrid.Size = new System.Drawing.Size(564, 132);
            this.AttributesDataGrid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // NameAttributTextBox
            // 
            this.NameAttributTextBox.Location = new System.Drawing.Point(153, 329);
            this.NameAttributTextBox.Name = "NameAttributTextBox";
            this.NameAttributTextBox.Size = new System.Drawing.Size(141, 23);
            this.NameAttributTextBox.TabIndex = 10;
            this.NameAttributTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNotNull_Validating);
            // 
            // DataTypeAttributTextBox
            // 
            this.DataTypeAttributTextBox.Location = new System.Drawing.Point(300, 330);
            this.DataTypeAttributTextBox.Name = "DataTypeAttributTextBox";
            this.DataTypeAttributTextBox.Size = new System.Drawing.Size(119, 23);
            this.DataTypeAttributTextBox.TabIndex = 11;
            this.DataTypeAttributTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNotNull_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // OperatioinsDataGrid
            // 
            this.OperatioinsDataGrid.AllowUserToAddRows = false;
            this.OperatioinsDataGrid.AllowUserToDeleteRows = false;
            this.OperatioinsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperatioinsDataGrid.Location = new System.Drawing.Point(6, 411);
            this.OperatioinsDataGrid.Name = "OperatioinsDataGrid";
            this.OperatioinsDataGrid.ReadOnly = true;
            this.OperatioinsDataGrid.RowHeadersWidth = 82;
            this.OperatioinsDataGrid.RowTemplate.Height = 25;
            this.OperatioinsDataGrid.Size = new System.Drawing.Size(564, 132);
            this.OperatioinsDataGrid.TabIndex = 13;
            // 
            // OkAttributeButton
            // 
            this.OkAttributeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OkAttributeButton.Location = new System.Drawing.Point(425, 329);
            this.OkAttributeButton.Name = "OkAttributeButton";
            this.OkAttributeButton.Size = new System.Drawing.Size(100, 23);
            this.OkAttributeButton.TabIndex = 14;
            this.OkAttributeButton.Text = "OK";
            this.OkAttributeButton.UseVisualStyleBackColor = false;
            this.OkAttributeButton.Click += new System.EventHandler(this.OkAttributeButton_Click);
            // 
            // CloseAttributeButton
            // 
            this.CloseAttributeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseAttributeButton.Location = new System.Drawing.Point(531, 330);
            this.CloseAttributeButton.Name = "CloseAttributeButton";
            this.CloseAttributeButton.Size = new System.Drawing.Size(35, 23);
            this.CloseAttributeButton.TabIndex = 15;
            this.CloseAttributeButton.Text = "X";
            this.CloseAttributeButton.UseVisualStyleBackColor = false;
            this.CloseAttributeButton.Click += new System.EventHandler(this.CloseAttributeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Visibility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 599);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Visibility";
            // 
            // CloseOperationButton
            // 
            this.CloseOperationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseOperationButton.Location = new System.Drawing.Point(531, 660);
            this.CloseOperationButton.Name = "CloseOperationButton";
            this.CloseOperationButton.Size = new System.Drawing.Size(35, 23);
            this.CloseOperationButton.TabIndex = 23;
            this.CloseOperationButton.Text = "X";
            this.CloseOperationButton.UseVisualStyleBackColor = false;
            this.CloseOperationButton.Click += new System.EventHandler(this.CloseOperationButton_Click);
            // 
            // OkOperationButton
            // 
            this.OkOperationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.OkOperationButton.Location = new System.Drawing.Point(425, 660);
            this.OkOperationButton.Name = "OkOperationButton";
            this.OkOperationButton.Size = new System.Drawing.Size(100, 23);
            this.OkOperationButton.TabIndex = 22;
            this.OkOperationButton.Text = "OK";
            this.OkOperationButton.UseVisualStyleBackColor = false;
            this.OkOperationButton.Click += new System.EventHandler(this.OkOperationButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 617);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 23);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_Validating);
            // 
            // ReturnOperationTextBox
            // 
            this.ReturnOperationTextBox.Location = new System.Drawing.Point(425, 617);
            this.ReturnOperationTextBox.Name = "ReturnOperationTextBox";
            this.ReturnOperationTextBox.Size = new System.Drawing.Size(141, 23);
            this.ReturnOperationTextBox.TabIndex = 20;
            this.ReturnOperationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNull_Validating);
            // 
            // NameOperationTextBox
            // 
            this.NameOperationTextBox.Location = new System.Drawing.Point(153, 617);
            this.NameOperationTextBox.Name = "NameOperationTextBox";
            this.NameOperationTextBox.Size = new System.Drawing.Size(141, 23);
            this.NameOperationTextBox.TabIndex = 19;
            this.NameOperationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNotNull_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 599);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 599);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Return Type";
            // 
            // ParametrsOperationTextbox
            // 
            this.ParametrsOperationTextbox.Location = new System.Drawing.Point(300, 617);
            this.ParametrsOperationTextbox.Name = "ParametrsOperationTextbox";
            this.ParametrsOperationTextbox.Size = new System.Drawing.Size(119, 23);
            this.ParametrsOperationTextbox.TabIndex = 26;
            this.ParametrsOperationTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNull_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Parametrs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(132, 699);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 45);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(23, 699);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 27;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditAttributesButton
            // 
            this.EditAttributesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditAttributesButton.Location = new System.Drawing.Point(495, 275);
            this.EditAttributesButton.Name = "EditAttributesButton";
            this.EditAttributesButton.Size = new System.Drawing.Size(75, 23);
            this.EditAttributesButton.TabIndex = 29;
            this.EditAttributesButton.Text = "Edit";
            this.EditAttributesButton.UseVisualStyleBackColor = false;
            this.EditAttributesButton.Click += new System.EventHandler(this.EditAttributesButton_Click);
            // 
            // EditOperationsButton
            // 
            this.EditOperationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EditOperationsButton.Location = new System.Drawing.Point(495, 549);
            this.EditOperationsButton.Name = "EditOperationsButton";
            this.EditOperationsButton.Size = new System.Drawing.Size(75, 23);
            this.EditOperationsButton.TabIndex = 30;
            this.EditOperationsButton.Text = "Edit";
            this.EditOperationsButton.UseVisualStyleBackColor = false;
            this.EditOperationsButton.Click += new System.EventHandler(this.EditOperationsButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // interface_radiobutton
            // 
            this.interface_radiobutton.AutoSize = true;
            this.interface_radiobutton.Location = new System.Drawing.Point(253, 79);
            this.interface_radiobutton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.interface_radiobutton.Name = "interface_radiobutton";
            this.interface_radiobutton.Size = new System.Drawing.Size(71, 19);
            this.interface_radiobutton.TabIndex = 34;
            this.interface_radiobutton.Text = "Interface";
            this.interface_radiobutton.UseVisualStyleBackColor = true;
            this.interface_radiobutton.CheckedChanged += new System.EventHandler(this.interface_radiobutton_CheckedChanged);
            // 
            // abstract_class_radiobutton
            // 
            this.abstract_class_radiobutton.AutoSize = true;
            this.abstract_class_radiobutton.Location = new System.Drawing.Point(354, 79);
            this.abstract_class_radiobutton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.abstract_class_radiobutton.Name = "abstract_class_radiobutton";
            this.abstract_class_radiobutton.Size = new System.Drawing.Size(99, 19);
            this.abstract_class_radiobutton.TabIndex = 35;
            this.abstract_class_radiobutton.Text = "Abstract Class";
            this.abstract_class_radiobutton.UseVisualStyleBackColor = true;
            this.abstract_class_radiobutton.CheckedChanged += new System.EventHandler(this.abstract_class_radiobutton_CheckedChanged);
            // 
            // class_radiobutton
            // 
            this.class_radiobutton.AutoSize = true;
            this.class_radiobutton.Checked = true;
            this.class_radiobutton.Location = new System.Drawing.Point(150, 79);
            this.class_radiobutton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.class_radiobutton.Name = "class_radiobutton";
            this.class_radiobutton.Size = new System.Drawing.Size(52, 19);
            this.class_radiobutton.TabIndex = 36;
            this.class_radiobutton.TabStop = true;
            this.class_radiobutton.Text = "Class";
            this.class_radiobutton.UseVisualStyleBackColor = true;
            this.class_radiobutton.CheckedChanged += new System.EventHandler(this.class_radiobutton_CheckedChanged);
            // 
            // ClassEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 790);
            this.Controls.Add(this.class_radiobutton);
            this.Controls.Add(this.abstract_class_radiobutton);
            this.Controls.Add(this.interface_radiobutton);
            this.Controls.Add(this.EditOperationsButton);
            this.Controls.Add(this.EditAttributesButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ParametrsOperationTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CloseOperationButton);
            this.Controls.Add(this.OkOperationButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ReturnOperationTextBox);
            this.Controls.Add(this.NameOperationTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CloseAttributeButton);
            this.Controls.Add(this.OkAttributeButton);
            this.Controls.Add(this.OperatioinsDataGrid);
            this.Controls.Add(this.AttributesDataGrid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DataTypeAttributTextBox);
            this.Controls.Add(this.NameAttributTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.ClassPreviewPictureBox);
            this.Name = "ClassEditor";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClassEditor_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ClassPreviewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttributesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperatioinsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ClassPreviewPictureBox;
        private TextBox ClassName;
        private Label label1;
        private Label label2;
        private Label label;
        private DataGridView AttributesDataGrid;
        private Label label4;
        private Label label5;
        private TextBox NameAttributTextBox;
        private TextBox DataTypeAttributTextBox;
        private ComboBox comboBox1;
        private DataGridView OperatioinsDataGrid;
        private Button OkAttributeButton;
        private Button CloseAttributeButton;
        private Label label6;
        private Label label7;
        private Button CloseOperationButton;
        private Button OkOperationButton;
        private ComboBox comboBox2;
        private TextBox ReturnOperationTextBox;
        private TextBox NameOperationTextBox;
        private Label label8;
        private Label label9;
        private TextBox ParametrsOperationTextbox;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button EditAttributesButton;
        private Button EditOperationsButton;
        private ErrorProvider errorProvider1;
        private RadioButton class_radiobutton;
        private RadioButton abstract_class_radiobutton;
        private RadioButton interface_radiobutton;
    }
}