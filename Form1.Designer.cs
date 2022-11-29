namespace Examen_GUI
{
    partial class FormAcceuil
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAffExam = new System.Windows.Forms.Button();
            this.btnCreerExam = new System.Windows.Forms.Button();
            this.btnMdfExam = new System.Windows.Forms.Button();
            this.btnSupExam = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnMdfOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAffExam
            // 
            this.btnAffExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAffExam.Location = new System.Drawing.Point(610, 12);
            this.btnAffExam.Name = "btnAffExam";
            this.btnAffExam.Size = new System.Drawing.Size(178, 53);
            this.btnAffExam.TabIndex = 1;
            this.btnAffExam.Text = "Afficher Les Examens";
            this.btnAffExam.UseVisualStyleBackColor = true;
            this.btnAffExam.Click += new System.EventHandler(this.btnAffExam_Click);
            // 
            // btnCreerExam
            // 
            this.btnCreerExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerExam.Location = new System.Drawing.Point(12, 393);
            this.btnCreerExam.Name = "btnCreerExam";
            this.btnCreerExam.Size = new System.Drawing.Size(138, 45);
            this.btnCreerExam.TabIndex = 2;
            this.btnCreerExam.Text = "Creer Un Examen";
            this.btnCreerExam.UseVisualStyleBackColor = true;
            this.btnCreerExam.Click += new System.EventHandler(this.btnCreerExam_Click);
            // 
            // btnMdfExam
            // 
            this.btnMdfExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMdfExam.Location = new System.Drawing.Point(197, 393);
            this.btnMdfExam.Name = "btnMdfExam";
            this.btnMdfExam.Size = new System.Drawing.Size(160, 45);
            this.btnMdfExam.TabIndex = 3;
            this.btnMdfExam.Text = "Modifier Un Examen";
            this.btnMdfExam.UseVisualStyleBackColor = true;
            this.btnMdfExam.Click += new System.EventHandler(this.btnMdfExam_Click);
            // 
            // btnSupExam
            // 
            this.btnSupExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupExam.Location = new System.Drawing.Point(405, 393);
            this.btnSupExam.Name = "btnSupExam";
            this.btnSupExam.Size = new System.Drawing.Size(157, 45);
            this.btnSupExam.TabIndex = 4;
            this.btnSupExam.Text = "Suprimer Un Examen";
            this.btnSupExam.UseVisualStyleBackColor = true;
            this.btnSupExam.Click += new System.EventHandler(this.btnSupExam_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(646, 393);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(142, 45);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(90, 295);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(196, 293);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id Examen :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(277, 293);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnMdfOk
            // 
            this.btnMdfOk.Location = new System.Drawing.Point(196, 293);
            this.btnMdfOk.Name = "btnMdfOk";
            this.btnMdfOk.Size = new System.Drawing.Size(75, 23);
            this.btnMdfOk.TabIndex = 10;
            this.btnMdfOk.Text = "Modifier";
            this.btnMdfOk.UseVisualStyleBackColor = true;
            this.btnMdfOk.Click += new System.EventHandler(this.btnMdfOk_Click);
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMdfOk);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSupExam);
            this.Controls.Add(this.btnMdfExam);
            this.Controls.Add(this.btnCreerExam);
            this.Controls.Add(this.btnAffExam);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAcceuil";
            this.Text = "Acceuil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAffExam;
        private System.Windows.Forms.Button btnCreerExam;
        private System.Windows.Forms.Button btnMdfExam;
        private System.Windows.Forms.Button btnSupExam;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnMdfOk;
    }
}

