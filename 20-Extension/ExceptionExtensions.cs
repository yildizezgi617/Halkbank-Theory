using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Extension
{
    public static class ExceptionExtensions
    {

        public static string GetFullMessage(this Exception exception)
        {
           
            return $"Error:+ exception.Message + \nOccured at: {exception.StackTrace} ? ";

        }
    }
}
