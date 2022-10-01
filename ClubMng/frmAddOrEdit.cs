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
using ClubMng.DAtaLayer;
using System.Data.Entity;

namespace ClubMng
{
    public partial class frmAddOrEdit : Form
    {
        public int currentId=0;
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (currentId != 0)
            {
                this.Text = "ویرایش";
                btn_submit.Text = "ویرایش";
            }
            else
            {
                this.Text = "ثبت عضو جدید";
                btn_submit.Text = "ثبت";
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            if (txt_fullname.Text == "")
            {
                RtlMessageBox.Show("نام را وارد کنید");
            }
            else if (txt_nid.Text == "")
            {
                RtlMessageBox.Show("کد ملی را وارد کنید");
            }
            else if (txt_phone.Text == "")
            {
                RtlMessageBox.Show("موبایل راوارد کنید");
            }
            else if (txt_phone.Text == "")
            {
                RtlMessageBox.Show("آدرس را وارد کنید");
            }
            else
            {
                using(unitOfWork db=new unitOfWork())
                {
                    athlete athlete = new athlete()
                    {
                        fullName = txt_fullname.Text,
                        nID = txt_nid.Text,
                        phoneNumber = txt_phone.Text,
                        adresss = txt_adress.Text
                    };
                    db.athleteRepository.insertAthlete(athlete);
                    db.save();
                   
                    
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
