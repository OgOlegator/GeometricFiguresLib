using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresLib.Figures.Supports
{
    public class FigureParameters
    {
        private Dictionary<string, List<double>> _params = new Dictionary<string, List<double>>();

        public const string SidesKey = "sides";
        public const string AnglesKey = "angles";

        /// <summary>
        /// Добавить стороны фигуры. Если фигура окружность, то ее радиус это сторона
        /// </summary>
        /// <param name="sides">Список сторон фигуры</param>
        public FigureParameters AddSides(List<double> sides)
        {
            _params.Add(SidesKey, sides);

            return this;
        }

        /// <summary>
        /// Добавить углы фигуры
        /// </summary>
        /// <param name="angles">Список углов фигуры</param>
        public FigureParameters AddAngles(List<double> angles) 
        {
            _params.Add(AnglesKey, angles);

            return this;
        }

        public Dictionary<string, List<double>> GetParams()
            => _params;
    }
}
