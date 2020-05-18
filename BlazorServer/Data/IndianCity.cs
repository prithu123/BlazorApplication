using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Data
{
    public class IndianCity :City
    {
        public String state { get; set; }
        public String region { get; set; }
    }
}
