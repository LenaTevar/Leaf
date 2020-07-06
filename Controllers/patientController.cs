using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;

namespace Leaf.Controllers
{
    [ApiController]
    // Security JWT check disabled
    // [Leaf.Attributes.HeaderCheckJWT]
    public class patientController : ControllerBase
    {
        private readonly ILogger<patientController> _logger;

        public patientController(ILogger<patientController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/test")]
        public System.Data.DataTable Get()
        {
            // Random rng = new Random();
            ArrayList myRecipes = new ArrayList();

            using (Leaf.Datalayers.Recipe.DataLayer dl = new Leaf.Datalayers.Recipe.DataLayer((Leaf.Data.ConnectionDB.CENTER)Enum.Parse(typeof(Leaf.Data.ConnectionDB.CENTER), "LEAF_PRE")))
            {
                return dl.GetRecipes("user");

            }
        }
    }
}
