namespace StraumannDiff
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            labelOurExcel = new Label();
            buttonSelectOurExcel = new Button();
            label2 = new Label();
            labelSwissExcel = new Label();
            buttonSelectSwissExcel = new Button();
            groupBox1 = new GroupBox();
            checkBoxLaptop = new CheckBox();
            buttonSelectOurExcelLaptop = new Button();
            labelOurExcelLaptop = new Label();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Mi excelünk (PC)";
            // 
            // labelOurExcel
            // 
            labelOurExcel.AutoSize = true;
            labelOurExcel.Location = new Point(27, 62);
            labelOurExcel.Name = "labelOurExcel";
            labelOurExcel.Size = new Size(0, 15);
            labelOurExcel.TabIndex = 1;
            // 
            // buttonSelectOurExcel
            // 
            buttonSelectOurExcel.Location = new Point(27, 91);
            buttonSelectOurExcel.Name = "buttonSelectOurExcel";
            buttonSelectOurExcel.Size = new Size(117, 41);
            buttonSelectOurExcel.TabIndex = 2;
            buttonSelectOurExcel.Text = "Mi excelünk kiválasztása";
            buttonSelectOurExcel.UseVisualStyleBackColor = true;
            buttonSelectOurExcel.Click += buttonSelectOurExcel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 319);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Svájci excel";
            // 
            // labelSwissExcel
            // 
            labelSwissExcel.AutoSize = true;
            labelSwissExcel.Location = new Point(27, 348);
            labelSwissExcel.Name = "labelSwissExcel";
            labelSwissExcel.Size = new Size(0, 15);
            labelSwissExcel.TabIndex = 4;
            // 
            // buttonSelectSwissExcel
            // 
            buttonSelectSwissExcel.Location = new Point(19, 366);
            buttonSelectSwissExcel.Name = "buttonSelectSwissExcel";
            buttonSelectSwissExcel.Size = new Size(125, 40);
            buttonSelectSwissExcel.TabIndex = 5;
            buttonSelectSwissExcel.Text = "Svájci excel kiválasztása";
            buttonSelectSwissExcel.UseVisualStyleBackColor = true;
            buttonSelectSwissExcel.Click += buttonSelectSwissExcel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxLaptop);
            groupBox1.Controls.Add(buttonSelectOurExcelLaptop);
            groupBox1.Controls.Add(labelOurExcelLaptop);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(19, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 178);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Laptop";
            // 
            // checkBoxLaptop
            // 
            checkBoxLaptop.AutoSize = true;
            checkBoxLaptop.Location = new Point(8, 140);
            checkBoxLaptop.Name = "checkBoxLaptop";
            checkBoxLaptop.Size = new Size(74, 19);
            checkBoxLaptop.TabIndex = 3;
            checkBoxLaptop.Text = "Laptop is";
            checkBoxLaptop.UseVisualStyleBackColor = true;
            checkBoxLaptop.CheckedChanged += checkBoxLaptop_CheckedChanged;
            // 
            // buttonSelectOurExcelLaptop
            // 
            buttonSelectOurExcelLaptop.Enabled = false;
            buttonSelectOurExcelLaptop.Location = new Point(8, 81);
            buttonSelectOurExcelLaptop.Name = "buttonSelectOurExcelLaptop";
            buttonSelectOurExcelLaptop.Size = new Size(119, 38);
            buttonSelectOurExcelLaptop.TabIndex = 2;
            buttonSelectOurExcelLaptop.Text = "Mi excelünk kiválasztása";
            buttonSelectOurExcelLaptop.UseVisualStyleBackColor = true;
            buttonSelectOurExcelLaptop.Click += buttonSelectOurExcelLaptop_Click;
            // 
            // labelOurExcelLaptop
            // 
            labelOurExcelLaptop.AutoSize = true;
            labelOurExcelLaptop.Location = new Point(8, 55);
            labelOurExcelLaptop.Name = "labelOurExcelLaptop";
            labelOurExcelLaptop.Size = new Size(0, 15);
            labelOurExcelLaptop.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 29);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 0;
            label3.Text = "Mi excelünk (Laptop)";
            // 
            // button1
            // 
            button1.Location = new Point(316, 389);
            button1.Name = "button1";
            button1.Size = new Size(159, 49);
            button1.TabIndex = 7;
            button1.Text = "Összehasonlítás";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(buttonSelectSwissExcel);
            Controls.Add(labelSwissExcel);
            Controls.Add(label2);
            Controls.Add(buttonSelectOurExcel);
            Controls.Add(labelOurExcel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Straumann Diff";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelOurExcel;
        private Button buttonSelectOurExcel;
        private Label label2;
        private Label labelSwissExcel;
        private Button buttonSelectSwissExcel;
        private GroupBox groupBox1;
        private Button buttonSelectOurExcelLaptop;
        private Label labelOurExcelLaptop;
        private Label label3;
        private CheckBox checkBoxLaptop;
        private Button button1;
    }
}
