namespace AreaLib.BaseFigures
{
    public sealed class Circle : Figure
    {
        private double _radius;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double[] values)
        {
            if (values == null || values.Length != 1)
            {
                throw new ArgumentException(InformationStrings._ERROR_CIRCLE_INCORRECT_ARGUMENTS);
            }
            if (values.First() < 0)
                throw new ArgumentException(InformationStrings._ERROR_CIRCLE_RADIUS_LESS_THAN_ZERO);

            _radius = values.First();
        }

        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Расчет площади круга 
        /// Формула площади круга по радиусу:
        /// Sк = PI * r * r
        /// где r - радиус круга
        /// </summary>
        /// <returns>Значение площади типа double</returns>
        public override double EvaluateArea()
        {
            if(_square == 0) 
                base._square = Math.PI * _radius * _radius;
            
            return _square;
        }
    }
}