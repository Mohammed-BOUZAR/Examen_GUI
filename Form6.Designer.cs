namespace Examen_GUI
{
    partial class FormAjMdfQcm
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
            this.btnAjChoix = new System.Windows.Forms.Button();
            this.btnAjQcm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjChoix
            // 
            this.btnAjChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjChoix.Location = new System.Drawing.Point(262, 38);
            this.btnAjChoix.Name = "btnAjChoix";
            this.btnAjChoix.Size = new System.Drawing.Size(140, 48);
            this.btnAjChoix.TabIndex = 62;
            this.btnAjChoix.Text = "Choix";
            this.btnAjChoix.UseVisualStyleBackColor = true;
            this.btnAjChoix.Click += new System.EventHandler(this.btnAjChoix_Click);
            // 
            // btnAjQcm
            // 
            this.btnAjQcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjQcm.Location = new System.Drawing.Point(41, 38);
            this.btnAjQcm.Name = "btnAjQcm";
            this.btnAjQcm.Size = new System.Drawing.Size(146, 48);
            this.btnAjQcm.TabIndex = 61;
            this.btnAjQcm.Text = "QCM";
            this.btnAjQcm.UseVisualStyleBackColor = true;
            this.btnAjQcm.Click += new System.EventHandler(this.btnAjQcm_Click);
            // 
            // FormAjMdfQcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 124);
            this.Controls.Add(this.btnAjChoix);
            this.Controls.Add(this.btnAjQcm);
            this.Name = "FormAjMdfQcm";
            this.Text = "Ajouter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjChoix;
        private System.Windows.Forms.Button btnAjQcm;
    }
}