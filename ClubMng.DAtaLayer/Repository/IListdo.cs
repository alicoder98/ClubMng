using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMng.DAtaLayer.Repository
{
    public interface IListdo
    {

        //IEnumerable<athlete> GetAthleteByfilter(string query);
        bool insertItemToList(store_listitem name);
        bool deleteItemFromList(string name);
        List<store_listitem> GetAllitems();
    }
}
