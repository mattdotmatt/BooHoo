namespace BooHoo
{
    partial class BooMe
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
            this.btnBoo = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnJudgeAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoo
            // 
            this.btnBoo.Location = new System.Drawing.Point(103, 92);
            this.btnBoo.Name = "btnBoo";
            this.btnBoo.Size = new System.Drawing.Size(177, 36);
            this.btnBoo.TabIndex = 0;
            this.btnBoo.Text = "Judge Me";
            this.btnBoo.UseVisualStyleBackColor = true;
            this.btnBoo.Click += new System.EventHandler(this.btnBoo_Click);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(13, 13);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(65, 13);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age in years";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(13, 54);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(103, 10);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(177, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(103, 51);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(177, 20);
            this.txtSalary.TabIndex = 6;
            // 
            // btnJudgeAgain
            // 
            this.btnJudgeAgain.Location = new System.Drawing.Point(103, 144);
            this.btnJudgeAgain.Name = "btnJudgeAgain";
            this.btnJudgeAgain.Size = new System.Drawing.Size(177, 36);
            this.btnJudgeAgain.TabIndex = 7;
            this.btnJudgeAgain.Text = "Judge Me Again";
            this.btnJudgeAgain.UseVisualStyleBackColor = true;
            this.btnJudgeAgain.Click += new System.EventHandler(this.btnJudgeAgain_Click);
            // 
            // BooMe
            // 
            this.ClientSize = new System.Drawing.Size(292, 186);
            this.Controls.Add(this.btnJudgeAgain);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnBoo);
            this.Name = "BooMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoo;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnJudgeAgain;
    }
}

