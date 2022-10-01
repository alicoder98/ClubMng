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

        private void tst_search_TextChanged(object sender, EventArgs e)
        {
            using(unitOfWork db = new unitOfWork())
            {
                dgvmemb.DataSource = db.athleteRepository.GetCustomerByfilter(tst_search.Text).ToList();
                
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvmemb.CurrentRow != null)
            {
                
                using(unitOfWork db = new unitOfWork())
                {
                    string name = dgvmemb.CurrentRow.Cells[2].Value.ToString();
                    var k=RtlMessageBox.Show( $"حذف شود؟{name}", "حذف ورزشکار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (DialogResult.Yes == k)
                    {
                        int atheletID = int.Parse(dgvmemb.CurrentRow.Cells[0].Value.ToString());
                        db.athleteRepository.deleteAthlete(atheletID);
                        db.save();
                        bindgrid();
                    }

                }

            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(dgvmemb.CurrentRow != null)
            {
                int atheletID = int.Parse(dgvmemb.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEdit frmAddOrEdit = new frmAddOrEdit();
                frmAddOrEdit.currentId = atheletID;
                frmAddOrEdit.ShowDialog();
                
            }
        }
    }
}
