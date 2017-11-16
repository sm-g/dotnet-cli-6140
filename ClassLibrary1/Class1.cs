using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary462
{
    public class Class1
    {
        public static void Test()
        {
            Console.WriteLine(new HttpClient());
        }
    }

    public class X
    {
        [Required]
        public bool Q { get; set; }
    }
}