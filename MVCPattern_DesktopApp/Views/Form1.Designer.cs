namespace MVCPattern_DesktopApp.Views
{
    partial class Form1
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
            this.Students = new System.Windows.Forms.ListBox();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.FormattingEnabled = true;
            this.Students.Location = new System.Drawing.Point(28, 42);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(258, 160);
            this.Students.TabIndex = 0;
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(28, 209);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(258, 20);
            this.StudentName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(196, 244);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(90, 39);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(28, 296);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(258, 39);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(25, 9);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(56, 13);
            this.Count.TabIndex = 5;
            this.Count.Text = "0 students";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 347);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.Students);
            this.Name = "Form1";
            this.Text = "MVCPattern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Students;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label Count;
    }
}

