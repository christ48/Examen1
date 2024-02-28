using Backend.Models;
using Backend.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritoController : ControllerBase
    {

        IDistrictoService _DistritoService;

        public DistritoController(IDistrictoService distritoService) {
        
            _DistritoService = distritoService;
        }



        // GET: api/<DistritoController>
        [HttpGet]
        public IEnumerable<DistrictoModel> Get()

        {
            return _DistritoService.GetDistrictos();
        }

        // GET api/<DistritoController>/5
        [HttpGet("{id}")]
        public DistrictoModel Get(int id)
        {
           return _DistritoService.GetbyId(id);
        }

        // POST api/<DistritoController>
        [HttpPost]
        public string Post([FromBody] DistrictoModel districto)
        {
            var result = _DistritoService.addDistricto(districto);
            if (result) {
                return "Districto agregado";
                
                
            }
            return "Error";
        }

        // PUT api/<DistritoController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] DistrictoModel districto)
        {
            var result= _DistritoService.updateDistricto(districto);
            if (result)
            {
                return "Districto actualizado";

            }
            return "Error";


        }

        // DELETE api/<DistritoController>/5
        [HttpDelete("{id}")]
        public string  Delete(int id)
        {

            DistrictoModel districto = new DistrictoModel { DistritoId = id };
            var result = _DistritoService.deleteDistricto(districto);
            if ( result)
            {
                return "Eliminado";
            }
            return "Error";

        }
    }
}
