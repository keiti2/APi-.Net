using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infra.Repository;
using Infra.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Spac.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        public readonly ClienteRepository _clienterepository;

        public ClienteController(ClienteRepository repository)
        {
            _clienterepository = repository;
        }

        // getallcliente: api/<controller> 
        [HttpGet]
        public  Task<IEnumerable<Cliente>> GetAll()
        {
            return _clienterepository.GetAllCliente();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
