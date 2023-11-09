namespace AreaLib
{
    /// <summary>
    /// Абстрактный тип для наследования примитивов фигур, реализует интерфейс IFigureCalculation
    /// </summary>
    public abstract class Figure : IFigureCalculation
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        protected double _square = 0;

        public abstract double EvaluateArea();
    }
}
