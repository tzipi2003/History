using DAL.DbModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiHistory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryEventController : ControllerBase
    {
        // GET: api/<HistoryEventController>
        [HttpGet]
        public IEnumerable<HistoryEvent> Get()
        {
            BL.EventsBL eventsBL = new BL.EventsBL();
            return  eventsBL.GetAllData();
         }

        // GET api/<HistoryEventController>/5
        [HttpGet("{id}")]
        public HistoryEvent Get(int id)
        {
           BL.EventsBL   eventBL = new BL.EventsBL();
           return  eventBL.GetAllData().FirstOrDefault(i=>i.EventId==id);
        }

        // POST api/<HistoryEventController>
        [HttpPost]
        public void Post([FromBody] DAL.DbModels.HistoryEvent value)
        {
         new BL.EventsBL().SavenewEvent(value);  
        }

        // PUT api/<HistoryEventController>/5
        [HttpPut]
        public void Put(HistoryEvent history)
        {
            new BL.EventsBL().Update(history);
        }

        // DELETE api/<HistoryEventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
