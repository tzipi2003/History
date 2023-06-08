using DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class EventsBL
    {
        public bool SavenewEvent(DAL.DbModels.HistoryEvent _event)
        {
            try
            {
                EventDal e = new EventDal();
                e.Insert(_event);
                return true;


            }
            catch
            {
                return false;
            }


        }

        public bool Update(DAL.DbModels.HistoryEvent _event)
        {
            try
            {
                EventDal e = new EventDal();
                e.Update(_event);
                return true;


            }
            catch
            {
                return false;
            }

        }
        public List<DAL.DbModels.HistoryEvent> GetAllData()
        {
            var data = new DAL.EventDal().GetAll();

            return data;// EventDAL.GetAllEvents();
        }


    }
}

