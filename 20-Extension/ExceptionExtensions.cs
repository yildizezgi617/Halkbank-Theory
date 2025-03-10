using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Extension
{
    public static class ExceptionExtensions
    {
        public static string GetFirendlyMessage(this Exception exception)
        {
            return $"Error: {exception.Message}\nOccured at: {exception.StackTrace?.Split('\n')[0]}\n Date Time: {DateTime.UtcNow}";
        }
    }
}
