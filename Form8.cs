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
    public partial class FormModifierQCM : Form
    {
        static string chaine = @"Data Source=DESKTOP-3GUL0VT;Initial Catalog=Examen_GUI;User ID=sa;Password=Mohammed123";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader srd;

        private int idEx;
        private int idQcm;
        private int nbr;
        public FormModifierQCM(int idEx)
        {
            InitializeComponent();
            this.idEx = idEx;

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT id_qcm FROM QCM WHERE id_examen = " + idEx + ";";
            srd = cmd.ExecuteReader();
            while (srd.Read())
                idQcm = int.Parse(srd.GetValue(0).ToString());
            idQcm++;
            cnx.Close();

            textNote.Enabled = false; 
            nbr = 2;
        }
        
        private void cbxReponse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxReponse.Checked)
                textNote.Enabled = true;
            else
                textNote.Enabled = false;
        }

        private void radioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn.Checked)
                cbxBtn.Checked = false;
        }

        private void cbxBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxBtn.Checked)
                radioBtn.Checked = false;
        }

        private void btnAjChoix_Click(object sender, EventArgs e)
        {
            int idProp = 1;
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT id_proposition FROM Proposition";
            srd = cmd.ExecuteReader();
            while (srd.Read())
                idProp = int.Parse(srd.GetValue(0).ToString());
            idProp++;
            cnx.Close();


            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO QCM VALUES (" + idQcm + ", '" + textQct.Text + "', " + idEx + "); ";

            if (radioBtn.Checked)
            {
                if (cbxReponse.Checked)
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Radio', 1, " + textNote.Text + "," + idQcm + ") ; ";
                else
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Radio', 0, 0," + idQcm + ") ; ";
            }
            else
            {
                if (cbxReponse.Checked)
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + idQcm + ") ; ";
                else
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Check Box', 0, 0," + idQcm + ") ; ";
            }

            cmd.ExecuteNonQuery();
            cnx.Close();

            textChoix.Text = string.Empty;
            textNote.Text = string.Empty;
            cbxReponse.Checked = false;
            lblChoix.Text = "Choix " + nbr + " :";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int idProp = 1;
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT id_proposition FROM Proposition";
            srd = cmd.ExecuteReader();
            while (srd.Read())
                idProp = int.Parse(srd.GetValue(0).ToString());
            idProp++;
            cnx.Close();


            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO QCM VALUES (" + idQcm + ", '" + textQct.Text + "', " + idEx + ");";

            if (radioBtn.Checked)
            {
                if (cbxReponse.Checked)
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Radio', 1, " + textNote.Text + "," + idQcm + ") ; ";
                else
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Radio', 0, 0," + idQcm + ") ; ";
            }
            else
            {
                if (cbxReponse.Checked)
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Check Box', 1, " + textNote.Text + "," + idQcm + ") ; ";
                else
                    cmd.CommandText += "INSERT INTO Proposition VALUES (" + idProp + ", '" + textChoix.Text + "', 'Check Box', 0, 0," + idQcm + ") ; ";
            }

            cmd.ExecuteNonQuery();
            cnx.Close();

            textChoix.Text = string.Empty;
            textNote.Text = string.Empty;
            textQct.Enabled = false;
            textNote.Enabled = false;
            cbxReponse.Checked = false;
            cbxBtn.Enabled = false;
            radioBtn.Enabled = false;
            
            Dispose();
        }
    }
}
