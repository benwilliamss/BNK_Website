using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using BNK.Models;
using System.Collections.Generic;

namespace BNK.Services
{
    [Route("api/[controller]")]
    [ApiController]
    //service to return a list/Enumerable of queries back to the user 
    public class DbQueriesService : ControllerBase
    {
        public IWebHostEnvironment WebHostEnvironment { get; } //assignment in the construcor
        public DbQueriesService(IWebHostEnvironment webHostEnvironment) 
        { //constructor
            WebHostEnvironment = webHostEnvironment; //keeping the webhost env - allows us to retrieve data and the web host now knows the path 
        }
        //may need a property to find the DB

       /* public IEnumerable<Queries> GetQueries() {
            return 
        }*/
    }
}
