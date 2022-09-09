using System;
using System.Collections.Generic;
using System.Text;

namespace My_shop.Utilities.Exceptions
{
    public class My_shopException : Exception
    {
        public My_shopException()
        {
        }

        public My_shopException(string message)
            : base(message)
        {
        }

        public My_shopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
