namespace CALC
{
    partial class Form2
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
            this.Loginbtn = new System.Windows.Forms.Button();
            this.userfield = new System.Windows.Forms.TextBox();
            this.passwordfield = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.passwordfield);
            this.panel1.Controls.Add(this.userfield);
            this.panel1.Controls.Add(this.Loginbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 223);
            this.panel1.TabIndex = 0;
            // 
            // Loginbtn
            // 
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Loginbtn.Location = new System.Drawing.Point(196, 161);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(150, 50);
            this.Loginbtn.TabIndex = 0;
            this.Loginbtn.Text = "Войти";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // userfield
            // 
            this.userfield.Location = new System.Drawing.Point(182, 45);
            this.userfield.Multiline = true;
            this.userfield.Name = "userfield";
            this.userfield.Size = new System.Drawing.Size(185, 41);
            this.userfield.TabIndex = 2;
            // 
            // passwordfield
            // 
            this.passwordfield.Location = new System.Drawing.Point(182, 92);
            this.passwordfield.Multiline = true;
            this.passwordfield.Name = "passwordfield";
            this.passwordfield.Size = new System.Drawing.Size(185, 41);
            this.passwordfield.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(538, 223);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordfield;
        private System.Windows.Forms.TextBox userfield;
        private System.Windows.Forms.Button Loginbtn;
    }
}