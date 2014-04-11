using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Models;

namespace Web.Controllers
{
    public class IncidentsController : ApiController
    {
        // GET api/values
        public IEnumerable<Row> Get()
        {
            return new[] {
                new Row{
                    sDate = "today",                       
                    sTime = "13:30",                       
                    sDeparture = "Rabbit Memory Alert CRITICAL",        
                    nStatus = 1,                           
                    nTrack = "JP",                           
                    bLight = true                          
                },                                       
                new Row{
                    sDate = "yesterday",                   
                    sTime = "13:32",                       
                    sDeparture = "Rabbit Sockets Alert CRITICAL",        
                    nStatus = 2,                           
                    nTrack = "DS",                           
                    bLight = false                          
                }                                 
            };
        }
    }
}
