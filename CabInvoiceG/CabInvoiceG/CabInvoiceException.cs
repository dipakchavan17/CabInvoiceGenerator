using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceG
{
    public class CabInvoiceException : Exception
    {
        public ExceptionType type;
        //ExcecptionType enum
        public enum ExceptionType
        {
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_RIDETYPES,
            INVALID_USER_ID
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CabInvoiceException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}