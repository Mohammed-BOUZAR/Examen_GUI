namespace Examen_GUI
{
    partial class FormAjChoix
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
            this.cbxReponse = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNote = new System.Windows.Forms.TextBox();
            this.lblChoix = new System.Windows.Forms.Label();
            this.textChoix = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxReponse
            // 
            this.cbxReponse.AutoSize = true;
            this.cbxReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReponse.Location = new System.Drawing.Point(640, 49);
            this.cbxReponse.Name = "cbxReponse";
            this.cbxReponse.Size = new System.Drawing.Size(84, 21);
            this.cbxReponse.TabIndex = 91;
            this.cbxReponse.Text = "Reponse";
            this.cbxReponse.UseVisualStyleBackColor = true;
            this.cbxReponse.CheckedChanged += new System.EventHandler(this.cbxReponse_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Note :";
            // 
            // textNote
            // 
            this.textNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textNote.Location = new System.Drawing.Point(146, 128);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(67, 23);
            this.textNote.TabIndex = 89;
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblChoix.Location = new System.Drawing.Point(28, 47);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(50, 17);
            this.lblChoix.TabIndex = 88;
            this.lblChoix.Text = "Choix :";
            // 
            // textChoix
            // 
            this.textChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textChoix.Location = new System.Drawing.Point(146, 47);
            this.textChoix.Multiline = true;
            this.textChoix.Name = "textChoix";
            this.textChoix.Size = new System.Drawing.Size(470, 59);
            this.textChoix.TabIndex = 87;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(604, 180);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(146, 48);
            this.btnEnregistrer.TabIndex = 92;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FormAjChoix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 240);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cbxReponse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.textChoix);
            this.Name = "FormAjChoix";
            this.Text = "Ajouter Choix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxReponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Label lblChoix;
        private System.Windows.Forms.TextBox textChoix;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}