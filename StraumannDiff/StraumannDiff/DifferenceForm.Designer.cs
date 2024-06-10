namespace StraumannDiff
{
    partial class DifferenceForm
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
            listViewDifferences = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // listViewDifferences
            // 
            listViewDifferences.Location = new Point(32, 57);
            listViewDifferences.Name = "listViewDifferences";
            listViewDifferences.Size = new Size(275, 364);
            listViewDifferences.TabIndex = 1;
            listViewDifferences.UseCompatibleStateImageBehavior = false;
            listViewDifferences.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 24);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 2;
            label1.Text = "Összegzés";
            // 
            // DifferenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 462);
            Controls.Add(label1);
            Controls.Add(listViewDifferences);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DifferenceForm";
            Text = "DifferenceForm";
            Load += DifferenceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewDifferences;
        private Label label1;
    }
}