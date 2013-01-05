namespace Grupp_7_Projekt
{
    partial class Receptsida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptsida));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonRemoveRecepie = new System.Windows.Forms.Button();
            this.ButtonNyttRecept = new System.Windows.Forms.Button();
            this.ListBoxRecept = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonRemoveIngr = new System.Windows.Forms.Button();
            this.ButtonNewingr = new System.Windows.Forms.Button();
            this.listBoxIngr = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRubrik = new System.Windows.Forms.Label();
            this.lblNär = new System.Windows.Forms.Label();
            this.lblTil = new System.Windows.Forms.Label();
            this.lblIng = new System.Windows.Forms.Label();
            this.textBoxNär = new System.Windows.Forms.TextBox();
            this.textBoxTil = new System.Windows.Forms.TextBox();
            this.textBoxIngr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Location = new System.Drawing.Point(457, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(497, 588);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(39, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 622);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.IndexChange);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.ButtonRemoveRecepie);
            this.tabPage1.Controls.Add(this.ButtonNyttRecept);
            this.tabPage1.Controls.Add(this.ListBoxRecept);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(379, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recept";
            // 
            // ButtonRemoveRecepie
            // 
            this.ButtonRemoveRecepie.Location = new System.Drawing.Point(242, 102);
            this.ButtonRemoveRecepie.Name = "ButtonRemoveRecepie";
            this.ButtonRemoveRecepie.Size = new System.Drawing.Size(121, 23);
            this.ButtonRemoveRecepie.TabIndex = 3;
            this.ButtonRemoveRecepie.Text = "Ta bort";
            this.ButtonRemoveRecepie.UseVisualStyleBackColor = true;
            this.ButtonRemoveRecepie.Click += new System.EventHandler(this.ButtonRemoveRecepie_Click);
            // 
            // ButtonNyttRecept
            // 
            this.ButtonNyttRecept.Location = new System.Drawing.Point(242, 73);
            this.ButtonNyttRecept.Name = "ButtonNyttRecept";
            this.ButtonNyttRecept.Size = new System.Drawing.Size(121, 23);
            this.ButtonNyttRecept.TabIndex = 2;
            this.ButtonNyttRecept.Text = "Nytt Recept";
            this.ButtonNyttRecept.UseVisualStyleBackColor = true;
            this.ButtonNyttRecept.Click += new System.EventHandler(this.ButtonNyttRecept_Click);
            // 
            // ListBoxRecept
            // 
            this.ListBoxRecept.FormattingEnabled = true;
            this.ListBoxRecept.ItemHeight = 18;
            this.ListBoxRecept.Location = new System.Drawing.Point(12, 71);
            this.ListBoxRecept.Name = "ListBoxRecept";
            this.ListBoxRecept.Size = new System.Drawing.Size(224, 490);
            this.ListBoxRecept.TabIndex = 1;
            this.ListBoxRecept.SelectedIndexChanged += new System.EventHandler(this.listBoxRecept_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recept";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonRemoveIngr);
            this.tabPage2.Controls.Add(this.ButtonNewingr);
            this.tabPage2.Controls.Add(this.listBoxIngr);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(379, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingredienser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonRemoveIngr
            // 
            this.ButtonRemoveIngr.Location = new System.Drawing.Point(271, 102);
            this.ButtonRemoveIngr.Name = "ButtonRemoveIngr";
            this.ButtonRemoveIngr.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemoveIngr.TabIndex = 6;
            this.ButtonRemoveIngr.Text = "Ta Bort";
            this.ButtonRemoveIngr.UseVisualStyleBackColor = true;
            this.ButtonRemoveIngr.Click += new System.EventHandler(this.ButtonRemoveIngr_Click);
            // 
            // ButtonNewingr
            // 
            this.ButtonNewingr.Location = new System.Drawing.Point(271, 73);
            this.ButtonNewingr.Name = "ButtonNewingr";
            this.ButtonNewingr.Size = new System.Drawing.Size(75, 23);
            this.ButtonNewingr.TabIndex = 5;
            this.ButtonNewingr.Text = "Ny";
            this.ButtonNewingr.UseVisualStyleBackColor = true;
            this.ButtonNewingr.Click += new System.EventHandler(this.ButtonNewingr_Click);
            // 
            // listBoxIngr
            // 
            this.listBoxIngr.FormattingEnabled = true;
            this.listBoxIngr.Location = new System.Drawing.Point(12, 71);
            this.listBoxIngr.Name = "listBoxIngr";
            this.listBoxIngr.Size = new System.Drawing.Size(236, 498);
            this.listBoxIngr.TabIndex = 4;
            this.listBoxIngr.SelectedIndexChanged += new System.EventHandler(this.listBoxIngr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredienser";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(379, 584);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sök";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sök";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Grupp_7_Projekt.Properties.Resources.chopped_fingers;
            this.pictureBox1.Location = new System.Drawing.Point(680, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblRubrik
            // 
            this.lblRubrik.AutoSize = true;
            this.lblRubrik.BackColor = System.Drawing.SystemColors.Window;
            this.lblRubrik.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubrik.Location = new System.Drawing.Point(474, 88);
            this.lblRubrik.Name = "lblRubrik";
            this.lblRubrik.Size = new System.Drawing.Size(422, 49);
            this.lblRubrik.TabIndex = 7;
            this.lblRubrik.Text = "\"Långaste namnet bror\"";
            // 
            // lblNär
            // 
            this.lblNär.AutoSize = true;
            this.lblNär.BackColor = System.Drawing.SystemColors.Window;
            this.lblNär.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNär.Location = new System.Drawing.Point(479, 365);
            this.lblNär.Name = "lblNär";
            this.lblNär.Size = new System.Drawing.Size(131, 23);
            this.lblNär.TabIndex = 8;
            this.lblNär.Text = "Näringsvärden:";
            // 
            // lblTil
            // 
            this.lblTil.AutoSize = true;
            this.lblTil.BackColor = System.Drawing.SystemColors.Window;
            this.lblTil.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTil.Location = new System.Drawing.Point(676, 365);
            this.lblTil.Name = "lblTil";
            this.lblTil.Size = new System.Drawing.Size(91, 23);
            this.lblTil.TabIndex = 9;
            this.lblTil.Text = "Tillagning:";
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.BackColor = System.Drawing.SystemColors.Window;
            this.lblIng.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIng.Location = new System.Drawing.Point(479, 139);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(116, 23);
            this.lblIng.TabIndex = 10;
            this.lblIng.Text = "Ingredienser:";
            // 
            // textBoxNär
            // 
            this.textBoxNär.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNär.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNär.Location = new System.Drawing.Point(483, 392);
            this.textBoxNär.Multiline = true;
            this.textBoxNär.Name = "textBoxNär";
            this.textBoxNär.Size = new System.Drawing.Size(186, 243);
            this.textBoxNär.TabIndex = 11;
            this.textBoxNär.Text = "Mycket bra näring";
            // 
            // textBoxTil
            // 
            this.textBoxTil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTil.Location = new System.Drawing.Point(680, 392);
            this.textBoxTil.Multiline = true;
            this.textBoxTil.Name = "textBoxTil";
            this.textBoxTil.Size = new System.Drawing.Size(259, 243);
            this.textBoxTil.TabIndex = 12;
            this.textBoxTil.Text = "iadjawhdwaidhawdihawdhiawhid";
            // 
            // textBoxIngr
            // 
            this.textBoxIngr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIngr.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIngr.Location = new System.Drawing.Point(483, 165);
            this.textBoxIngr.Multiline = true;
            this.textBoxIngr.Name = "textBoxIngr";
            this.textBoxIngr.Size = new System.Drawing.Size(186, 183);
            this.textBoxIngr.TabIndex = 13;
            this.textBoxIngr.Text = "10Kg Dennis                           40% Nils                                   " +
                "   Mycket Liter Jonas";
            // 
            // Receptsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 694);
            this.Controls.Add(this.textBoxIngr);
            this.Controls.Add(this.textBoxTil);
            this.Controls.Add(this.textBoxNär);
            this.Controls.Add(this.lblIng);
            this.Controls.Add(this.lblTil);
            this.Controls.Add(this.lblNär);
            this.Controls.Add(this.lblRubrik);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Receptsida";
            this.Text = "Timpeton";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRubrik;
        private System.Windows.Forms.Label lblNär;
        private System.Windows.Forms.Label lblTil;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.TextBox textBoxNär;
        private System.Windows.Forms.TextBox textBoxTil;
        private System.Windows.Forms.TextBox textBoxIngr;
        private System.Windows.Forms.ListBox listBoxIngr;
        private System.Windows.Forms.ListBox ListBoxRecept;
        private System.Windows.Forms.Button ButtonNyttRecept;
        private System.Windows.Forms.Button ButtonNewingr;
        private System.Windows.Forms.Button ButtonRemoveRecepie;
        private System.Windows.Forms.Button ButtonRemoveIngr;
    }
}