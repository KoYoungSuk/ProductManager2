using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager2
{
    internal class MemberDTO
    {
        String password;

        public MemberDTO()
        {

        }

        public string Password { get => password; set => password = value; }
    }
}
