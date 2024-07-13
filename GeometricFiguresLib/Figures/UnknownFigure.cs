using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Figures.Factories;
using GeometricFiguresLib.Figures.Supports;

namespace GeometricFiguresLib.Figures
{
    /// <summary>
    /// Обработчик неизвестной фигуры
    /// </summary>
    public class UnknownFigure : IFigure
    {
        private readonly IFigure _figure;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="parameters">Параметры фигуры - стороны, углы и пр.</param>
        /// <exception cref="GeometricFiguresLibException">Ошибка</exception>
        public UnknownFigure(FigureParameters parameters) 
        {
            foreach (var figureFactory in GetFactories())
                if (figureFactory.TryGet(parameters, out var figure))
                {
                    _figure = figure;

                    break;
                }


            if (_figure == null)
                throw new GeometricFiguresLibException("Фигура не определена");
        } 

        /// <summary>
        /// Получение фабрик для получения фигур
        /// </summary>
        /// <returns>Список фабрик для получения фигур</returns>
        private static IEnumerable<IFigureFactory> GetFactories()
        {
            yield return new TriangleFactory();
            yield return new CircleFactory();
        }

        public double GetSquare()
            => _figure.GetSquare();

        public bool IsExists()
            => _figure.IsExists();

        /// <summary>
        /// Получить объект фигуры
        /// </summary>
        /// <returns></returns>
        public IFigure GetFigure()
            => _figure;
    }
}
