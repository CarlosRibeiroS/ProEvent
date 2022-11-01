using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvents.API.models;

namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        public IEnumerable<Event> _event = new Event[]{
                new Event(){
                    EventId = 1,
                    theme = "Imigration",
                    Local = "Toronto",
                    Lot = " 1° lot",
                    QuantityPeople = 258,
                    EventDate = DateTime.Now.AddDays(2).ToString(),
                    UrlImage = "image.png"
                },
                new Event(){
                    EventId = 2,
                    theme = "Imigration 2",
                    Local = "Toronto",
                    Lot = " 1° lot",
                    QuantityPeople = 258,
                    EventDate = DateTime.Now.AddDays(2).ToString(),
                    UrlImage = "image.png"
                }   
        };

        public EventController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(e => e.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }

}
