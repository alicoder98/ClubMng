using ClubMng.DAtaLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClubMng
{
    public partial class frmManageMembers : Form
    {
        public frmManageMembers()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
            frmAddOrEdit.ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            tst_search.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmManageMembers_Load(object sender, EventArgs e)
        {
            bindgrid();
        }
        void bindgrid()
        {
            dgvmemb.AutoGenerateColumns = false;
            using (unitOfWork db = new unitOfWork())
            {
                dgvmemb.DataSource = db.athleteRepository.GetAllAthletes();
            }
        }
    }
}
