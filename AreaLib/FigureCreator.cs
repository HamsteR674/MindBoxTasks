using AreaLib.BaseFigures;

namespace AreaLib
{
    //SimpleFactory
    public static class FigureCreator
    {
        /// <summary>
        /// Простая фабрика для создания фигур
        /// </summary>
        /// <param name="type">Тип создаваемой фигуры в формате string. Требуется передать значение, которое будет возможно спарсить при помощи Enum.TryParse. Спискок значений см. в enum FigureType</param>
        /// <param name="values">Параметры фигуры</param>
        /// <returns>Экземпляр объекта-наследника Figure</returns>
        /// <exception cref="ArgumentException"></exception>
        public static Figure Create(string type, params double[] values)
        {
            FigureType figureType;
            if(!Enum.TryParse(type, true, out figureType))
                throw new ArgumentException(InformationStrings._ERROR_FACTORY_INCORRECT_TYPE, nameof(type));
            return Create(figureType, values);
        }

        /// <summary>
        /// Простая фабрика для создания фигур
        /// </summary>
        /// <param name="type">Тип создаваемой фигуры</param>
        /// <param name="values">Параметры фигуры</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Figure Create(FigureType type, params double[] values)
        {
            switch (type)
            {
                case FigureType.Circle:
                    return new Circle(values);
                case FigureType.Triangle:
                    return new Triangle(values);
                default:
                    throw new NotImplementedException(InformationStrings._ERROR_FACTORY_INCORRECT_TYPE);
            }
        }

        public enum FigureType
        {
            Triangle,
            Circle,
            //Square
        };
    }
}
