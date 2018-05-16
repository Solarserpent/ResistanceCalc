using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResistanceCalc.Models
{
    public interface ICalculateResistance
    {
        string CalculateResistance(string colorA, string colorB, string colorC, string colorD);
    }

    public class ResistanceCalculator : ICalculateResistance
    {
        public static readonly Dictionary<string, int> ResistanceValueMap = new Dictionary<string, int>()
        {
            { "Black", 0  },
            { "Brown", 1  },
            { "Red", 2 },
            { "Orange", 3  },
            { "Yellow", 4  },
            { "Green", 5 },
            { "Blue", 6  },
            { "Violet", 7  },
            { "Gray", 8 },
            { "White", 9 }
        };

        public static readonly Dictionary<string, decimal> ResistanceMagnitudeMap = new Dictionary<string, decimal>()
        {
            { "Pink",   .001M  },
            { "Silver", .01M  },
            { "Gold",   .1M },
            { "Black",  1M  },
            { "Brown",  10M  },
            { "Red",    100M },
            { "Orange", 1000M  },
            { "Yellow", 10000M  },
            { "Green",  100000M },
            { "Blue",   1000000M  },
            { "Violet", 10000000M  },
            { "Gray",   100000000M },
            { "White",  1000000000M }
        };


        public static readonly Dictionary<string, string> ResistanceToleranceMap = new Dictionary<string, string>()
        {
            { "None",   "±20%"  },
            { "Silver", "±10%" },
            { "Gold",   "±5%" },
            { "Brown",  "±1%" },
            { "Red",    "±2%" },
            { "Green",  "±0.5%" },
            { "Blue",   "±0.25%"  },
            { "Violet", "±0.1%"  },
            { "Gray",   "±0.05%" }
        };



        public string CalculateResistance(string colorA, string colorB, string colorC, string colorD)
        {
            if (CheckInputs(colorA, colorB, colorC, colorD))
            {
                decimal value = (ResistanceValueMap[colorA] * 10 + ResistanceValueMap[colorB]) * ResistanceMagnitudeMap[colorC];
                return $"{value}Ω {ResistanceToleranceMap[colorD]}";
            }
            else
                return null;
        }

        private bool CheckInputs(string colorA, string colorB, string colorC, string colorD)
        {
            if (colorA != null && ResistanceValueMap.ContainsKey(colorA) &&
                colorB != null && ResistanceValueMap.ContainsKey(colorB) &&
                colorC != null && ResistanceMagnitudeMap.ContainsKey(colorC) &&
                colorD != null && ResistanceToleranceMap.ContainsKey(colorD))
                return true;
            return false;
                

        }
    }
}
