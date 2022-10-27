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
using ClubMng.Utilities;

namespace ClubMng
{


    public partial class newPlan : Form
    {
        public static int checkforRefresh = 0;
        public List<Itemsclass> itemsclasses = new List<Utilities.Itemsclass>();

        public newPlan()
        {
            InitializeComponent();
        }
        public int checkfR = 0;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            popupGET popupGET = new popupGET();
            popupGET.ShowDialog();

        }

        private void newPlan_Load(object sender, EventArgs e)
        {
            nudrepet.Value = 0;
            nudsets.Value = 0;
            using (unitOfWork db = new unitOfWork())
            {
                var atl = db.athleteRepository.GetAthleteById(checkforRefresh);
                this.Text = atl.fullName.ToString();
            }

            bindgrid();

        }
        void bindgrid()
        {
            using (unitOfWork db = new unitOfWork())
            {
                List<store_listitem> store_Listitems = new List<store_listitem>();
                store_Listitems = db.Listdo.GetAllitems();
                comboBox1.Items.Clear();
                foreach (store_listitem item in store_Listitems)
                {
                    comboBox1.Items.Add(item.name.ToString());
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            bindgrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Itemsclass ic = new Itemsclass();
            if (comboBox1.Text == "")
            {
                RtlMessageBox.Show("نوع حرکت انتخاب کنید");
            }
            else if (nudsets.Value == 0)
            {
                RtlMessageBox.Show("تعداد ست را وارد کنید");
            }
            else if (nudrepet.Value == 0)
            {
                RtlMessageBox.Show("تعداد تکرار حرکت وارد نشده");
            }
            else
            {
                ic.Name = comboBox1.Text;
                ic.repeatcount = int.Parse(nudrepet.Value.ToString());
                ic.setscount = int.Parse(nudsets.Value.ToString());
                itemsclasses.Add(ic);
                ListViewItem list = new ListViewItem(ic.Name);
                list.SubItems.Add(ic.repeatcount.ToString());
                list.SubItems.Add(ic.setscount.ToString());
                listView1.Items.Add(list);
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RtlMessageBox.Show("ایا قصد ثبت برنامه برای کاربر انتخابی ندارید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
                //listView1.Items.RemoveAt(0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (unitOfWork db = new unitOfWork())
            {
                var atlete = db.athleteRepository.GetAthleteById(checkforRefresh);
                string plan = "";
                foreach (Itemsclass item in itemsclasses)
                {
                    plan = plan + item.Name;
                    plan = plan + "/" + item.repeatcount.ToString();
                    plan = plan + "/" + item.setscount.ToString();
                    plan = plan + ",";


                    if (atlete != null)
                    {
                        atlete.plantext = plan;
                        db.athleteRepository.updateAthlete(atlete);
                        db.save();

                    }
                    DialogResult = DialogResult.OK;

                }
                RtlMessageBox.Show($" برنامه ورزشی {atlete.fullName}با موفقیت ثبت شد");
            }
            
        }
    }
}
