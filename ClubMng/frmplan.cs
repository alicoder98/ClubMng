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
using ClubMng.DAtaLayer.Repository;
using ClubMng.DAtaLayer.Services;
using ClubMng.Utilities;

namespace ClubMng
{
    public partial class frmplan : Form
    {
        public frmplan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //listView1.Items.Clear();
            //ListViewItem listviewItem;
            //List<Itemsclass> listtogetFromDB = new List<Itemsclass>();
            //Itemsclass itemtoDB = new Itemsclass();
            //using(unitOfWork db=new unitOfWork())
            //{
            //    int currentid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //    var atlet = db.athleteRepository.GetAthleteById(currentid);
            //    if (atlet.plantext != null) 
            //    {

                    
            //        string plan = atlet.plantext.ToString();
            //        string[] planlist = plan.Split(',');
            //        string[] planlis;
            //        for (int i=0;i<planlist.Length-1;i++)
            //        {
            //            planlis = planlist[i].Split('/');
            //            itemtoDB.Name=planlis[0];
            //            itemtoDB.setscount= Convert.ToInt32(planlis[1]);
            //            itemtoDB.repeatcount = Convert.ToInt32(planlis[2]);
            //            listtogetFromDB.Add(itemtoDB);

            //            listviewItem = new ListViewItem(planlis[0]);
            //            listviewItem.SubItems.Add(planlis[1]);
            //            listviewItem.SubItems.Add(planlis[2]);
            //            listView1.Items.Add(listviewItem);
            //        }
                    
            //    }
            //    else if(atlet.plantext == null || atlet.plantext == "")
            //    {
            //        RtlMessageBox.Show("برنامه ای تعریف نشده", "خطادرنمایش");
            //    }
               
            //}
           
            
  
        }

        private void frmplan_Load(object sender, EventArgs e)
        {
            bind();
            newPlan p = new newPlan();
       
            if (p.DialogResult == DialogResult.OK)
            {
                listView1.Items.Clear();
                bind();
            }
        }
        void bind()
        {
            using (unitOfWork db = new unitOfWork())
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = db.athleteRepository.GetAllAthletes();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name_txt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nid_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            listView1.Items.Clear();
            ListViewItem listviewItem;
            List<Itemsclass> listtogetFromDB = new List<Itemsclass>();
            Itemsclass itemtoDB = new Itemsclass();
            using (unitOfWork db = new unitOfWork())
            {
                int currentid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var atlet = db.athleteRepository.GetAthleteById(currentid);
                if (atlet.plantext != null)
                {


                    string plan = atlet.plantext.ToString();
                    string[] planlist = plan.Split(',');
                    string[] planlis;
                    for (int i = 0; i < planlist.Length - 1; i++)
                    {
                        planlis = planlist[i].Split('/');
                        itemtoDB.Name = planlis[0];
                        itemtoDB.setscount = Convert.ToInt32(planlis[1]);
                        itemtoDB.repeatcount = Convert.ToInt32(planlis[2]);
                        listtogetFromDB.Add(itemtoDB);

                        listviewItem = new ListViewItem(planlis[0]);
                        listviewItem.SubItems.Add(planlis[1]);
                        listviewItem.SubItems.Add(planlis[2]);
                        listView1.Items.Add(listviewItem);
                    }

                }
                else if (atlet.plantext == null || atlet.plantext == ""|| atlet.plantext == " ")
                {
                    RtlMessageBox.Show("برنامه ای تعریف نشده", "خطادرنمایش");
                }

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows != null)
            {
                int currentid = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                newPlan frmnewpln = new newPlan();
                newPlan.checkforRefresh = currentid;
                frmnewpln.ShowDialog();
                
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using(unitOfWork db=new unitOfWork())
            {
                int currentid= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var atlet = db.athleteRepository.GetAthleteById(currentid);
                atlet.plantext =null;
                db.athleteRepository.updateAthlete(atlet);
                db.save();
                listView1.Items.Clear();
                RtlMessageBox.Show($"برنامه {atlet.fullName} با موفقیت حذف شد");
                
            }
        }

        private void nid_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
