using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ClassLibrary2
{
    public class Class1
    {
        public Class1(IConfiguration configuration)
        {
            var test = configuration["Test"];
            var whoops = test;
        }
    }
}
