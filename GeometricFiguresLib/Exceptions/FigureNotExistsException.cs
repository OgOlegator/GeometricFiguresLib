using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresLib.Exceptions
{
    public class FigureNotExistsException : GeometricFiguresLibException
    {
        public FigureNotExistsException() : base("Фигура не существует")
        {
        }
    }
}
