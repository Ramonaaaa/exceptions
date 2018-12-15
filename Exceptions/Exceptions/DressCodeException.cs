using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class DressCodeException : ApplicationException
    {
        string message = "You are not wearing an Elf costume and you are underage!";

        public DressCodeException()
        {
            Console.WriteLine(message);
        }

    }
}
