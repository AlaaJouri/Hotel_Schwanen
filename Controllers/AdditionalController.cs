using Hotel_Schwanen.Interfaces;
using Hotel_Schwanen.Models;
using Microsoft.AspNetCore.Mvc;


namespace Hotel_Schwanen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalController : ControllerBase
    {
        private readonly IAdditionalServiceService additionalServiceService;

        public AdditionalController(IAdditionalServiceService additionalServiceService)
        {
            this.additionalServiceService = additionalServiceService;
        }

        // GET: api/Additional
        [HttpGet]
        public async Task<ActionResult<List<AdditionalService>>> GetAllServices()
        {
            var services = await additionalServiceService.GetAllServices();
            return Ok(services);
        }

        // GET api/Additional/5
        [HttpGet("{id}", Name = "GetServiceById")]
        public async Task<ActionResult<AdditionalService>> GetServiceById(string id)
        {
            var service = await additionalServiceService.GetServiceById(id);

            if (service == null)
            {
                return NotFound();
            }

            return Ok(service);
        }

        // POST api/Additional
        [HttpPost]
        public async Task<ActionResult<AdditionalService>> AddService([FromBody] AdditionalService service)
        {
            await additionalServiceService.AddService(service);

            return CreatedAtRoute("GetServiceById", new { id = service.Id }, service);
        }

        // PUT api/Additional/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateService(string id, [FromBody] AdditionalService serviceIn)
        {
            var service = await additionalServiceService.GetServiceById(id);

            if (service == null)
            {
                return NotFound();
            }

            await additionalServiceService.UpdateService(id, serviceIn);

            return NoContent();
        }

        // DELETE api/Additional/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(string id)
        {
            var service = await additionalServiceService.GetServiceById(id);

            if (service == null)
            {
                return NotFound();
            }

            await additionalServiceService.DeleteService(id);

            return NoContent();
        }
    }

}
