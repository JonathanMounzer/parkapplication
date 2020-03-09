namespace ParkApplication
{
    partial class Inloggning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inloggning));
            this.regbtn1 = new System.Windows.Forms.Button();
            this.pnrlabel1 = new System.Windows.Forms.Label();
            this.loginlabel1 = new System.Windows.Forms.Label();
            this.pnrtextbox1 = new System.Windows.Forms.TextBox();
            this.loginlogo = new System.Windows.Forms.Panel();
            this.passwordlabel1 = new System.Windows.Forms.Label();
            this.passwordtextbox1 = new System.Windows.Forms.TextBox();
            this.loginbtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // regbtn1
            // 
            this.regbtn1.Location = new System.Drawing.Point(373, 376);
            this.regbtn1.Name = "regbtn1";
            this.regbtn1.Size = new System.Drawing.Size(75, 23);
            this.regbtn1.TabIndex = 16;
            this.regbtn1.Text = "Registrera";
            this.regbtn1.UseVisualStyleBackColor = true;
            this.regbtn1.Click += new System.EventHandler(this.regbtn1_Click);
            // 
            // pnrlabel1
            // 
            this.pnrlabel1.AutoSize = true;
            this.pnrlabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnrlabel1.Location = new System.Drawing.Point(49, 292);
            this.pnrlabel1.Name = "pnrlabel1";
            this.pnrlabel1.Size = new System.Drawing.Size(146, 18);
            this.pnrlabel1.TabIndex = 12;
            this.pnrlabel1.Text = "Personnummer:";
            // 
            // loginlabel1
            // 
            this.loginlabel1.AutoSize = true;
            this.loginlabel1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel1.Location = new System.Drawing.Point(27, 23);
            this.loginlabel1.Name = "loginlabel1";
            this.loginlabel1.Size = new System.Drawing.Size(183, 32);
            this.loginlabel1.TabIndex = 14;
            this.loginlabel1.Text = "Inloggning";
            // 
            // pnrtextbox1
            // 
            this.pnrtextbox1.Location = new System.Drawing.Point(211, 290);
            this.pnrtextbox1.Name = "pnrtextbox1";
            this.pnrtextbox1.Size = new System.Drawing.Size(237, 20);
            this.pnrtextbox1.TabIndex = 9;
            // 
            // loginlogo
            // 
            this.loginlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginlogo.BackgroundImage")));
            this.loginlogo.Location = new System.Drawing.Point(27, -8);
            this.loginlogo.Name = "loginlogo";
            this.loginlogo.Size = new System.Drawing.Size(923, 281);
            this.loginlogo.TabIndex = 15;
            // 
            // passwordlabel1
            // 
            this.passwordlabel1.AutoSize = true;
            this.passwordlabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel1.Location = new System.Drawing.Point(98, 333);
            this.passwordlabel1.Name = "passwordlabel1";
            this.passwordlabel1.Size = new System.Drawing.Size(97, 18);
            this.passwordlabel1.TabIndex = 13;
            this.passwordlabel1.Text = "Lösenord:";
            // 
            // passwordtextbox1
            // 
            this.passwordtextbox1.Location = new System.Drawing.Point(211, 333);
            this.passwordtextbox1.Name = "passwordtextbox1";
            this.passwordtextbox1.PasswordChar = '*';
            this.passwordtextbox1.Size = new System.Drawing.Size(237, 20);
            this.passwordtextbox1.TabIndex = 10;
            // 
            // loginbtn1
            // 
            this.loginbtn1.Location = new System.Drawing.Point(292, 376);
            this.loginbtn1.Name = "loginbtn1";
            this.loginbtn1.Size = new System.Drawing.Size(75, 23);
            this.loginbtn1.TabIndex = 11;
            this.loginbtn1.Text = "Logga in";
            this.loginbtn1.UseVisualStyleBackColor = true;
            this.loginbtn1.Click += new System.EventHandler(this.loginbtn1_Click);
            // 
            // Inloggning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 422);
            this.Controls.Add(this.regbtn1);
            this.Controls.Add(this.pnrlabel1);
            this.Controls.Add(this.loginlabel1);
            this.Controls.Add(this.pnrtextbox1);
            this.Controls.Add(this.loginlogo);
            this.Controls.Add(this.passwordlabel1);
            this.Controls.Add(this.passwordtextbox1);
            this.Controls.Add(this.loginbtn1);
            this.Name = "Inloggning";
            this.Text = "Inloggning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button regbtn1;
        private System.Windows.Forms.Label pnrlabel1;
        private System.Windows.Forms.Label loginlabel1;
        private System.Windows.Forms.TextBox pnrtextbox1;
        private System.Windows.Forms.Panel loginlogo;
        private System.Windows.Forms.Label passwordlabel1;
        private System.Windows.Forms.TextBox passwordtextbox1;
        private System.Windows.Forms.Button loginbtn1;
    }
}

