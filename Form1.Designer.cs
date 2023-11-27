namespace DDOOCP_Assignment_LishibaEmmanuelChiboboka
{
    partial class FormSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmdSignUp = new System.Windows.Forms.Button();
            this.cmdLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(264, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(264, 121);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(219, 20);
            this.txtPass.TabIndex = 3;
            // 
            // cmdSignUp
            // 
            this.cmdSignUp.Location = new System.Drawing.Point(264, 211);
            this.cmdSignUp.Name = "cmdSignUp";
            this.cmdSignUp.Size = new System.Drawing.Size(75, 38);
            this.cmdSignUp.TabIndex = 4;
            this.cmdSignUp.Text = "Sign Up";
            this.cmdSignUp.UseVisualStyleBackColor = true;
            this.cmdSignUp.Click += new System.EventHandler(this.cmdSignUp_Click_1);
            // 
            // cmdLog
            // 
            this.cmdLog.Location = new System.Drawing.Point(264, 310);
            this.cmdLog.Name = "cmdLog";
            this.cmdLog.Size = new System.Drawing.Size(75, 38);
            this.cmdLog.TabIndex = 5;
            this.cmdLog.Text = "Login";
            this.cmdLog.UseVisualStyleBackColor = true;
            this.cmdLog.Click += new System.EventHandler(this.cmdLog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Have an account already?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Welcome to our survey. You can sign up below to participate.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Re - Enter Password";
            // 
            // txtRe
            // 
            this.txtRe.Location = new System.Drawing.Point(264, 167);
            this.txtRe.Name = "txtRe";
            this.txtRe.PasswordChar = '*';
            this.txtRe.Size = new System.Drawing.Size(219, 20);
            this.txtRe.TabIndex = 9;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDOOCP_Assignment_LishibaEmmanuelChiboboka.Properties.Resources.coffee_5498486_1280__1_;
            this.ClientSize = new System.Drawing.Size(785, 440);
            this.Controls.Add(this.txtRe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdLog);
            this.Controls.Add(this.cmdSignUp);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(801, 479);
            this.Name = "FormSignUp";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.FormSur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button cmdSignUp;
        private System.Windows.Forms.Button cmdLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRe;
    }
}

