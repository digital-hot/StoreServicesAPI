using Microsoft.AspNetCore.Mvc;

namespace StoreServicesAPI.Store.Controllers
{
    using StoreServicesAPI.Store.Data;
    using StoreServicesAPI.Store.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        private readonly StoreData LocalStoreData;

        public ClientsController(StoreData storeData)
        {
            LocalStoreData = storeData;
        }

        [HttpGet("birthdays")]
        public ActionResult<IEnumerable<Client>> GetBirthdayClients([FromQuery] DateTime date)
        {
            var clients = LocalStoreData.Clients
                .Where(c => c.BirthData.Month == date.Month && c.BirthData.Day == date.Day)
                .Select(c => new { c.Id, c.FullName})
                .ToList();

            return Ok(clients);
        }

        // GET: api/clients
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var clients = LocalStoreData.Clients
                .Select(c => new { c.Id, c.FullName, c.BirthData, c.CreationData })
                .ToList();

            return Ok(clients);
        }

        // GET: api/clients/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var clients = LocalStoreData.Clients
                .Where(c => c.Id == id)
                .Select(c => new { c.Id, c.FullName})
                .ToList();

            return Ok(clients);
        }
        // POST: api/clients
        [HttpPost]
        public ActionResult<Client> Post([FromBody] Client client)
        {
            if (client == null)
            {
            return BadRequest();
            }

            LocalStoreData.Clients.Add(client);
            LocalStoreData.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = client.Id }, client);
        }

    }
}