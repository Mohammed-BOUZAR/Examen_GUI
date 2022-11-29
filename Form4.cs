using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_GUI
{
    public partial class FormQCM : Form
    {
        private string req;
        private int nbrChoix;
        public FormQCM()
        {
            InitializeComponent();
            req = String.Empty;
            nbrChoix = 2;
            textNote.Enabled = false;
        }

        private void btnAjChoix_Click(object sender, EventArgs e)
        {
            if (cbxBtn.Checked)
            {
                if (cbxReponse.Checked)
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
                else
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 0, 0," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
            }
            else
            {
                if (cbxReponse.Checked)
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
                else
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 0, 0," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
            }

            
            
            

            lblChoix.Text = "Choix " + nbrChoix + " :";
            nbrChoix++;

            textChoix.Text = String.Empty;
            textNote.Text = String.Empty;
            textNote.Enabled = false;
            cbxBtn.Enabled = false;
            radioBtn.Enabled = false;
            textQct.Enabled = false;
            cbxReponse.Checked = false;
        }

        private void btnAjQst_Click(object sender, EventArgs e)
        {
            if (cbxBtn.Checked)
            {
                if (cbxReponse.Checked)
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
                else
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 0, 0," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
            }
            else
            {
                if (cbxReponse.Checked)
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
                else
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 0, 0," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
            }


            req = "insert into QCM values (" + FormCreerExam.id_qcm + ",'" + textQct.Text + "', " 
                + FormCreerExam.id_exam + ");";
            FormCreerExam.req.Push(req);
            FormCreerExam.id_qcm++;

            cbxBtn.Enabled = true;
            radioBtn.Enabled = true;
            textQct.Enabled = true;

            textQct.Text = String.Empty;
            textChoix.Text = String.Empty;
            textNote.Text = String.Empty;

            cbxReponse.Checked = false;
            cbxBtn.Checked = false;
            radioBtn.Checked = false;
        }

        private void cbxReponse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxReponse.Checked)
                textNote.Enabled = true;
            else
                textNote.Enabled = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (cbxBtn.Checked)
            {
                if (cbxReponse.Checked)
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
                else
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 0, 0, " + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
            }
            else
            {
                if (cbxReponse.Checked)
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
                else
                {
                    req = "insert into Proposition values (" + FormCreerExam.id_proposition + ", '"
                        + textChoix.Text + "', 'Check Box', 0, 0, " + FormCreerExam.id_qcm + ");";
                    FormCreerExam.id_proposition++;
                    FormCreerExam.req.Push(req);
                }
            }


            req = "insert into QCM values (" + FormCreerExam.id_qcm + ",'" + textQct.Text + "', "
                + FormCreerExam.id_exam + ");";
            FormCreerExam.req.Push(req);

            req = String.Empty;
            Dispose();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            req = String.Empty;
            Dispose();
        }
    }
}
