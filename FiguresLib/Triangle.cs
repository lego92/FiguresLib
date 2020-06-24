using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    public class Triangle : Figure
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (ValidateSides(firstSide, secondSide, thirdSide))
            {
                if (IsTriangleExist(firstSide, secondSide, thirdSide))
                {
                    FirstSide = firstSide;
                    SecondSide = secondSide;
                    ThirdSide = thirdSide;
                }
                else
                    throw new Exception("Нельзя построить треугольник с такими длинами сторон");                
            }
            else
                throw new Exception("Длины сторон треугольника не могут быть нулевыми или отрицательными");
        }

        /// <summary>
        /// Проверка на поподание длин сторон треугольника в допустимый диапазон
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        /// <returns>Попадают ли все стороны в допустимый диапазон</returns>
        private bool ValidateSides(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Проверяет, можно ли построить треугольник с такими сторонами
        /// </summary>
        /// <param name="firstSide">Первая сторона треугольника</param>
        /// <param name="secondSide">Вторая сторона треугольника</param>
        /// <param name="thirdSide">Третья сторона треугольника</param>
        /// <returns>Существуте ли труегольник с такими сторонами</returns>
        private bool IsTriangleExist(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide + secondSide < thirdSide 
                || secondSide + thirdSide < firstSide 
                || thirdSide + firstSide < secondSide)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Вычисленная площадь треугольника</returns>
        public override double CalculateArea()
        {
            double halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Является ли треугольник прямогульным</returns>
        public bool IsTriangleRigth()
        {
            if (Math.Pow(FirstSide, 2) == Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2)
                || Math.Pow(SecondSide, 2) == Math.Pow(ThirdSide, 2) + Math.Pow(FirstSide, 2)
                || Math.Pow(ThirdSide, 2) == Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2))
                return true;
            else
                return false;            
        }
    }
}
