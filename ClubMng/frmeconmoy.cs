using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubMng.DAtaLayer.Context;
using ClubMng.Utilities.convertor;

namespace ClubMng
{
    public partial class frmeconmoy : Form
    {
        public void refreshdgv()
        {
            for (int i = 0; i < dgv_econo.RowCount; i++)
            {
                if (int.Parse(dgv_econo.Rows[i].Cells[4].Value.ToString()) > 0)
                {
                    dgv_econo.Rows[i].DefaultCellStyle.BackColor = Color.DarkGreen;
                }
                else
                {
                    dgv_econo.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                }
            }
        }
        public frmeconmoy()
        {
            InitializeComponent();
        }

        private void frmeconmoy_Load(object sender, EventArgs e)
        {
            
            numericUpDown1.Value = 0;
            comboBox1.Text = string.Empty;
            dgv_econo.AutoGenerateColumns = false;
            using (unitOfWork db = new unitOfWork())
            {
                dgv_econo.DataSource = db.athleteRepository.GetAllAthletes();
            }
            List<string> comblist = new List<string>();

            comboBox1.Items.Add("ماهانه");
            comboBox1.Items.Add("هفتگی");
            comboBox1.Items.Add("روزانه");

            refreshdgv();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dgv_econo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_fnam_ec.Text = dgv_econo.CurrentRow.Cells[0].Value.ToString();
            txt_nid_ec.Text = dgv_econo.CurrentRow.Cells[1].Value.ToString();
            txt_status_ec.Text = dgv_econo.CurrentRow.Cells[2].Value.ToString();
            txt_lpay_ec.Text = dgv_econo.CurrentRow.Cells[3].Value.ToString();
            txt_expir_ec.Text = dgv_econo.CurrentRow.Cells[4].Value.ToString();
            txt_total_ec.Text = dgv_econo.CurrentRow.Cells[5].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                numericUpDown1.Value = 30;
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                numericUpDown1.Value = 7;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                numericUpDown1.Value = 1;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_tamdid_Click(object sender, EventArgs e)
        {
            

            using (unitOfWork db=new unitOfWork())
            {
                int id = int.Parse(dgv_econo.CurrentRow.Cells[6].Value.ToString());
                
                var athlete = db.athleteRepository.GetAthleteById(id);
                athlete.total += int.Parse(nUD_pay.Value.ToString());
                if(athlete.expired<0)
                    athlete.expired = 0;
                athlete.expired += int.Parse(numericUpDown1.Value.ToString());
                athlete.tempmydate = DateTime.Now.AddDays(athlete.expired.Value);
                athlete.mydate = DateTime.Now.AddDays(athlete.expired.Value).Toshamsi();
                athlete.lastpay = (DateTime.Now.Toshamsi());
                athlete.status = "مجاز به فعالیت";
                db.athleteRepository.updateAthlete(athlete);
                db.save();
                if (MessageBox.Show("باموفقیت تمدید شد") == DialogResult.OK)
                {

                    dgv_econo.DataSource = db.athleteRepository.GetAllAthletes();
                    refreshdgv();
                }
            }

           // DialogResult = DialogResult.OK;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
