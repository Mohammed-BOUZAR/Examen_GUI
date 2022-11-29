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
    public partial class FormModifierExam : Form
    {
        static string chaine = @"Data Source=DESKTOP-3GUL0VT;Initial Catalog=Examen_GUI;User ID=sa;Password=Mohammed123";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader srd;
        private int id;
        public FormModifierExam(int id)
        {
            InitializeComponent();
            this.id = id;
            btnSupQcm.Enabled = false;
            btnSupChoix.Enabled = false;
            btnMdfQcm.Enabled = false;
            btnSupQst.Enabled = false;
            btnMdfQst.Enabled = false;
            listChoix.Enabled = false;
            textChoix.Enabled = false;
            textNote1.Enabled = false;
            cbx1.Enabled = false;
            textQcm.Enabled = false;
            textQst.Enabled = false;
            textReponse.Enabled = false;
            textNote.Enabled = false;

            cnx.Open();
            cmd.CommandText = "SELECT intitule, date_examen, duree FROM Examen WHERE id_examen = " + id + ";";
            cmd.Connection = cnx;
            srd = cmd.ExecuteReader();
            while (srd.Read())
            {
                textExam.Text = srd.GetValue(0).ToString();
                dateTime.Text = srd.GetValue(1).ToString();
                int h = int.Parse(srd.GetValue(2).ToString()) / 60;
                int m = int.Parse(srd.GetValue(2).ToString()) % 60;
                heures.Text = h.ToString();
                minutes.Value = m;
            }
            cnx.Close();

            listQst.Items.Clear();
            cnx.Open();
            cmd.CommandText = "SELECT id_qst FROM Question WHERE id_examen = " + id + ";";
            srd = cmd.ExecuteReader();
            listQst.Text = "Choisir la question";
            while (srd.Read())
                listQst.Items.Add(srd.GetValue(0).ToString());
            cnx.Close();

            listQcm.Items.Clear();
            cnx.Open();
            cmd.CommandText = "SELECT id_qcm FROM QCM WHERE id_examen = " + id + ";";
            srd = cmd.ExecuteReader();
            listQcm.Text = "Choisir la question";
            while (srd.Read())
                listQcm.Items.Add(srd.GetValue(0).ToString());
            cnx.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Examen SET intitule = '" + textExam.Text + "', date_examen = '" + dateTime.Text 
                            + "', duree = " + ((heures.Value*60)+minutes.Value) + " WHERE id_examen = " + id + ";";
            cmd.ExecuteNonQuery();
            cnx.Close();

            Dispose();
        }

        private void listQst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQst.Items.Count != 0)
            {
                cnx.Open();
                cmd.CommandText = "SELECT question, reponse, note FROM Question WHERE Question.id_qst = " + listQst.Text + ";";
                srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    textQst.Text = srd.GetValue(0).ToString();
                    textReponse.Text = srd.GetValue(1).ToString();
                    textNote.Text = srd.GetValue(2).ToString();
                }

                cnx.Close();

                textQst.Enabled = true;
                textReponse.Enabled = true;
                textNote.Enabled = true;

                btnSupQst.Enabled = true;
                btnMdfQst.Enabled = true;
            }
        }

        private void listQcm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listQcm.Items.Count != 0)
            {
                cnx.Open();
                cmd.CommandText = "SELECT question, type_select FROM QCM, Proposition "
                            + "WHERE QCM.id_qcm = Proposition.id_qcm "
                            + "and QCM.id_qcm = " + listQcm.Text + ";";
                srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    textQcm.Text = srd.GetValue(0).ToString();
                    if (srd.GetValue(1).ToString().Equals("Radio"))
                        radioBtn.Checked = true;
                    else
                        cbxBtn.Checked = true;
                }
                cnx.Close();

                listChoix.Enabled = true;
                textQcm.Enabled = true;

                btnSupQcm.Enabled = true;
                btnMdfQcm.Enabled = true;


                listChoix.Items.Clear();
                cnx.Open();
                cmd.CommandText = "SELECT id_proposition FROM Proposition, QCM WHERE QCM.id_qcm = Proposition.id_qcm and "
                                + "Proposition.id_qcm = " + listQcm.Text + ";";
                srd = cmd.ExecuteReader();
                listChoix.Text = "Choisir la question";
                while (srd.Read())
                    listChoix.Items.Add(srd.GetValue(0).ToString());
                cnx.Close();

            }
        }

        private void listChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listChoix.Items.Count != 0)
            {
                cnx.Open();
                cmd.CommandText = "SELECT proposition, type_select, reponse, note FROM QCM, Proposition "
                                + "WHERE QCM.id_qcm = Proposition.id_qcm "
                                + "and Proposition.id_qcm = " + listQcm.Text + " and Proposition.id_proposition = "
                                + listChoix.Text + ";";
                srd = cmd.ExecuteReader();
                while (srd.Read())
                {
                    textChoix.Text = srd.GetValue(0).ToString();


                    if (int.Parse(srd.GetValue(2).ToString()) == 1)
                    {
                        cbx1.Checked = true;
                        textNote1.Text = srd.GetValue(3).ToString();
                    }
                    else
                    {
                        cbx1.Checked = false;
                        textNote1.Text = string.Empty;
                    }
                }
                cnx.Close();
                btnSupChoix.Enabled = true;
                textChoix.Enabled = true;
                cbx1.Enabled = true;
            }
        }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn.Checked)
            {
                cbxBtn.Checked = false;
            }
        }

        private void cbxBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBtn.Checked)
            {
                radioBtn.Checked = false;
            }
        }

        private void btnAjtQst_Click(object sender, EventArgs e)
        {
            FormAjQst frm = new FormAjQst(id);
            frm.ShowDialog();

            listQst.Items.Clear();
            cnx.Open();
            cmd.CommandText = "SELECT id_qst FROM Question WHERE id_examen = " + id + ";";
            srd = cmd.ExecuteReader();
            listQst.Text = "Choisir la question";
            while (srd.Read())
                listQst.Items.Add(srd.GetValue(0).ToString());
            cnx.Close();
        }

        private void cbx1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx1.Checked)
                textNote1.Enabled = true;
            else
                textNote1.Enabled = false;
        }

        private void btnMdfQcm_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE QCM SET question = '" + textQcm.Text + "' WHERE QCM.id_qcm = " + listQcm.Text + "; ";
            
            if (cbxBtn.Checked)
            {
                if (textChoix.Text == string.Empty)
                    cmd.CommandText += "UPDATE Proposition SET type_select = 'Check Box' WHERE Proposition.id_qcm = " + listQcm.Text + "; ";
                else
                {
                    if (cbx1.Checked)
                    {
                        cmd.CommandText += "UPDATE Proposition SET proposition = '" + textChoix.Text + "', type_select = 'Check Box',"
                                        + " reponse = 1, note = " + textNote1.Text + " WHERE Proposition.id_qcm = " + listQcm.Text
                                        + " AND Proposition.id_proposition = " + listChoix.Text + ";";
                    }
                    else
                    {
                        cmd.CommandText += "UPDATE Proposition SET proposition = '" + textChoix.Text + "', type_select = 'Check Box',"
                                        + " reponse = 0, note = 0 WHERE Proposition.id_qcm = " + listQcm.Text
                                        + " AND Proposition.id_proposition = " + listChoix.Text + ";";
                    }
                }
            }
            else {
                if (textChoix.Text == string.Empty)
                    cmd.CommandText += "UPDATE Proposition SET type_select = 'Radio' WHERE Proposition.id_qcm = " + listQcm.Text + "; ";
                else
                {
                    if (cbx1.Checked)
                    {
                        cmd.CommandText += "UPDATE Proposition SET proposition = '" + textChoix.Text + "', type_select = 'Radio',"
                                        + " reponse = 1, note = " + textNote1.Text + " WHERE Proposition.id_qcm = " + listQcm.Text
                                        + " AND Proposition.id_proposition = " + listChoix.Text + ";";
                    }
                    else
                    {
                        cmd.CommandText += "UPDATE Proposition SET proposition = '" + textChoix.Text + "', type_select = 'Radio',"
                                        + " reponse = 0, note = 0 WHERE Proposition.id_qcm = " + listQcm.Text
                                        + " AND Proposition.id_proposition = " + listChoix.Text + ";";
                    }
                }
            }

            
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnAjChoixQcm_Click(object sender, EventArgs e)
        {
            FormAjMdfQcm frm = new FormAjMdfQcm(id, int.Parse(listQcm.Text));
            frm.ShowDialog();

            listQcm.Items.Clear();
            cnx.Open();
            cmd.CommandText = "SELECT id_qcm FROM QCM WHERE id_examen = " + id + ";";
            srd = cmd.ExecuteReader();
            listQcm.Text = "Choisir la question";
            while (srd.Read())
                listQcm.Items.Add(srd.GetValue(0).ToString());
            cnx.Close();
        }

        private void btnSupChoix_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM Proposition WHERE id_proposition = " + listChoix.Text + ";";
            cmd.ExecuteNonQuery();
            cnx.Close();

            listChoix.Items.Clear();
            cnx.Open();
            cmd.CommandText = "SELECT id_proposition FROM Proposition, QCM WHERE QCM.id_qcm = Proposition.id_qcm and "
                            + "Proposition.id_qcm = " + listQcm.Text + ";";
            srd = cmd.ExecuteReader();
            listChoix.Text = "Choisir la question";
            while (srd.Read())
                listChoix.Items.Add(srd.GetValue(0).ToString());
            cnx.Close();


            btnSupChoix.Enabled = false;
            textChoix.Enabled = false;
            textNote1.Enabled = false;
            cbx1.Enabled = false;

            textChoix.Text = string.Empty;
            textNote1.Text = string.Empty;
        }

        private void btnSupQcm_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM Proposition WHERE id_qcm = " + listQcm.Text + ";" 
                            + "DELETE FROM QCM WHERE id_qcm = " + listQcm.Text + ";";
            cmd.ExecuteNonQuery();
            cnx.Close();

            listQcm.Items.Clear();
            cnx.Open();
            cmd.CommandText = "SELECT id_qcm FROM QCM WHERE id_examen = " + id + ";";
            srd = cmd.ExecuteReader();
            listQcm.Text = "Choisir la question";
            while (srd.Read())
                listQcm.Items.Add(srd.GetValue(0).ToString());
            cnx.Close();


            btnSupQcm.Enabled = false;
            btnSupChoix.Enabled = false;
            btnMdfQcm.Enabled = false;
            listChoix.Enabled = false;
            textChoix.Enabled = false;
            textNote1.Enabled = false;
            cbx1.Enabled = false;
            textQcm.Enabled = false;

            textQcm.Text = string.Empty;
            textChoix.Text = string.Empty;
            textNote1.Text = string.Empty;
        }

        private void btnMdfQst_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Question SET question = '" + textQst.Text + "', reponse = '" + textReponse.Text 
                            + "', note = " + textNote.Text + " WHERE id_qst = " + listQst.Text + ";";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnSupQst_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM Question WHERE id_qst = " + listQst.Text + ";";
            cmd.ExecuteNonQuery();
            cnx.Close();

            listQst.Items.Clear();
            cnx.Open();
            cmd.CommandText = "SELECT id_qst FROM Question WHERE id_examen = " + id + ";";
            srd = cmd.ExecuteReader();
            listQst.Text = "Choisir la question";
            while (srd.Read())
                listQst.Items.Add(srd.GetValue(0).ToString());
            cnx.Close();

            textQst.Text = string.Empty;
            textReponse.Text = string.Empty;
            textNote.Text = string.Empty;

            textQst.Enabled = false;
            textReponse.Enabled = false;
            textNote.Enabled = false;

            btnSupQst.Enabled = false;
            btnMdfQst.Enabled = false;
        }
    }
}
