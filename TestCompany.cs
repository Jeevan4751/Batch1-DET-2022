<<<<<<< HEAD
﻿using Batch1_DET_2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCompany
{
        public static void Main()
        {
            
            CompanyManager mgrn = new CompanyManager { name = "jeevan", surename = "s", phone = "8970006296" };
            Company company = new Company { name = "sonata software", address = "global village", website = "ssl.com", faxnumber = "485", phone = "9844608892", Manager = mgrn };

            Console.WriteLine(company.ToString());
            
        }
}
}
=======
﻿using Batch1_DET_2022;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCompany
{
        public static void Main()
        {
            
            CompanyManager mgrn = new CompanyManager { name = "jeevan", surename = "s", phone = "8970006296" };
            Company company = new Company { name = "sonata software", address = "global village", website = "ssl.com", faxnumber = "485", phone = "9844608892", Manager = mgrn };

            Console.WriteLine(company.Print());
            
        }
}
}
>>>>>>> d410628cc542a299d3516753cba455a326c00d68
