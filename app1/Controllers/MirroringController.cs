using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MirroringController : ControllerBase
    {
        [HttpGet("normal")]
        public Task<string[]> GetNormal()
        {
            return Task.FromResult(new[] {"normal"});
        }

        [HttpGet("bugs")]
        public Task<string[]> GetBugs()
        {
            return Task.FromResult(new[] { "bugs" });
        }

        [HttpGet("slow")]
        public Task<string[]> GetSlow()
        {
            return Task.FromResult(new[] { "slow" });
        }

        [HttpPost]
        public void Post([FromBody] Test value)
        {
        }

        public class Test {
            public int Value1 { get; set; }
            public string Value2 { get; set; }
        }

      
    }
}
