using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public abstract class Figure
    {
        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <returns>Вычисленная площадь фигуры</returns>
        public abstract double CalculateArea();
    }
}
