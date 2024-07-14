using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Factories;
using GeometricFiguresLib.Supports;

namespace GeometricFiguresLib.Figures
{
    /// <summary>
    /// Обработчик неизвестной фигуры
    /// </summary>
    public class UnknownFigure : IFigure
    {
        private readonly IFigure _figure;

        /// <summary>
        /// Конструктор по фигуре
        /// </summary>
        /// <param name="figure">Фигура</param>
        public UnknownFigure(IFigure figure)
        {
            _figure = figure;
        }

        /// <summary>
        /// Конструктор по параметрам фигуры
        /// </summary>
        /// <param name="parameters">Параметры фигуры - стороны, углы и пр.</param>
        /// <exception cref="GeometricFiguresLibException">Ошибка</exception>
        public UnknownFigure(FigureParameters parameters) 
        {
            foreach (var figureFactory in GetFactories())
                if (figureFactory.TryGet(parameters, out var figure))
                {
                    //Инстанция фигуры может вернуться, несмотря на то, что фигура не существует, при неправильной или другой реализации проверки фигуры
                    //Но она не присвоится глобальной переменной класса, т.к. TryGet, вернет false
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
            //Варианты получения набора фабрик фигур (реализован вариант 2):
            //
            //1) Использовать Assembly для поиска всех классов реализующих IFigureFactory в текущей сборке,
            //Но нельзя гарантировать, что конструктор фабрики, добавляемой в будущем фигуры, не будет иметь параметров. 
            //В случае, если появится фабрика с параметрами в конструкторе, будет затруднительно иницилизировать единообразно такой класс.
            //
            //2) Расширять данный метод избегая указанную выше проблему.
            //
            //3) Объявлять каждую фабрику как свойство класса, подобно DbSet в Ef Core, и создавать инстанцию для этих свойств при 
            //Иницилизации данного класса, а затем собирать набор свойств данного класса используя рефлексию. Данный способ показался мне не самым удачным, т.к.
            //Класс хранил бы в себе много лишних инстанций, которые после определения фигуры, были бы не нужны.
            //
            //4) Вынести реализацию логики определения и получения фигуры в другой класс и реализовать способ, предложенный в варианте 3, так можно
            //было избежать недостатков 3-го варианта, но этот способ я придумал после завершения реализации задания, а уже 2 часа ночи и мне стало лень :)))
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
