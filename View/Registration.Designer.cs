namespace ParkApplication
{
    partial class Registration
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
            this.pnrtextbox1 = new System.Windows.Forms.TextBox();
            this.firstnametextbox1 = new System.Windows.Forms.TextBox();
            this.firstnamelabel1 = new System.Windows.Forms.Label();
            this.regbtn1 = new System.Windows.Forms.Button();
            this.pnrlabel1 = new System.Windows.Forms.Label();
            this.lastnamelabel1 = new System.Windows.Forms.Label();
            this.lastnametextbox1 = new System.Windows.Forms.TextBox();
            this.passwordlabel2 = new System.Windows.Forms.Label();
            this.passwordtextbox1 = new System.Windows.Forms.TextBox();
            this.Ångrabtn1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnrtextbox1
            // 
            this.pnrtextbox1.Location = new System.Drawing.Point(269, 58);
            this.pnrtextbox1.Name = "pnrtextbox1";
            this.pnrtextbox1.Size = new System.Drawing.Size(237, 20);
            this.pnrtextbox1.TabIndex = 17;
            this.pnrtextbox1.TextChanged += new System.EventHandler(this.pnrtextbox1_TextChanged);
            this.pnrtextbox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pnrtextbox1_KeyDown);
            this.pnrtextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pnrtextbox1_KeyPress_1);
            // 
            // firstnametextbox1
            // 
            this.firstnametextbox1.Location = new System.Drawing.Point(269, 101);
            this.firstnametextbox1.Name = "firstnametextbox1";
            this.firstnametextbox1.Size = new System.Drawing.Size(237, 20);
            this.firstnametextbox1.TabIndex = 18;
            // 
            // firstnamelabel1
            // 
            this.firstnamelabel1.AutoSize = true;
            this.firstnamelabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel1.Location = new System.Drawing.Point(163, 101);
            this.firstnamelabel1.Name = "firstnamelabel1";
            this.firstnamelabel1.Size = new System.Drawing.Size(90, 18);
            this.firstnamelabel1.TabIndex = 21;
            this.firstnamelabel1.Text = "Förnamn:";
            // 
            // regbtn1
            // 
            this.regbtn1.Location = new System.Drawing.Point(343, 224);
            this.regbtn1.Name = "regbtn1";
            this.regbtn1.Size = new System.Drawing.Size(75, 31);
            this.regbtn1.TabIndex = 22;
            this.regbtn1.Text = "Registrera";
            this.regbtn1.UseVisualStyleBackColor = true;
            this.regbtn1.Click += new System.EventHandler(this.regbtn1_Click);
            this.regbtn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.regbtn1_KeyPress);
            // 
            // pnrlabel1
            // 
            this.pnrlabel1.AutoSize = true;
            this.pnrlabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnrlabel1.Location = new System.Drawing.Point(107, 58);
            this.pnrlabel1.Name = "pnrlabel1";
            this.pnrlabel1.Size = new System.Drawing.Size(146, 18);
            this.pnrlabel1.TabIndex = 20;
            this.pnrlabel1.Text = "Personnummer:";
            // 
            // lastnamelabel1
            // 
            this.lastnamelabel1.AutoSize = true;
            this.lastnamelabel1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel1.Location = new System.Drawing.Point(144, 144);
            this.lastnamelabel1.Name = "lastnamelabel1";
            this.lastnamelabel1.Size = new System.Drawing.Size(109, 18);
            this.lastnamelabel1.TabIndex = 24;
            this.lastnamelabel1.Text = "Efternamn:";
            // 
            // lastnametextbox1
            // 
            this.lastnametextbox1.Location = new System.Drawing.Point(269, 144);
            this.lastnametextbox1.Name = "lastnametextbox1";
            this.lastnametextbox1.Size = new System.Drawing.Size(237, 20);
            this.lastnametextbox1.TabIndex = 23;
            // 
            // passwordlabel2
            // 
            this.passwordlabel2.AutoSize = true;
            this.passwordlabel2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel2.Location = new System.Drawing.Point(156, 188);
            this.passwordlabel2.Name = "passwordlabel2";
            this.passwordlabel2.Size = new System.Drawing.Size(97, 18);
            this.passwordlabel2.TabIndex = 26;
            this.passwordlabel2.Text = "Lösenord:";
            // 
            // passwordtextbox1
            // 
            this.passwordtextbox1.Location = new System.Drawing.Point(269, 188);
            this.passwordtextbox1.Name = "passwordtextbox1";
            this.passwordtextbox1.PasswordChar = '*';
            this.passwordtextbox1.Size = new System.Drawing.Size(237, 20);
            this.passwordtextbox1.TabIndex = 25;
            // 
            // Ångrabtn1
            // 
            this.Ångrabtn1.Location = new System.Drawing.Point(431, 224);
            this.Ångrabtn1.Name = "Ångrabtn1";
            this.Ångrabtn1.Size = new System.Drawing.Size(75, 31);
            this.Ångrabtn1.TabIndex = 27;
            this.Ångrabtn1.Text = "Tillbaka";
            this.Ångrabtn1.UseVisualStyleBackColor = true;
            this.Ångrabtn1.Click += new System.EventHandler(this.Ångrabtn1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(301, 291);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 29;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 316);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.Ångrabtn1);
            this.Controls.Add(this.passwordlabel2);
            this.Controls.Add(this.passwordtextbox1);
            this.Controls.Add(this.lastnamelabel1);
            this.Controls.Add(this.lastnametextbox1);
            this.Controls.Add(this.regbtn1);
            this.Controls.Add(this.pnrlabel1);
            this.Controls.Add(this.pnrtextbox1);
            this.Controls.Add(this.firstnamelabel1);
            this.Controls.Add(this.firstnametextbox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pnrtextbox1;
        private System.Windows.Forms.TextBox firstnametextbox1;
        private System.Windows.Forms.Label firstnamelabel1;
        private System.Windows.Forms.Button regbtn1;
        private System.Windows.Forms.Label pnrlabel1;
        private System.Windows.Forms.Label lastnamelabel1;
        private System.Windows.Forms.TextBox lastnametextbox1;
        private System.Windows.Forms.Label passwordlabel2;
        private System.Windows.Forms.TextBox passwordtextbox1;
        private System.Windows.Forms.Button Ångrabtn1;
        private System.Windows.Forms.Label ErrorLabel;
    }
}