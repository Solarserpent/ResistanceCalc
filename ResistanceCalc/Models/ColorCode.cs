using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResistanceCalc.Enums;

namespace ResistanceCalc.Models
{
    public class ColorCode
    {
        //public ColorCode(string colorA, string colorB, string colorC, string colorD)
        //{
        //    ColorA = colorA;
        //    ColorB = colorB;
        //    ColorC = colorC;
        //    ColorD = colorD;
        //}

        public string ColorA { get; set; }
        public string ColorB { get; set; }
        public string ColorC { get; set; }
        public string ColorD { get; set; }

        public string Resistance { get; set; }

    }
}
