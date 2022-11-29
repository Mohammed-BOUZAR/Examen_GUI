namespace Examen_GUI
{
    partial class FormCreerExam
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
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHeures = new System.Windows.Forms.Label();
            this.heures = new System.Windows.Forms.NumericUpDown();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textExam = new System.Windows.Forms.TextBox();
            this.btnAjtQuest = new System.Windows.Forms.Button();
            this.btnAjtQCM = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heures)).BeginInit();
            this.SuspendLayout();
            // 
            // minutes
            // 
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(349, 248);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(64, 23);
            this.minutes.TabIndex = 32;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(423, 250);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(57, 17);
            this.lblMinutes.TabIndex = 31;
            this.lblMinutes.Text = "minutes";
            // 
            // lblHeures
            // 
            this.lblHeures.AutoSize = true;
            this.lblHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeures.Location = new System.Drawing.Point(250, 250);
            this.lblHeures.Name = "lblHeures";
            this.lblHeures.Size = new System.Drawing.Size(54, 17);
            this.lblHeures.TabIndex = 30;
            this.lblHeures.Text = "Heures";
            // 
            // heures
            // 
            this.heures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heures.Location = new System.Drawing.Point(167, 248);
            this.heures.Name = "heures";
            this.heures.Size = new System.Drawing.Size(69, 23);
            this.heures.TabIndex = 29;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(648, 390);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(140, 48);
            this.btnAnnuler.TabIndex = 27;
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
            this.btnEnregistrer.TabIndex = 26;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.Location = new System.Drawing.Point(34, 248);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(55, 17);
            this.lblDuree.TabIndex = 25;
            this.lblDuree.Text = "Duree :";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(34, 194);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(88, 17);
            this.lblDateDebut.TabIndex = 24;
            this.lblDateDebut.Text = "Date Debut :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(34, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 17);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Intitule :";
            // 
            // textExam
            // 
            this.textExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExam.Location = new System.Drawing.Point(167, 47);
            this.textExam.Multiline = true;
            this.textExam.Name = "textExam";
            this.textExam.Size = new System.Drawing.Size(391, 113);
            this.textExam.TabIndex = 22;
            // 
            // btnAjtQuest
            // 
            this.btnAjtQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjtQuest.Location = new System.Drawing.Point(624, 61);
            this.btnAjtQuest.Name = "btnAjtQuest";
            this.btnAjtQuest.Size = new System.Drawing.Size(164, 60);
            this.btnAjtQuest.TabIndex = 41;
            this.btnAjtQuest.Text = "Ajouter Une Question";
            this.btnAjtQuest.UseVisualStyleBackColor = true;
            this.btnAjtQuest.Click += new System.EventHandler(this.btnAjtQuest_Click);
            // 
            // btnAjtQCM
            // 
            this.btnAjtQCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjtQCM.Location = new System.Drawing.Point(624, 163);
            this.btnAjtQCM.Name = "btnAjtQCM";
            this.btnAjtQCM.Size = new System.Drawing.Size(164, 60);
            this.btnAjtQCM.TabIndex = 42;
            this.btnAjtQCM.Text = "Ajouter Une QCM";
            this.btnAjtQCM.UseVisualStyleBackColor = true;
            this.btnAjtQCM.Click += new System.EventHandler(this.btnAjtQCM_Click);
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(167, 200);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(391, 23);
            this.dateTime.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "yyyy-mm-dd hh:mm:ss";
            // 
            // FormCreerExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.btnAjtQCM);
            this.Controls.Add(this.btnAjtQuest);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHeures);
            this.Controls.Add(this.heures);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textExam);
            this.Name = "FormCreerExam";
            this.Text = "Creer Un Examen";
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHeures;
        private System.Windows.Forms.NumericUpDown heures;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textExam;
        private System.Windows.Forms.Button btnAjtQuest;
        private System.Windows.Forms.Button btnAjtQCM;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.Label label6;
    }
}