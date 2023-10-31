using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_Form.Application.Diagnostics
{
    public class Guard
    {
        public void ThrowIfNull(object value, string argumentName = null)
        {
            if (value == null)
            {
                throw new ArgumentNullException
                    (string.IsNullOrEmpty(argumentName) ? nameof(value) : argumentName);
            }

        }
    }
}
