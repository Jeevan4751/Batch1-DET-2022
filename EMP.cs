<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class EMP
{
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public EMP(int eid, string ename, DateOnly doj)
        {
            id = eid; name = ename; this.doj = doj;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class EMP
{
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public EMP(int eid, string ename, DateOnly doj)
        {
            id = eid; name = ename; this.doj = doj;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }
    }
}
>>>>>>> d410628cc542a299d3516753cba455a326c00d68
