namespace GeometricFiguresLib.Figures
{
    /// <summary>
    /// Фигура
    /// </summary>
    public interface IFigure
    {

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>Площадь</returns>
        public double GetSquare();

        /// <summary>
        /// Фигура существует?
        /// </summary>
        /// <returns>Существует?</returns>
        public bool IsExists();

    }
}
