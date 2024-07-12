namespace GeometricFiguresLib.Figures.Factories
{
    internal interface IFigureFactory
    {
        /// <summary>
        /// Получить объект фигуры если это та фигура
        /// </summary>
        /// <param name="sides">Стороны</param>
        /// <param name="figure">Объект фигуры</param>
        /// <returns></returns>
        bool TryGet(List<double> sides, out IFigure figure);
    }
}
