using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubMng.DAtaLayer.Repository;
namespace ClubMng.DAtaLayer.Services
{
    public class AthleteRepository : IAthleteRepository
    {
        private ClubMng_DbEntiti mng_DbEntiti;
        public AthleteRepository(ClubMng_DbEntiti mng_DbEntiti)
        {
            this.mng_DbEntiti = mng_DbEntiti;
        }
        public bool deleteAthlete(int athleteid)
        {
            try
            {
                var athlete = GetAthleteById(athleteid);
                deleteAthletes(athlete);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool deleteAthletes(athlete athlete)
        {
            try
            {
                mng_DbEntiti.Entry(athlete).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }   
        }

        public List<athlete> GetAllAthletes()
        {
            return mng_DbEntiti.athlete.ToList();
        }

        public athlete GetAthleteById(int athleteid)
        {
            return mng_DbEntiti.athlete.Find(athleteid);
        }

        public bool insertAthlete(athlete athlete)
        {
            try{
                mng_DbEntiti.athlete.Add(athlete);
                return true;

            }
            catch
            {
                return false;
            }

        }

        public void save()
        {
            mng_DbEntiti.SaveChanges();
        }

        public bool updateAthlete(athlete athlete)
        {
            try
            {
                mng_DbEntiti.Entry(athlete).State = System.Data.Entity.EntityState.Modified;
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
