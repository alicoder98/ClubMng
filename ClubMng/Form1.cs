using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ClubMng.Utilities.convertor;
using ClubMng.DAtaLayer.Context;
using ClubMng.DAtaLayer.Repository;
using ClubMng.DAtaLayer;


namespace ClubMng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = 300;

           // for (int i = 0; i <= 300; i++)
            //{
                //Thread.Sleep(20);
              //  progressBar1.Value = i;
                //label2.Text= (i-3).ToString();

            //}

            //string nowdate = DateTime.Now.Toshamsi();

            //List<int> nowdatelist = new List<int>();
            // nowdatelist= nowdate.convertToStandard();
            label1.Text = DateTime.Now.Toshamsi() + " امروز  ";
           

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmManageMembers frmManageMembers = new frmManageMembers();
            frmManageMembers.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
           if( RtlMessageBox.Show("آیا میخواهید خارج شوید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void tsb__Click(object sender, EventArgs e)
        {
            frmeconmoy frmeconmoy = new frmeconmoy();
            frmeconmoy.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmplan frmplan = new frmplan();
            frmplan.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            using (unitOfWork db = new unitOfWork())
            {
                List<athlete> athlets = db.athleteRepository.GetAllAthletes();
                for (int i = 0; i < athlets.Count; i++)
                {
                    DateTime now = new DateTime();
                    now = DateTime.Now;
                    if (athlets[i].tempmydate != null)
                    {
                        var difertime = athlets[i].tempmydate - now;
                        int days = difertime.Value.Days;
                        athlets[i].expired = days;
                        if (athlets[i].expired > 0)
                        {
                            athlets[i].status = "مجاز به فعالیت";
                        }
                        else
                        {
                            athlets[i].status = "غیر مجاز به فعالیت";
                        }

                    }


                    // List<int> lastdateset = new List<int>();
                    // lastdateset= athlets[i].mydate.convertToStandard();
                    //athlets[i].expired = MyUtiliti.difrenc(nowdatelist, lastdateset);


                    //athlets[i].expired =(lastdateset, nowdatelist); ;
                    db.athleteRepository.updateAthlete(athlets[i]);
                }
                db.save();
            }
           progressBar1.Minimum = 0;
           progressBar1.Maximum = 300;
            
           for (int i = 0; i <= 300; i++)
            {
                Thread.Sleep(5);
                progressBar1.Value = i;
               // label2.Text= (i).ToString();
                
            }



            // progressBar1.Hide();

            if(MessageBox.Show("خوش آمدید") == DialogResult.OK)
            {
                progressBar1.Hide();
            }
            
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }
    }
}
