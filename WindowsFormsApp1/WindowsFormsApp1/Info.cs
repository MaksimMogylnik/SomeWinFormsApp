using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Info
    {
        public string Img { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string FName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Job { get; set; }

        public string AddInfo { get; set; }
    }
}
