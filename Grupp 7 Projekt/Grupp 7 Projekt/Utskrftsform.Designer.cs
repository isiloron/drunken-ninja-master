namespace Grupp_7_Projekt
{
    partial class Utskrftsform
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
            this.textBoxutskrift = new System.Windows.Forms.TextBox();
            this.lbltitelut = new System.Windows.Forms.Label();
            this.textBoxnärut = new System.Windows.Forms.TextBox();
            this.textBoxtilut = new System.Windows.Forms.TextBox();
            this.pictureBoxut = new System.Windows.Forms.PictureBox();
            this.lblingut = new System.Windows.Forms.Label();
            this.lbltilut = new System.Windows.Forms.Label();
            this.textBoxPortUt = new System.Windows.Forms.TextBox();
            this.lblnärut = new System.Windows.Forms.Label();
            this.pictureBoxbakgrund = new System.Windows.Forms.PictureBox();
            this.btnskrivut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbakgrund)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxutskrift
            // 
            this.textBoxutskrift.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxutskrift.Location = new System.Drawing.Point(28, 49);
            this.textBoxutskrift.Multiline = true;
            this.textBoxutskrift.Name = "textBoxutskrift";
            this.textBoxutskrift.ReadOnly = true;
            this.textBoxutskrift.Size = new System.Drawing.Size(223, 429);
            this.textBoxutskrift.TabIndex = 0;
            // 
            // lbltitelut
            // 
            this.lbltitelut.AutoSize = true;
            this.lbltitelut.BackColor = System.Drawing.SystemColors.Window;
            this.lbltitelut.Location = new System.Drawing.Point(28, 33);
            this.lbltitelut.Name = "lbltitelut";
            this.lbltitelut.Size = new System.Drawing.Size(35, 13);
            this.lbltitelut.TabIndex = 1;
            this.lbltitelut.Text = "label1";
            // 
            // textBoxnärut
            // 
            this.textBoxnärut.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxnärut.Location = new System.Drawing.Point(28, 572);
            this.textBoxnärut.Multiline = true;
            this.textBoxnärut.Name = "textBoxnärut";
            this.textBoxnärut.Size = new System.Drawing.Size(186, 90);
            this.textBoxnärut.TabIndex = 2;
            // 
            // textBoxtilut
            // 
            this.textBoxtilut.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxtilut.Location = new System.Drawing.Point(295, 210);
            this.textBoxtilut.Multiline = true;
            this.textBoxtilut.Name = "textBoxtilut";
            this.textBoxtilut.ReadOnly = true;
            this.textBoxtilut.Size = new System.Drawing.Size(260, 423);
            this.textBoxtilut.TabIndex = 3;
            // 
            // pictureBoxut
            // 
            this.pictureBoxut.Location = new System.Drawing.Point(331, 29);
            this.pictureBoxut.Name = "pictureBoxut";
            this.pictureBoxut.Size = new System.Drawing.Size(190, 150);
            this.pictureBoxut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxut.TabIndex = 4;
            this.pictureBoxut.TabStop = false;
            // 
            // lblingut
            // 
            this.lblingut.AutoSize = true;
            this.lblingut.BackColor = System.Drawing.SystemColors.Window;
            this.lblingut.Location = new System.Drawing.Point(86, 493);
            this.lblingut.Name = "lblingut";
            this.lblingut.Size = new System.Drawing.Size(75, 13);
            this.lblingut.TabIndex = 5;
            this.lblingut.Text = "Antal portioner";
            // 
            // lbltilut
            // 
            this.lbltilut.AutoSize = true;
            this.lbltilut.BackColor = System.Drawing.SystemColors.Window;
            this.lbltilut.Location = new System.Drawing.Point(292, 194);
            this.lbltilut.Name = "lbltilut";
            this.lbltilut.Size = new System.Drawing.Size(52, 13);
            this.lbltilut.TabIndex = 7;
            this.lbltilut.Text = "Tillagning";
            // 
            // textBoxPortUt
            // 
            this.textBoxPortUt.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPortUt.Location = new System.Drawing.Point(102, 509);
            this.textBoxPortUt.Name = "textBoxPortUt";
            this.textBoxPortUt.ReadOnly = true;
            this.textBoxPortUt.Size = new System.Drawing.Size(39, 20);
            this.textBoxPortUt.TabIndex = 8;
            // 
            // lblnärut
            // 
            this.lblnärut.AutoSize = true;
            this.lblnärut.BackColor = System.Drawing.SystemColors.Window;
            this.lblnärut.Location = new System.Drawing.Point(28, 556);
            this.lblnärut.Name = "lblnärut";
            this.lblnärut.Size = new System.Drawing.Size(76, 13);
            this.lblnärut.TabIndex = 9;
            this.lblnärut.Text = "Näringsvärden";
            // 
            // pictureBoxbakgrund
            // 
            this.pictureBoxbakgrund.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxbakgrund.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxbakgrund.Name = "pictureBoxbakgrund";
            this.pictureBoxbakgrund.Size = new System.Drawing.Size(555, 670);
            this.pictureBoxbakgrund.TabIndex = 10;
            this.pictureBoxbakgrund.TabStop = false;
            // 
            // btnskrivut
            // 
            this.btnskrivut.BackColor = System.Drawing.SystemColors.Menu;
            this.btnskrivut.Location = new System.Drawing.Point(456, 639);
            this.btnskrivut.Name = "btnskrivut";
            this.btnskrivut.Size = new System.Drawing.Size(75, 23);
            this.btnskrivut.TabIndex = 11;
            this.btnskrivut.Text = "Skriv ut";
            this.btnskrivut.UseVisualStyleBackColor = false;
            this.btnskrivut.Click += new System.EventHandler(this.btnskrivut_Click);
            // 
            // Utskrftsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grupp_7_Projekt.Properties.Resources.tblcloth;
            this.ClientSize = new System.Drawing.Size(579, 694);
            this.Controls.Add(this.btnskrivut);
            this.Controls.Add(this.pictureBoxbakgrund);
            this.Controls.Add(this.lblnärut);
            this.Controls.Add(this.textBoxPortUt);
            this.Controls.Add(this.lbltilut);
            this.Controls.Add(this.lblingut);
            this.Controls.Add(this.pictureBoxut);
            this.Controls.Add(this.textBoxtilut);
            this.Controls.Add(this.textBoxnärut);
            this.Controls.Add(this.lbltitelut);
            this.Controls.Add(this.textBoxutskrift);
            this.Name = "Utskrftsform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Utskrftsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbakgrund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxutskrift;
        private System.Windows.Forms.Label lbltitelut;
        private System.Windows.Forms.TextBox textBoxnärut;
        private System.Windows.Forms.TextBox textBoxtilut;
        private System.Windows.Forms.PictureBox pictureBoxut;
        private System.Windows.Forms.Label lblingut;
        private System.Windows.Forms.Label lbltilut;
        private System.Windows.Forms.TextBox textBoxPortUt;
        private System.Windows.Forms.Label lblnärut;
        private System.Windows.Forms.PictureBox pictureBoxbakgrund;
        private System.Windows.Forms.Button btnskrivut;

    }
}