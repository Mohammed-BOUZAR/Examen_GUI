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
    public partial class FormAjChoix : Form
    {

        static string chaine = @"Data Source=DESKTOP-3GUL0VT;Initial Catalog=Examen_GUI;User ID=sa;Password=Mohammed123";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader srd;

        private int idQcm;
        public FormAjChoix(int idQcm)
        {
            InitializeComponent();
            this.idQcm = idQcm;
            textNote.Enabled = false;
        }

        private void cbxReponse_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxReponse.Checked)
                textNote.Enabled = true;
            else
                textNote.Enabled = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int choix = 0;
            string type = string.Empty;

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT id_proposition FROM Proposition;";
            srd = cmd.ExecuteReader();
            while (srd.Read())
                choix = int.Parse(srd.GetValue(0).ToString());
            choix++;
            cnx.Close();

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT id_proposition FROM Proposition WHERE id_qcm = " + idQcm + ";";
            srd = cmd.ExecuteReader();
            while (srd.Read())
                type = srd.GetValue(0).ToString();
            choix++;
            cnx.Close();


            cnx.Open();
            cmd.Connection = cnx;
            if (type.Equals("Radio"))
            {
                if (cbxReponse.Checked)
                {
                    cmd.CommandText = "INSERT INTO Proposition VALUES (" + choix + ", '" + textChoix.Text
                                        + "', 'Radio', 1, " + textNote.Text + ", " + idQcm + ");";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO Proposition VALUES (" + choix + ", '" + textChoix.Text
                                        + "', 'Radio', 0, 0, " + idQcm + ");";
                }
            }
            else
            {
                if (cbxReponse.Checked)
                {
                    cmd.CommandText = "INSERT INTO Proposition VALUES (" + choix + ", '" + textChoix.Text
                                        + "', 'Check Box', 1, " + textNote.Text + ", " + idQcm + ");";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO Proposition VALUES (" + choix + ", '" + textChoix.Text
                                        + "', 'Check Box', 0, 0, " + idQcm + ");";
                }
            }
            cmd.ExecuteNonQuery();
            cnx.Close();
            Dispose();
        }
    }
}
