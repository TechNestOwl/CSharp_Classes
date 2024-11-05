namespace MyClasses
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
            testAddress_btn = new Button();
            testPatient_btn = new Button();
            testMyDate_btn = new Button();
            SuspendLayout();
            // 
            // testAddress_btn
            // 
            testAddress_btn.Location = new Point(151, 113);
            testAddress_btn.Name = "testAddress_btn";
            testAddress_btn.Size = new Size(83, 25);
            testAddress_btn.TabIndex = 0;
            testAddress_btn.Text = "Test Address";
            testAddress_btn.UseVisualStyleBackColor = true;
            testAddress_btn.Click += testAddress_btn_Click;
            // 
            // testPatient_btn
            // 
            testPatient_btn.Location = new Point(352, 113);
            testPatient_btn.Name = "testPatient_btn";
            testPatient_btn.Size = new Size(83, 25);
            testPatient_btn.TabIndex = 1;
            testPatient_btn.Text = "Test Patient";
            testPatient_btn.UseVisualStyleBackColor = true;
            testPatient_btn.Click += testPatient_btn_Click;
            // 
            // testMyDate_btn
            // 
            testMyDate_btn.Location = new Point(549, 113);
            testMyDate_btn.Name = "testMyDate_btn";
            testMyDate_btn.Size = new Size(152, 25);
            testMyDate_btn.TabIndex = 2;
            testMyDate_btn.Text = "Test My Date";
            testMyDate_btn.UseVisualStyleBackColor = true;
            testMyDate_btn.Click += testMyDate_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testMyDate_btn);
            Controls.Add(testPatient_btn);
            Controls.Add(testAddress_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button testAddress_btn;
        private Button testPatient_btn;
        private Button testMyDate_btn;
    }
}
