namespace AreaLib.BaseFigures
{
    public sealed class Triangle : Figure
    {

        private double[] _sides;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sides"></param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double[] sides)
        {
            if (sides.Length != 3)
                throw new ArgumentException(InformationStrings._ERROR_TRIANGLE_INCORRECT_ARGUMENTS);
            if (sides.Any(q => q <= 0))
                throw new ArgumentException(InformationStrings._ERROR_TRIANGLE_SIDE_VALUE_ZERO_OR_LESS);

            _sides = sides;
        }


        /// <summary>
        /// Расчет площади треугольника 
        /// Формула площади треугольника по 3 сторонам:
        /// Sт = Sqrt(p * (p - a) * (p - b) - (p - c))
        /// где p - полупериметр, который вычисляется по формуле: (a + b + c) / 2
        /// </summary>
        /// <returns>Значение площади типа double</returns>
        public override double EvaluateArea()
        {
            if (_square == 0)
            {
                double semiPerimeter = _sides.Sum() / 2;
                base._square = Math.Sqrt(semiPerimeter * (semiPerimeter - _sides[0]) * (semiPerimeter - _sides[1]) * (semiPerimeter - _sides[2]));
            }
            return _square;
        }

        public bool IsRightAngled()
        {
            var sortedSides = _sides.OrderBy(side => side).ToArray();
            return sortedSides.Last() * sortedSides.Last() == sortedSides.Take(2).Select(side => side * side).Sum();
        }


    }
}
