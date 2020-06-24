using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Circle : Figure
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (ValidateRadius(radius))
                Radius = radius;
            else
                throw new Exception("Длина радиуса не может быть нулевым или отрицательным");
        }

        /// <summary>
        /// Проверка на попадания радиуса в допустимый диапазон
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        /// <returns>Попадает ли радиус в допустимый диапазон</returns>
        private bool ValidateRadius(double radius)
        {
            if (radius <= 0)                            
                return false;
            else               
                return true;                            
        }

        /// <summary>
        /// Вычисляет площадь круга с заданным радиусом
        /// </summary>
        /// <returns>Вычисленная площадь круга</returns>
        public override double CalculateArea()
        {
            return Math.Pow(Math.PI, 2) * Radius;
        }
    }
}
