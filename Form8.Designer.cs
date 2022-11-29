namespace Examen_GUI
{
    partial class FormModifierQCM
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
            this.cbxBtn = new System.Windows.Forms.CheckBox();
            this.radioBtn = new System.Windows.Forms.RadioButton();
            this.cbxReponse = new System.Windows.Forms.CheckBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjChoix = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChoix = new System.Windows.Forms.Label();
            this.textChoix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textQct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxBtn
            // 
            this.cbxBtn.AutoSize = true;
            this.cbxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cbxBtn.Location = new System.Drawing.Point(431, 230);
            this.cbxBtn.Name = "cbxBtn";
            this.cbxBtn.Size = new System.Drawing.Size(189, 21);
            this.cbxBtn.TabIndex = 88;
            this.cbxBtn.Text = "Plusieurs choix correctent";
            this.cbxBtn.UseVisualStyleBackColor = true;
            this.cbxBtn.CheckedChanged += new System.EventHandler(this.cbxBtn_CheckedChanged);
            // 
            // radioBtn
            // 
            this.radioBtn.AutoSize = true;
            this.radioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioBtn.Location = new System.Drawing.Point(145, 228);
            this.radioBtn.Name = "radioBtn";
            this.radioBtn.Size = new System.Drawing.Size(182, 21);
            this.radioBtn.TabIndex = 87;
            this.radioBtn.TabStop = true;
            this.radioBtn.Text = "Une seule choix correcte";
            this.radioBtn.UseVisualStyleBackColor = true;
            this.radioBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // cbxReponse
            // 
            this.cbxReponse.AutoSize = true;
            this.cbxReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReponse.Location = new System.Drawing.Point(639, 109);
            this.cbxReponse.Name = "cbxReponse";
            this.cbxReponse.Size = new System.Drawing.Size(84, 21);
            this.cbxReponse.TabIndex = 86;
            this.cbxReponse.Text = "Reponse";
            this.cbxReponse.UseVisualStyleBackColor = true;
            this.cbxReponse.CheckedChanged += new System.EventHandler(this.cbxReponse_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(648, 378);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(140, 48);
            this.btnAnnuler.TabIndex = 85;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 378);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(146, 48);
            this.btnEnregistrer.TabIndex = 84;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAjChoix
            // 
            this.btnAjChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAjChoix.Location = new System.Drawing.Point(294, 313);
            this.btnAjChoix.Name = "btnAjChoix";
            this.btnAjChoix.Size = new System.Drawing.Size(178, 51);
            this.btnAjChoix.TabIndex = 82;
            this.btnAjChoix.Text = "Ajouter Un Choix";
            this.btnAjChoix.UseVisualStyleBackColor = true;
            this.btnAjChoix.Click += new System.EventHandler(this.btnAjChoix_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(27, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Note :";
            // 
            // textNote
            // 
            this.textNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textNote.Location = new System.Drawing.Point(145, 188);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(67, 23);
            this.textNote.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(27, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Type :";
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblChoix.Location = new System.Drawing.Point(27, 107);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(62, 17);
            this.lblChoix.TabIndex = 78;
            this.lblChoix.Text = "Choix 1 :";
            // 
            // textChoix
            // 
            this.textChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textChoix.Location = new System.Drawing.Point(145, 107);
            this.textChoix.Multiline = true;
            this.textChoix.Name = "textChoix";
            this.textChoix.Size = new System.Drawing.Size(470, 59);
            this.textChoix.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Question :";
            // 
            // textQct
            // 
            this.textQct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textQct.Location = new System.Drawing.Point(145, 25);
            this.textQct.Multiline = true;
            this.textQct.Name = "textQct";
            this.textQct.Size = new System.Drawing.Size(574, 59);
            this.textQct.TabIndex = 75;
            // 
            // FormModifierQCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxBtn);
            this.Controls.Add(this.radioBtn);
            this.Controls.Add(this.cbxReponse);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAjChoix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.textChoix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQct);
            this.Name = "FormModifierQCM";
            this.Text = "Ajouter QCM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxBtn;
        private System.Windows.Forms.RadioButton radioBtn;
        private System.Windows.Forms.CheckBox cbxReponse;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjChoix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.TextBox textChoix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textQct;
    }
}