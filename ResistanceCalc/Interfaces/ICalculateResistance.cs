﻿using System;
using System.Collections.Generic;


namespace ResistanceCalc.Interfaces
{
    public interface IOhmValueCalculator
    {
        string CalculateResistance(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        (decimal value, decimal tolerance) CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
    }
       
}
