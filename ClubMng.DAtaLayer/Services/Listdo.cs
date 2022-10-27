using ClubMng.DAtaLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMng.DAtaLayer.Services
{
    public class Listdo : IListdo
    {
        private ClubMng_DbEntiti mng_DbEntiti;
        public Listdo(ClubMng_DbEntiti mng_DbEntiti)
        {
            this.mng_DbEntiti = mng_DbEntiti;
        }
        public bool deleteItemFromList(string name)
        {
            try
            {
                mng_DbEntiti.Entry(name).State= System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {


                return false;
            }
        }

        public List<store_listitem> GetAllitems()
        {

                return mng_DbEntiti.store_listitem.ToList();
            
        }

        public bool insertItemToList(store_listitem store_)
        {
            try
            {
                mng_DbEntiti.store_listitem.Add(store_);
                return true;
            }
            catch (Exception)
            {

                
                return false;
            }
            
        }
    }
}
