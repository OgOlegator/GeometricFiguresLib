using GeometricFiguresLib.Figures.Supports;

namespace GeometricFiguresLib.Figures.Factories
{
    /// <summary>
    /// Фабрика фигур
    /// </summary>
    internal interface IFigureFactory
    {
        /// <summary>
        /// Получить объект фигуры если это фигура
        /// </summary>
        /// <param name="parameters">Параметры фигуры</param>
        /// <param name="figure">Объект фигуры</param>
        /// <returns>Фигура с такими параметрами существует?</returns>
        bool TryGet(FigureParameters parameters, out IFigure figure);
    }
}
