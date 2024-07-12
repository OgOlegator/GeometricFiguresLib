using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Figures.Factories;

namespace GeometricFiguresLib.Figures
{
    /// <summary>
    /// Обработчик неизвестной фигуры
    /// </summary>
    public class UnknownFigureHandler
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <param name="sides">Параметры фигуры</param>
        /// <returns>Площадь</returns>
        /// <exception cref="GeometricFiguresLibException">Ошибка</exception>
        public static double GetSquare(List<double> sides)
        {
            return GetFigure(sides).GetSquare();
        }

        /// <summary>
        /// Получить фигуру
        /// </summary>
        /// <param name="sides">Стороны</param>
        /// <returns>Объект фигуры</returns>
        /// <exception cref="GeometricFiguresLibException">Ошибка</exception>
        public static IFigure GetFigure(List<double> sides)
        {
            foreach (var figureFactory in GetFactories())
                if (figureFactory.TryGet(sides, out var figure))
                    return figure;

            throw new GeometricFiguresLibException("Фигура не определена");
        }

        /// <summary>
        /// Получить список фабрик для получения фигур
        /// </summary>
        /// <returns>Список фабрик для получения фигур</returns>
        private static IEnumerable<IFigureFactory> GetFactories()
        {
            yield return new TriangleFactory();
            yield return new CircleFactory();
        }
    }
}
