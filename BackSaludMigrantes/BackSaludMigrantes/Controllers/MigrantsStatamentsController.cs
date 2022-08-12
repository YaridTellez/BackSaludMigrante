using BackSaludMigrantes.Models.Context;
using BackSaludMigrantes.Models.Entities;
using BackSaludMigrantes.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackSaludMigrantes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MigrantsStatamentsController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public MigrantsStatamentsController(DataContext dbContext)
        {
            _dataContext = dbContext;
        }

        [HttpGet("{idSisben}")]

        public ActionResult<StatamentsResponse> GetMigrationStatamentsSisben(string idSisben)
        {
            var response = new StatamentsResponse();

            MigrantsStatements MSS = new MigrantsStatements();
            try
            {
                MSS = _dataContext.MigrantsStatements.Find(idSisben);
                if (MSS == null)
                {
                    response.ErrorMessage = "No Se Encuentra Registrado Declaraciones";
                    return response;
                }
                response.MigrantsStatements = MSS;
                response.IsRegistered = true;
                return Ok(response);
            }
            catch (Exception e)
            {
                response.ErrorMessage = e.Message;
                return StatusCode(500, response);
            }

        }

    }
}
