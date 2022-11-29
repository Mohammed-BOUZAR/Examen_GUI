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
    public partial class FormAjQst : Form
    {
        static string chaine = @"Data Source=DESKTOP-3GUL0VT;Initial Catalog=Examen_GUI;User ID=sa;Password=Mohammed123";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataReader srd;
        private int id;
        public FormAjQst(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int qst = 0;
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT id_qst FROM Question";
            srd = cmd.ExecuteReader();
            while (srd.Read())
                qst = int.Parse(srd.GetValue(0).ToString());
            qst++;
            cnx.Close();

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO Question VALUES (" + qst + ", '" + textQct.Text + "', '" + textReponse.Text 
                            + "', " + textNote.Text + ", " + id + ");";
            cmd.ExecuteNonQuery();
            cnx.Close();
            Dispose();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
