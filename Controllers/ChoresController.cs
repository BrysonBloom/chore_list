using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chore_list.Controllers;

    [ApiController]
    [Route("api/chores")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choresService;
        public ChoresController(ChoresService choreService){
            _choresService = choreService;
        }
        [HttpGet]
        public ActionResult<List<Chore>> GetAll(){
            try
            {
                return Ok(_choresService.GetAllChores());
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
