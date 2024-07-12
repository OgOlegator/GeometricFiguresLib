using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresLib.Exceptions
{
    /// <summary>
    /// Общий класс ошибки
    /// </summary>
    public class GeometricFiguresLibException : Exception
    {
        public GeometricFiguresLibException(string? message) : base(message)
        {
        }
    }
}
