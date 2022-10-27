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
using ClubMng.Utilities.convertor;

namespace ClubMng
{
    public partial class frmAddOrEdit : Form
    {
        public int currentId = 0;
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
                using (unitOfWork db = new unitOfWork())
                {
                    var athlete = db.athleteRepository.GetAthleteById(currentId);
                    txt_fullname.Text = athlete.fullName.ToString();
                    txt_nid.Text = athlete.nID.ToString();
                    txt_phone.Text = athlete.phoneNumber.ToString();
                    txt_adress.Text = athlete.phoneNumber.ToString();

                }


            }
            else
            {
                this.Text = "ثبت عضو جدید";
                btn_submit.Text = "ثبت";
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string fnametamzio=String.Concat(txt_fullname.Text.Where(c => Char.IsLetter(c)));
          


            try
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
                else if (txt_nid.Text.Length != 10)
                {
                    RtlMessageBox.Show("کدملی نامعتبر");
                }
                else if (txt_phone.Text.Length > 12)
                {
                    RtlMessageBox.Show("مقدار موبایل وارد شده بیش از حد مجاز");
                }

                else
                {



                    using (unitOfWork db = new unitOfWork())
                    {
                        
                        string trimmedNAME = String.Concat(fnametamzio.Where(c => !Char.IsWhiteSpace(c)));
                        string trimmedPHONE = String.Concat(txt_phone.Text.Where(c => !Char.IsWhiteSpace(c)));
                        string trimmedNID = String.Concat(txt_nid.Text.Where(c => !Char.IsWhiteSpace(c)));
                        athlete athlete = new athlete()
                        {
                            fullName = trimmedNAME,
                            nID = trimmedNID,
                            phoneNumber = trimmedPHONE,
                            adresss = txt_adress.Text,
                            status = "غیر مجاز به فعالیت",
                            total = 0,
                            expired = 0,
                            lastpay = DateTime.Now.Toshamsi(),
                            tempmydate = DateTime.Now,


                        };
                        if (currentId == 0)
                        {
                            db.athleteRepository.insertAthlete(athlete);
                        }
                        else
                        {
                            athlete.athlete_Id = currentId;
                            db.athleteRepository.updateAthlete(athlete);
                        }

                        db.save();
                        DialogResult = DialogResult.OK;

                    }



                }
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("خطایی رخ داده");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
