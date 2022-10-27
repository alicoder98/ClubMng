using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMng.DAtaLayer.Repository
{
    public interface IAthleteRepository
    {
        List<athlete> GetAllAthletes();
        IEnumerable<athlete> GetAthleteByfilter(string query);
        athlete GetAthleteById(int athleteid);
        bool insertAthlete(athlete athlete);
        bool updateAthlete(athlete athlete);

        bool deleteAthlete(int athleteid);
        bool deleteAthletes(athlete athlete);

    }
}
