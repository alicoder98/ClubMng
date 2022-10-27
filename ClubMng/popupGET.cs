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
using ClubMng.DAtaLayer;

namespace ClubMng
{
    public partial class popupGET : Form
    {
        public popupGET()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (unitOfWork db = new unitOfWork())
            {

                if (!(txt_inputItem.Text.Equals("")))
                {
                    store_listitem st=new store_listitem();
                    st.name=txt_inputItem.Text;
                    db.Listdo.insertItemToList(st);
                    db.save();
                    newPlan.checkforRefresh = 1;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("لطفا نام حرکت را وارد کنید!");
                }
                 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txt_inputItem_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
