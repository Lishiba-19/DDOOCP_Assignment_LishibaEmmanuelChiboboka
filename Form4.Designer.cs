namespace DDOOCP_Assignment_LishibaEmmanuelChiboboka
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.cmdAS = new System.Windows.Forms.Button();
            this.cmdCS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmdLogOut);
            this.panel1.Controls.Add(this.cmdAS);
            this.panel1.Controls.Add(this.cmdCS);
            this.panel1.Location = new System.Drawing.Point(677, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 600);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Answer main survey";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.Location = new System.Drawing.Point(25, 197);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(75, 28);
            this.cmdLogOut.TabIndex = 3;
            this.cmdLogOut.Text = "Log Out";
            this.cmdLogOut.UseVisualStyleBackColor = true;
            this.cmdLogOut.Click += new System.EventHandler(this.cmdLogOut_Click_1);
            // 
            // cmdAS
            // 
            this.cmdAS.Location = new System.Drawing.Point(25, 81);
            this.cmdAS.Name = "cmdAS";
            this.cmdAS.Size = new System.Drawing.Size(75, 35);
            this.cmdAS.TabIndex = 2;
            this.cmdAS.Text = "View Analysis";
            this.cmdAS.UseVisualStyleBackColor = true;
            this.cmdAS.Click += new System.EventHandler(this.cmdAS_Click_1);
            // 
            // cmdCS
            // 
            this.cmdCS.Location = new System.Drawing.Point(25, 33);
            this.cmdCS.Name = "cmdCS";
            this.cmdCS.Size = new System.Drawing.Size(75, 42);
            this.cmdCS.TabIndex = 1;
            this.cmdCS.Text = "Create Survey";
            this.cmdCS.UseVisualStyleBackColor = true;
            this.cmdCS.Click += new System.EventHandler(this.cmdCS_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 67);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Location = new System.Drawing.Point(-1, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(672, 600);
            this.panel3.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form4";
            this.Text = "Admin Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdLogOut;
        private System.Windows.Forms.Button cmdAS;
        private System.Windows.Forms.Button cmdCS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}