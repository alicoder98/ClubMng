using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubMng.DAtaLayer.Repository;
using ClubMng.DAtaLayer.Services;


namespace ClubMng.DAtaLayer.Context
{
    public class unitOfWork : IDisposable
    {
        ClubMng_DbEntiti db = new ClubMng_DbEntiti();
        private IAthleteRepository _AthleteRepository;

        public IAthleteRepository athleteRepository {
            get
            {
                if(_AthleteRepository == null)
                {
                    _AthleteRepository = new AthleteRepository(db);
                }
                return _AthleteRepository;
            }
            }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
