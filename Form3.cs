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
    public partial class FormQuestion : Form
    {
        private string req;
        public FormQuestion()
        {
            InitializeComponent();
            req = String.Empty;
    }

        private void btnAjouterQuestion_Click(object sender, EventArgs e)
        {
            req = "insert into Question values (" + FormCreerExam.id_qst + ",'" + textQct.Text + "', '" 
                + textReponse.Text + "', " + textNote.Text + ", "+ FormCreerExam.id_exam + ");";
            FormCreerExam.req.Push(req);

            textQct.Text = String.Empty;
            textReponse.Text = String.Empty;
            textNote.Text = String.Empty;

            FormCreerExam.id_qst++;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            req = "insert into Question values (" + FormCreerExam.id_qst + ",'" + textQct.Text + "', '"
                + textReponse.Text + "', " + textNote.Text + ", " + FormCreerExam.id_exam + ");";
            FormCreerExam.req.Push(req);
            FormCreerExam.id_qst++;

            textQct.Text = String.Empty;
            textReponse.Text = String.Empty;
            textNote.Text = String.Empty;

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
