using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.BackEnd
{
    public class ClientClass
    {
        public string name { get; set; }
        public string age { get; set; }
        public string gender { get; set; }
        public string id { get; set; }

        public ClientClass(string name, string age, string gender, string id)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.id = id;
        }
    }
}
