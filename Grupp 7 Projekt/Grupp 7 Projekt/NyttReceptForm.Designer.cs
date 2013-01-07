namespace Grupp_7_Projekt
{
    partial class NyttReceptForm
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
            this.buttonFinish = new System.Windows.Forms.Button();
            this.TextBoxTitel = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.TextboxIngr = new System.Windows.Forms.TextBox();
            this.textBoxTaggs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxIngr = new System.Windows.Forms.ListBox();
            this.listBoxTaggs = new System.Windows.Forms.ListBox();
            this.Addingr = new System.Windows.Forms.Button();
            this.RemoveIngr = new System.Windows.Forms.Button();
            this.AddTag = new System.Windows.Forms.Button();
            this.RemoveTag = new System.Windows.Forms.Button();
            this.textBoxMängd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxPortioner = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(278, 406);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(164, 23);
            this.buttonFinish.TabIndex = 0;
            this.buttonFinish.Text = "Skapa";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // TextBoxTitel
            // 
            this.TextBoxTitel.Location = new System.Drawing.Point(12, 23);
            this.TextBoxTitel.Name = "TextBoxTitel";
            this.TextBoxTitel.Size = new System.Drawing.Size(221, 20);
            this.TextBoxTitel.TabIndex = 1;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 73);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(372, 327);
            this.TextBoxDescription.TabIndex = 2;
            // 
            // TextboxIngr
            // 
            this.TextboxIngr.Location = new System.Drawing.Point(390, 23);
            this.TextboxIngr.Name = "TextboxIngr";
            this.TextboxIngr.Size = new System.Drawing.Size(120, 20);
            this.TextboxIngr.TabIndex = 3;
            // 
            // textBoxTaggs
            // 
            this.textBoxTaggs.Location = new System.Drawing.Point(390, 231);
            this.textBoxTaggs.Name = "textBoxTaggs";
            this.textBoxTaggs.Size = new System.Drawing.Size(120, 20);
            this.textBoxTaggs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tillagning:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingredienser:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taggar:";
            // 
            // listBoxIngr
            // 
            this.listBoxIngr.FormattingEnabled = true;
            this.listBoxIngr.Location = new System.Drawing.Point(390, 73);
            this.listBoxIngr.Name = "listBoxIngr";
            this.listBoxIngr.Size = new System.Drawing.Size(120, 95);
            this.listBoxIngr.TabIndex = 9;
            // 
            // listBoxTaggs
            // 
            this.listBoxTaggs.FormattingEnabled = true;
            this.listBoxTaggs.Location = new System.Drawing.Point(390, 257);
            this.listBoxTaggs.Name = "listBoxTaggs";
            this.listBoxTaggs.Size = new System.Drawing.Size(120, 95);
            this.listBoxTaggs.TabIndex = 10;
            // 
            // Addingr
            // 
            this.Addingr.Location = new System.Drawing.Point(541, 47);
            this.Addingr.Name = "Addingr";
            this.Addingr.Size = new System.Drawing.Size(75, 23);
            this.Addingr.TabIndex = 11;
            this.Addingr.Text = "Lägg till";
            this.Addingr.UseVisualStyleBackColor = true;
            this.Addingr.Click += new System.EventHandler(this.Addingr_Click);
            // 
            // RemoveIngr
            // 
            this.RemoveIngr.Location = new System.Drawing.Point(516, 145);
            this.RemoveIngr.Name = "RemoveIngr";
            this.RemoveIngr.Size = new System.Drawing.Size(75, 23);
            this.RemoveIngr.TabIndex = 12;
            this.RemoveIngr.Text = "Tabort";
            this.RemoveIngr.UseVisualStyleBackColor = true;
            this.RemoveIngr.Click += new System.EventHandler(this.RemoveIngr_Click);
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(516, 231);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(75, 23);
            this.AddTag.TabIndex = 13;
            this.AddTag.Text = "Lägg till";
            this.AddTag.UseVisualStyleBackColor = true;
            this.AddTag.Click += new System.EventHandler(this.AddTag_Click);
            // 
            // RemoveTag
            // 
            this.RemoveTag.Location = new System.Drawing.Point(516, 329);
            this.RemoveTag.Name = "RemoveTag";
            this.RemoveTag.Size = new System.Drawing.Size(75, 23);
            this.RemoveTag.TabIndex = 14;
            this.RemoveTag.Text = "Tabort";
            this.RemoveTag.UseVisualStyleBackColor = true;
            this.RemoveTag.Click += new System.EventHandler(this.RemoveTag_Click);
            // 
            // textBoxMängd
            // 
            this.textBoxMängd.Location = new System.Drawing.Point(516, 22);
            this.textBoxMängd.Name = "textBoxMängd";
            this.textBoxMängd.Size = new System.Drawing.Size(100, 20);
            this.textBoxMängd.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mängd:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Detta recept är för:";
            // 
            // TextBoxPortioner
            // 
            this.TextBoxPortioner.Location = new System.Drawing.Point(121, 103);
            this.TextBoxPortioner.Name = "TextBoxPortioner";
            this.TextBoxPortioner.Size = new System.Drawing.Size(94, 20);
            this.TextBoxPortioner.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "portioner\r\n";
            // 
            // NyttReceptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 441);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxPortioner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMängd);
            this.Controls.Add(this.RemoveTag);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.RemoveIngr);
            this.Controls.Add(this.Addingr);
            this.Controls.Add(this.listBoxTaggs);
            this.Controls.Add(this.listBoxIngr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTaggs);
            this.Controls.Add(this.TextboxIngr);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.TextBoxTitel);
            this.Controls.Add(this.buttonFinish);
            this.Name = "NyttReceptForm";
            this.Text = "NyttReceptForm";
            this.Load += new System.EventHandler(this.NyttReceptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox TextBoxTitel;
        private System.Windows.Forms.TextBox TextBoxDescription;
        private System.Windows.Forms.TextBox TextboxIngr;
        private System.Windows.Forms.TextBox textBoxTaggs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxIngr;
        private System.Windows.Forms.ListBox listBoxTaggs;
        private System.Windows.Forms.Button Addingr;
        private System.Windows.Forms.Button RemoveIngr;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.Button RemoveTag;
        private System.Windows.Forms.TextBox textBoxMängd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxPortioner;
        private System.Windows.Forms.Label label7;
    }
}