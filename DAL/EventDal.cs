using DAL.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EventDal
    {

        public bool Insert (DbModels.HistoryEvent _event){
            try
            {
                using (DbModels.HistoryZfContext ctx = new())
                {
                    ctx.Events.Add(_event);
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;

            }
        }

        public List<DAL.DbModels.HistoryEvent> GetAll()
        {
            try
            {
                using  DbModels.HistoryZfContext ctx = new()  ;
               return ctx.Events.ToList();
                
            }
            catch (Exception)
            {
                return null ;

            }
        }

        public bool Update(HistoryEvent @event)
        {
            try
            {
                using (DbModels.HistoryZfContext ctx = new())
                {
                    ctx.Events.Attach(@event);
                        ctx.Entry(@event).State = EntityState.Modified;
                    ctx.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
