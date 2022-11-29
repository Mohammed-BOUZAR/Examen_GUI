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
    public partial class FormCreerExam : Form
    {

        static string chaine = @"Data Source=DESKTOP-3GUL0VT;Initial Catalog=Examen_GUI;User ID=sa;Password=Mohammed123";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        static SqlDataReader srd;

        public static Stack<string> req;
        public static int id_exam;
        public static int id_qst;
        public static int id_qcm;
        public static int id_proposition;
        public FormCreerExam()
        {
            InitializeComponent();
        }

        public FormCreerExam(int id)
        {
            InitializeComponent();
            id_exam = id;
            req = new Stack<string>();

            cnx.Open();
            cmd.CommandText = "SELECT id_qst FROM Question";
            cmd.Connection = cnx;
            srd = cmd.ExecuteReader();
            while (srd.Read())
                id_qst = int.Parse(srd.GetValue(0).ToString());
            id_qst++;
            cnx.Close();

            cnx.Open();
            cmd.CommandText = "SELECT id_qcm FROM QCM";
            cmd.Connection = cnx;
            srd = cmd.ExecuteReader();
            while (srd.Read())
                id_qcm = int.Parse(srd.GetValue(0).ToString());
            id_qcm++;
            cnx.Close();


            cnx.Open();
            cmd.CommandText = "SELECT id_proposition FROM Proposition";
            cmd.Connection = cnx;
            srd = cmd.ExecuteReader();
            while (srd.Read())
                id_proposition = int.Parse(srd.GetValue(0).ToString());
            id_proposition++;
            cnx.Close();
        }

        private void btnAjtQuest_Click(object sender, EventArgs e)
        {
            
            FormQuestion frm = new FormQuestion();
            frm.ShowDialog();
        }

        private void btnAjtQCM_Click(object sender, EventArgs e)
        {
            FormQCM frm = new FormQCM();
            frm.ShowDialog();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            req.Push("insert into Examen values (" + id_exam + ", '" + textExam.Text 
                + "','" + dateTime.Text 
                + "', " + ((heures.Value*60)+minutes.Value) + ");");

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = string.Empty;
            while (req.Count != 0)
                cmd.CommandText += req.Pop();
            cmd.ExecuteNonQuery();
            cnx.Close();

            textExam.Text = cmd.CommandText;
            req.Clear();
            Dispose();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            req.Clear();
            Dispose();
        }
    }
}
