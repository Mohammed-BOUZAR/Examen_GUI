namespace Examen_GUI
{
    partial class FormQuestion
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
            this.btnAjouterQuestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textReponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textQct = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouterQuestion
            // 
            this.btnAjouterQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterQuestion.Location = new System.Drawing.Point(298, 306);
            this.btnAjouterQuestion.Name = "btnAjouterQuestion";
            this.btnAjouterQuestion.Size = new System.Drawing.Size(187, 53);
            this.btnAjouterQuestion.TabIndex = 50;
            this.btnAjouterQuestion.Text = "Ajouter Une Question";
            this.btnAjouterQuestion.UseVisualStyleBackColor = true;
            this.btnAjouterQuestion.Click += new System.EventHandler(this.btnAjouterQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Reponse :";
            // 
            // textReponse
            // 
            this.textReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReponse.Location = new System.Drawing.Point(157, 157);
            this.textReponse.Multiline = true;
            this.textReponse.Name = "textReponse";
            this.textReponse.Size = new System.Drawing.Size(531, 72);
            this.textReponse.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Question :";
            // 
            // textQct
            // 
            this.textQct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQct.Location = new System.Drawing.Point(157, 49);
            this.textQct.Multiline = true;
            this.textQct.Name = "textQct";
            this.textQct.Size = new System.Drawing.Size(531, 72);
            this.textQct.TabIndex = 46;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(648, 390);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(140, 48);
            this.btnAnnuler.TabIndex = 52;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 390);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(146, 48);
            this.btnEnregistrer.TabIndex = 51;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(47, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "Note :";
            // 
            // textNote
            // 
            this.textNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textNote.Location = new System.Drawing.Point(157, 255);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(67, 23);
            this.textNote.TabIndex = 62;
            // 
            // FormQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAjouterQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textReponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQct);
            this.Name = "FormQuestion";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textReponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textQct;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNote;
    }
}