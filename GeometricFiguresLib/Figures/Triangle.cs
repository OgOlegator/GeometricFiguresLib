﻿using GeometricFiguresLib.Exceptions;
using static System.Math;

namespace GeometricFiguresLib.Figures
{
    //TODO
    // - Метод IsExists в текущем виде не имеет смысла делать публичным, так как соответствующая фигура по определению не может существовать.
    // - Также, необходимо учесть особенности сравнения чисел с плавающей точкой для корректной работы.
    // - Внедрение Factory, к сожалению, усложняет код и в текущей ситуации не добавляет дополнительной ценности.

    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="sideA">Сторона A</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        /// <exception cref="FigureNotExistsException">Ошибка</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            if (!IsExists())
                throw new FigureNotExistsException();
        }

        public double GetSquare()
        {
            var semiPerimeter = (_sideA + _sideB + _sideC) / 2;

            return Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsExists()
            => _sideA > 0
            && _sideB > 0
            && _sideC > 0
            && _sideA + _sideB > _sideC
            && _sideA + _sideC > _sideB
            && _sideB + _sideC > _sideA;

        /// <summary>
        /// Треугольник прямоугольный?
        /// </summary>
        /// <returns></returns>
        public bool IsRight()
            => Pow(_sideA, 2) + Pow(_sideB, 2) == Pow(_sideC, 2)
            || Pow(_sideA, 2) + Pow(_sideC, 2) == Pow(_sideB, 2)
            || Pow(_sideB, 2) + Pow(_sideC, 2) == Pow(_sideA, 2);
    }
}
