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
    public partial class FormAjMdfQcm : Form
    {

        private int id_ex;
        private int id_qcm;
        public FormAjMdfQcm(int id_ex, int id_qcm)
        {
            InitializeComponent();
            this.id_ex = id_ex;
            this.id_qcm = id_qcm;
            if (id_qcm <= 1)
                btnAjChoix.Enabled = false;
        }

        public FormAjMdfQcm(int id_ex)
        {
            InitializeComponent();
            this.id_ex = id_ex;
            btnAjChoix.Enabled = false;
        }

        private void btnAjQcm_Click(object sender, EventArgs e)
        {
            FormModifierQCM frm = new FormModifierQCM(id_ex);
            frm.ShowDialog();
            Dispose();
        }

        private void btnAjChoix_Click(object sender, EventArgs e)
        {
            FormAjChoix frm = new FormAjChoix(id_qcm);
            frm.ShowDialog();
            Dispose();
        }
    }
}
