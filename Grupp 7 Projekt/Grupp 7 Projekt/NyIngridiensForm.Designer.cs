namespace Grupp_7_Projekt
{
    partial class NyIngridiensForm
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
            this.TextBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxKolh = new System.Windows.Forms.TextBox();
            this.TextBoxBeskr = new System.Windows.Forms.TextBox();
            this.textBoxFett = new System.Windows.Forms.TextBox();
            this.textBoxEnergy = new System.Windows.Forms.TextBox();
            this.textBoxProtein = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonNewingr = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WarningLable = new System.Windows.Forms.Label();
            this.comboBoxEnhet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextBoxNamn
            // 
            this.TextBoxNamn.Location = new System.Drawing.Point(161, 7);
            this.TextBoxNamn.Name = "TextBoxNamn";
            this.TextBoxNamn.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNamn.TabIndex = 0;
            // 
            // textBoxKolh
            // 
            this.textBoxKolh.Location = new System.Drawing.Point(161, 122);
            this.textBoxKolh.Name = "textBoxKolh";
            this.textBoxKolh.Size = new System.Drawing.Size(100, 20);
            this.textBoxKolh.TabIndex = 3;
            // 
            // TextBoxBeskr
            // 
            this.TextBoxBeskr.Location = new System.Drawing.Point(161, 31);
            this.TextBoxBeskr.Name = "TextBoxBeskr";
            this.TextBoxBeskr.Size = new System.Drawing.Size(100, 20);
            this.TextBoxBeskr.TabIndex = 1;
            // 
            // textBoxFett
            // 
            this.textBoxFett.Location = new System.Drawing.Point(161, 148);
            this.textBoxFett.Name = "textBoxFett";
            this.textBoxFett.Size = new System.Drawing.Size(100, 20);
            this.textBoxFett.TabIndex = 4;
            // 
            // textBoxEnergy
            // 
            this.textBoxEnergy.Location = new System.Drawing.Point(161, 174);
            this.textBoxEnergy.Name = "textBoxEnergy";
            this.textBoxEnergy.Size = new System.Drawing.Size(100, 20);
            this.textBoxEnergy.TabIndex = 5;
            // 
            // textBoxProtein
            // 
            this.textBoxProtein.Location = new System.Drawing.Point(161, 200);
            this.textBoxProtein.Name = "textBoxProtein";
            this.textBoxProtein.Size = new System.Drawing.Size(100, 20);
            this.textBoxProtein.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fett:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 38);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Beskrivning:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kolhydrater:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Energy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Protein:";
            // 
            // ButtonNewingr
            // 
            this.ButtonNewingr.Location = new System.Drawing.Point(113, 257);
            this.ButtonNewingr.Name = "ButtonNewingr";
            this.ButtonNewingr.Size = new System.Drawing.Size(105, 48);
            this.ButtonNewingr.TabIndex = 7;
            this.ButtonNewingr.Text = "Skapa Ny";
            this.ButtonNewingr.UseVisualStyleBackColor = true;
            this.ButtonNewingr.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Enhet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "%";
            // 
            // WarningLable
            // 
            this.WarningLable.AutoSize = true;
            this.WarningLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLable.ForeColor = System.Drawing.Color.Red;
            this.WarningLable.Location = new System.Drawing.Point(49, 101);
            this.WarningLable.Name = "WarningLable";
            this.WarningLable.Size = new System.Drawing.Size(214, 18);
            this.WarningLable.TabIndex = 16;
            this.WarningLable.Text = "OBS! Ange värden per 100g";
            this.WarningLable.Visible = false;
            // 
            // comboBoxEnhet
            // 
            this.comboBoxEnhet.FormattingEnabled = true;
            this.comboBoxEnhet.Location = new System.Drawing.Point(161, 57);
            this.comboBoxEnhet.Name = "comboBoxEnhet";
            this.comboBoxEnhet.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEnhet.TabIndex = 18;
            this.comboBoxEnhet.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEnhet_Change);
            // 
            // NyIngridiensForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 317);
            this.Controls.Add(this.comboBoxEnhet);
            this.Controls.Add(this.WarningLable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ButtonNewingr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProtein);
            this.Controls.Add(this.textBoxEnergy);
            this.Controls.Add(this.textBoxFett);
            this.Controls.Add(this.TextBoxBeskr);
            this.Controls.Add(this.textBoxKolh);
            this.Controls.Add(this.TextBoxNamn);
            this.Name = "NyIngridiensForm";
            this.Text = "Skapa ny Ingr";
            this.Load += new System.EventHandler(this.NyIngridiensForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNamn;
        private System.Windows.Forms.TextBox textBoxKolh;
        private System.Windows.Forms.TextBox TextBoxBeskr;
        private System.Windows.Forms.TextBox textBoxFett;
        private System.Windows.Forms.TextBox textBoxEnergy;
        private System.Windows.Forms.TextBox textBoxProtein;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonNewingr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label WarningLable;
        private System.Windows.Forms.ComboBox comboBoxEnhet;
    }
}