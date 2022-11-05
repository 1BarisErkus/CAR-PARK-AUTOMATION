using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace frm_login
{
    public partial class frm_raporlama : Form
    {
        public frm_raporlama()
        {
            InitializeComponent();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Veritabani.Raporla(crystalReportViewer1, "tbl_kasa");
        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            Veritabani.Raporla(crystalReportViewer1, "tbl_cars");
        }
    }
}
