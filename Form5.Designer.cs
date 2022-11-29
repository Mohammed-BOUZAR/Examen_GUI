namespace Examen_GUI
{
    partial class FormModifierExam
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.listQcm = new System.Windows.Forms.ComboBox();
            this.listQst = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.TextBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHeures = new System.Windows.Forms.Label();
            this.heures = new System.Windows.Forms.NumericUpDown();
            this.lblDuree = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textExam = new System.Windows.Forms.TextBox();
            this.textQst = new System.Windows.Forms.TextBox();
            this.textReponse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textChoix = new System.Windows.Forms.TextBox();
            this.textQcm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNote = new System.Windows.Forms.TextBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textNote1 = new System.Windows.Forms.TextBox();
            this.cbxBtn = new System.Windows.Forms.CheckBox();
            this.radioBtn = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.listChoix = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAjtQst = new System.Windows.Forms.Button();
            this.btnMdfQcm = new System.Windows.Forms.Button();
            this.btnMdfQst = new System.Windows.Forms.Button();
            this.btnAjChoixQcm = new System.Windows.Forms.Button();
            this.btnSupChoix = new System.Windows.Forms.Button();
            this.btnSupQcm = new System.Windows.Forms.Button();
            this.btnSupQst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heures)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 406);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(146, 48);
            this.btnEnregistrer.TabIndex = 57;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(635, 406);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(140, 48);
            this.btnAnnuler.TabIndex = 58;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // listQcm
            // 
            this.listQcm.FormattingEnabled = true;
            this.listQcm.Location = new System.Drawing.Point(506, 111);
            this.listQcm.Name = "listQcm";
            this.listQcm.Size = new System.Drawing.Size(241, 21);
            this.listQcm.TabIndex = 96;
            this.listQcm.SelectedIndexChanged += new System.EventHandler(this.listQcm_SelectedIndexChanged);
            // 
            // listQst
            // 
            this.listQst.FormattingEnabled = true;
            this.listQst.Location = new System.Drawing.Point(108, 111);
            this.listQst.Name = "listQst";
            this.listQst.Size = new System.Drawing.Size(241, 21);
            this.listQst.TabIndex = 95;
            this.listQst.SelectedIndexChanged += new System.EventHandler(this.listQst_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "yyyy-mm-dd hh:mm:ss";
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(146, 73);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(436, 23);
            this.dateTime.TabIndex = 93;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.Location = new System.Drawing.Point(13, 67);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(88, 17);
            this.lblDateDebut.TabIndex = 92;
            this.lblDateDebut.Text = "Date Debut :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "QCMs :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Questions :";
            // 
            // minutes
            // 
            this.minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.Location = new System.Drawing.Point(659, 18);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(64, 23);
            this.minutes.TabIndex = 89;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.Location = new System.Drawing.Point(729, 21);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(57, 17);
            this.lblMinutes.TabIndex = 88;
            this.lblMinutes.Text = "minutes";
            // 
            // lblHeures
            // 
            this.lblHeures.AutoSize = true;
            this.lblHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeures.Location = new System.Drawing.Point(588, 20);
            this.lblHeures.Name = "lblHeures";
            this.lblHeures.Size = new System.Drawing.Size(54, 17);
            this.lblHeures.TabIndex = 87;
            this.lblHeures.Text = "Heures";
            // 
            // heures
            // 
            this.heures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heures.Location = new System.Drawing.Point(513, 19);
            this.heures.Name = "heures";
            this.heures.Size = new System.Drawing.Size(69, 23);
            this.heures.TabIndex = 86;
            // 
            // lblDuree
            // 
            this.lblDuree.AutoSize = true;
            this.lblDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuree.Location = new System.Drawing.Point(430, 21);
            this.lblDuree.Name = "lblDuree";
            this.lblDuree.Size = new System.Drawing.Size(55, 17);
            this.lblDuree.TabIndex = 85;
            this.lblDuree.Text = "Duree :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(57, 17);
            this.lblTitle.TabIndex = 84;
            this.lblTitle.Text = "Intitule :";
            // 
            // textExam
            // 
            this.textExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textExam.Location = new System.Drawing.Point(76, 20);
            this.textExam.Multiline = true;
            this.textExam.Name = "textExam";
            this.textExam.Size = new System.Drawing.Size(326, 36);
            this.textExam.TabIndex = 83;
            // 
            // textQst
            // 
            this.textQst.Location = new System.Drawing.Point(16, 163);
            this.textQst.Multiline = true;
            this.textQst.Name = "textQst";
            this.textQst.Size = new System.Drawing.Size(370, 50);
            this.textQst.TabIndex = 97;
            // 
            // textReponse
            // 
            this.textReponse.Location = new System.Drawing.Point(16, 268);
            this.textReponse.Multiline = true;
            this.textReponse.Name = "textReponse";
            this.textReponse.Size = new System.Drawing.Size(370, 47);
            this.textReponse.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Question :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Reponse :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Choix :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "QCM :";
            // 
            // textChoix
            // 
            this.textChoix.Location = new System.Drawing.Point(400, 284);
            this.textChoix.Multiline = true;
            this.textChoix.Name = "textChoix";
            this.textChoix.Size = new System.Drawing.Size(370, 47);
            this.textChoix.TabIndex = 104;
            // 
            // textQcm
            // 
            this.textQcm.Location = new System.Drawing.Point(401, 163);
            this.textQcm.Multiline = true;
            this.textQcm.Name = "textQcm";
            this.textQcm.Size = new System.Drawing.Size(370, 50);
            this.textQcm.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Note : ";
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(84, 327);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(68, 20);
            this.textNote.TabIndex = 107;
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(701, 259);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(69, 17);
            this.cbx1.TabIndex = 115;
            this.cbx1.Text = "Reponse";
            this.cbx1.UseVisualStyleBackColor = true;
            this.cbx1.CheckedChanged += new System.EventHandler(this.cbx1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(524, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "Note : ";
            // 
            // textNote1
            // 
            this.textNote1.Location = new System.Drawing.Point(569, 257);
            this.textNote1.Name = "textNote1";
            this.textNote1.Size = new System.Drawing.Size(68, 20);
            this.textNote1.TabIndex = 119;
            // 
            // cbxBtn
            // 
            this.cbxBtn.AutoSize = true;
            this.cbxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbxBtn.Location = new System.Drawing.Point(540, 346);
            this.cbxBtn.Name = "cbxBtn";
            this.cbxBtn.Size = new System.Drawing.Size(96, 17);
            this.cbxBtn.TabIndex = 129;
            this.cbxBtn.Text = "Plusieurs choix";
            this.cbxBtn.UseVisualStyleBackColor = true;
            this.cbxBtn.CheckedChanged += new System.EventHandler(this.cbxBtn_CheckedChanged);
            // 
            // radioBtn
            // 
            this.radioBtn.AutoSize = true;
            this.radioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radioBtn.Location = new System.Drawing.Point(433, 345);
            this.radioBtn.Name = "radioBtn";
            this.radioBtn.Size = new System.Drawing.Size(101, 17);
            this.radioBtn.TabIndex = 128;
            this.radioBtn.TabStop = true;
            this.radioBtn.Text = "Une seule choix";
            this.radioBtn.UseVisualStyleBackColor = true;
            this.radioBtn.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.Location = new System.Drawing.Point(398, 346);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 127;
            this.label16.Text = "Type :";
            // 
            // listChoix
            // 
            this.listChoix.FormattingEnabled = true;
            this.listChoix.Location = new System.Drawing.Point(480, 225);
            this.listChoix.Name = "listChoix";
            this.listChoix.Size = new System.Drawing.Size(241, 21);
            this.listChoix.TabIndex = 131;
            this.listChoix.SelectedIndexChanged += new System.EventHandler(this.listChoix_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(398, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 130;
            this.label9.Text = "Choix :";
            // 
            // btnAjtQst
            // 
            this.btnAjtQst.Location = new System.Drawing.Point(238, 325);
            this.btnAjtQst.Name = "btnAjtQst";
            this.btnAjtQst.Size = new System.Drawing.Size(67, 22);
            this.btnAjtQst.TabIndex = 134;
            this.btnAjtQst.Text = "Ajouter";
            this.btnAjtQst.UseVisualStyleBackColor = true;
            this.btnAjtQst.Click += new System.EventHandler(this.btnAjtQst_Click);
            // 
            // btnMdfQcm
            // 
            this.btnMdfQcm.Location = new System.Drawing.Point(712, 341);
            this.btnMdfQcm.Name = "btnMdfQcm";
            this.btnMdfQcm.Size = new System.Drawing.Size(58, 22);
            this.btnMdfQcm.TabIndex = 137;
            this.btnMdfQcm.Text = "Ok";
            this.btnMdfQcm.UseVisualStyleBackColor = true;
            this.btnMdfQcm.Click += new System.EventHandler(this.btnMdfQcm_Click);
            // 
            // btnMdfQst
            // 
            this.btnMdfQst.Location = new System.Drawing.Point(311, 325);
            this.btnMdfQst.Name = "btnMdfQst";
            this.btnMdfQst.Size = new System.Drawing.Size(75, 22);
            this.btnMdfQst.TabIndex = 138;
            this.btnMdfQst.Text = "Ok";
            this.btnMdfQst.UseVisualStyleBackColor = true;
            this.btnMdfQst.Click += new System.EventHandler(this.btnMdfQst_Click);
            // 
            // btnAjChoixQcm
            // 
            this.btnAjChoixQcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjChoixQcm.Location = new System.Drawing.Point(401, 380);
            this.btnAjChoixQcm.Name = "btnAjChoixQcm";
            this.btnAjChoixQcm.Size = new System.Drawing.Size(86, 28);
            this.btnAjChoixQcm.TabIndex = 139;
            this.btnAjChoixQcm.Text = "Ajouter";
            this.btnAjChoixQcm.UseVisualStyleBackColor = true;
            this.btnAjChoixQcm.Click += new System.EventHandler(this.btnAjChoixQcm_Click);
            // 
            // btnSupChoix
            // 
            this.btnSupChoix.Location = new System.Drawing.Point(642, 341);
            this.btnSupChoix.Name = "btnSupChoix";
            this.btnSupChoix.Size = new System.Drawing.Size(64, 22);
            this.btnSupChoix.TabIndex = 140;
            this.btnSupChoix.Text = "Supprimer";
            this.btnSupChoix.UseVisualStyleBackColor = true;
            this.btnSupChoix.Click += new System.EventHandler(this.btnSupChoix_Click);
            // 
            // btnSupQcm
            // 
            this.btnSupQcm.Location = new System.Drawing.Point(707, 138);
            this.btnSupQcm.Name = "btnSupQcm";
            this.btnSupQcm.Size = new System.Drawing.Size(64, 22);
            this.btnSupQcm.TabIndex = 141;
            this.btnSupQcm.Text = "Supprimer";
            this.btnSupQcm.UseVisualStyleBackColor = true;
            this.btnSupQcm.Click += new System.EventHandler(this.btnSupQcm_Click);
            // 
            // btnSupQst
            // 
            this.btnSupQst.Location = new System.Drawing.Point(322, 138);
            this.btnSupQst.Name = "btnSupQst";
            this.btnSupQst.Size = new System.Drawing.Size(64, 22);
            this.btnSupQst.TabIndex = 142;
            this.btnSupQst.Text = "Supprimer";
            this.btnSupQst.UseVisualStyleBackColor = true;
            this.btnSupQst.Click += new System.EventHandler(this.btnSupQst_Click);
            // 
            // FormModifierExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(804, 459);
            this.Controls.Add(this.btnSupQst);
            this.Controls.Add(this.btnSupQcm);
            this.Controls.Add(this.btnSupChoix);
            this.Controls.Add(this.btnAjChoixQcm);
            this.Controls.Add(this.btnMdfQst);
            this.Controls.Add(this.btnMdfQcm);
            this.Controls.Add(this.btnAjtQst);
            this.Controls.Add(this.listChoix);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxBtn);
            this.Controls.Add(this.radioBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textNote1);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textChoix);
            this.Controls.Add(this.textQcm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textReponse);
            this.Controls.Add(this.textQst);
            this.Controls.Add(this.listQcm);
            this.Controls.Add(this.listQst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHeures);
            this.Controls.Add(this.heures);
            this.Controls.Add(this.lblDuree);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textExam);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "FormModifierExam";
            this.Text = "Modifier Un Examen";
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox listQcm;
        private System.Windows.Forms.ComboBox listQst;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dateTime;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHeures;
        private System.Windows.Forms.NumericUpDown heures;
        private System.Windows.Forms.Label lblDuree;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textExam;
        private System.Windows.Forms.TextBox textQst;
        private System.Windows.Forms.TextBox textReponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textChoix;
        private System.Windows.Forms.TextBox textQcm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textNote1;
        private System.Windows.Forms.CheckBox cbxBtn;
        private System.Windows.Forms.RadioButton radioBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox listChoix;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAjtQst;
        private System.Windows.Forms.Button btnMdfQcm;
        private System.Windows.Forms.Button btnMdfQst;
        private System.Windows.Forms.Button btnAjChoixQcm;
        private System.Windows.Forms.Button btnSupChoix;
        private System.Windows.Forms.Button btnSupQcm;
        private System.Windows.Forms.Button btnSupQst;
    }
}