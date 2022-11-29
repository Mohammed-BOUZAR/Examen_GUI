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
    public partial class FormAcceuil : Form
    {

        static string chaine = @"Data Source=DESKTOP-3GUL0VT;Initial Catalog=Examen_GUI;User ID=sa;Password=Mohammed123";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        static SqlDataReader srd;
        public FormAcceuil()
        {
            InitializeComponent();
            label1.Visible = false;
            textId.Visible = false;
            btnOk.Visible = false;
            btnAnnuler.Visible = false;
            btnMdfOk.Visible = false;

            btnMdfExam.Enabled = false;
            btnSupExam.Enabled = false;
        }

        private void btnAffExam_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "SELECT * FROM Examen";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
            if (dt.Rows.Count != 0)
            {
                btnMdfExam.Enabled = true;
                btnSupExam.Enabled = true;
            }
        }

        private void btnCreerExam_Click(object sender, EventArgs e)
        {
            int id = 0;
            cnx.Open();
            cmd.CommandText = "SELECT id_examen FROM Examen";
            cmd.Connection = cnx;
            srd = cmd.ExecuteReader();
            while (srd.Read())
                id = int.Parse(srd.GetValue(0).ToString());
            cnx.Close(); 
            FormCreerExam frm = new FormCreerExam(id+1);
            frm.ShowDialog();
        }

        private void btnMdfExam_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textId.Visible = true;
            btnMdfOk.Visible = true;
            btnAnnuler.Visible = true;

            btnCreerExam.Enabled = false;
            btnAffExam.Enabled = false;
            btnSupExam.Enabled = false;
            btnMdfExam.Enabled = false;
        }

        private void btnSupExam_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textId.Visible = true;
            btnOk.Visible = true; 
            btnAnnuler.Visible = true;

            btnCreerExam.Enabled = false;
            btnAffExam.Enabled = false;
            btnMdfExam.Enabled = false;
            btnSupExam.Enabled = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "EXECUTE deleteExamen " + textId.Text + ";";
            cmd.ExecuteNonQuery();
            cnx.Close();

            label1.Visible = false;
            textId.Visible = false;
            btnOk.Visible = false;
            btnAnnuler.Visible = false;

            btnCreerExam.Enabled = true;
            btnAffExam.Enabled = true;
            //btnMdfExam.Enabled = true;
            //btnSupExam.Enabled = true;

            /*cnx.Open();
            cmd.CommandText = "SELECT * FROM Examen";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();*/
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textId.Visible = false;
            btnOk.Visible = false;
            btnMdfOk.Visible = false;
            btnAnnuler.Visible = false;

            btnCreerExam.Enabled = true;
            btnAffExam.Enabled = true;
            btnMdfExam.Enabled = true;
            btnSupExam.Enabled = true;
        }

        private void btnMdfOk_Click(object sender, EventArgs e)
        {
            if(textId.Text != string.Empty)
            {
                FormModifierExam frm = new FormModifierExam(int.Parse(textId.Text));
                frm.ShowDialog();
            }

            label1.Visible = false;
            textId.Visible = false;
            btnMdfOk.Visible = false;
            btnAnnuler.Visible = false;

            btnCreerExam.Enabled = true;
            btnAffExam.Enabled = true;
            btnMdfExam.Enabled = true;
            btnSupExam.Enabled = true;

            cnx.Open();
            cmd.CommandText = "SELECT * FROM Examen";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }
    }
}
