namespace Övning4._2
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
            this.btnÖppnaFil = new System.Windows.Forms.Button();
            this.btnSparaFil = new System.Windows.Forms.Button();
            this.dlgÖppnaFil = new System.Windows.Forms.OpenFileDialog();
            this.dlgSparaFil = new System.Windows.Forms.SaveFileDialog();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.lblEpost = new System.Windows.Forms.Label();
            this.lblTelefonnummer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnÖppnaFil
            // 
            this.btnÖppnaFil.Location = new System.Drawing.Point(538, 165);
            this.btnÖppnaFil.Name = "btnÖppnaFil";
            this.btnÖppnaFil.Size = new System.Drawing.Size(124, 41);
            this.btnÖppnaFil.TabIndex = 0;
            this.btnÖppnaFil.Text = "ÖppnaFIl";
            this.btnÖppnaFil.UseVisualStyleBackColor = true;
            this.btnÖppnaFil.Click += new System.EventHandler(this.btnÖppnaFil_Click);
            // 
            // btnSparaFil
            // 
            this.btnSparaFil.ForeColor = System.Drawing.Color.Black;
            this.btnSparaFil.Location = new System.Drawing.Point(538, 232);
            this.btnSparaFil.Name = "btnSparaFil";
            this.btnSparaFil.Size = new System.Drawing.Size(112, 57);
            this.btnSparaFil.TabIndex = 1;
            this.btnSparaFil.Text = "Spara som...";
            this.btnSparaFil.UseVisualStyleBackColor = true;
            this.btnSparaFil.Click += new System.EventHandler(this.btnSparaFil_Click);
            // 
            // dlgÖppnaFil
            // 
            this.dlgÖppnaFil.FileName = "openFileDialog1";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(166, 31);
            this.tbxFörnamn.Multiline = true;
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(193, 33);
            this.tbxFörnamn.TabIndex = 2;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(166, 110);
            this.tbxEfternamn.Multiline = true;
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(193, 31);
            this.tbxEfternamn.TabIndex = 3;
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(166, 186);
            this.tbxEpost.Multiline = true;
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(193, 32);
            this.tbxEpost.TabIndex = 4;
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(166, 257);
            this.tbxTelefonnummer.Multiline = true;
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(193, 34);
            this.tbxTelefonnummer.TabIndex = 5;
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(12, 31);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(73, 20);
            this.lblFörnamn.TabIndex = 6;
            this.lblFörnamn.Text = "Förnamn";
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(12, 110);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(84, 20);
            this.lblEfternamn.TabIndex = 7;
            this.lblEfternamn.Text = "Efternamn";
            // 
            // lblEpost
            // 
            this.lblEpost.AutoSize = true;
            this.lblEpost.Location = new System.Drawing.Point(12, 186);
            this.lblEpost.Name = "lblEpost";
            this.lblEpost.Size = new System.Drawing.Size(56, 20);
            this.lblEpost.TabIndex = 8;
            this.lblEpost.Text = "E-post";
            // 
            // lblTelefonnummer
            // 
            this.lblTelefonnummer.AutoSize = true;
            this.lblTelefonnummer.Location = new System.Drawing.Point(12, 257);
            this.lblTelefonnummer.Name = "lblTelefonnummer";
            this.lblTelefonnummer.Size = new System.Drawing.Size(120, 20);
            this.lblTelefonnummer.TabIndex = 9;
            this.lblTelefonnummer.Text = "Telefonnummer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTelefonnummer);
            this.Controls.Add(this.lblEpost);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.lblFörnamn);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.btnSparaFil);
            this.Controls.Add(this.btnÖppnaFil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnÖppnaFil;
        private System.Windows.Forms.Button btnSparaFil;
        private System.Windows.Forms.OpenFileDialog dlgÖppnaFil;
        private System.Windows.Forms.SaveFileDialog dlgSparaFil;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.Label lblEpost;
        private System.Windows.Forms.Label lblTelefonnummer;
    }
}

