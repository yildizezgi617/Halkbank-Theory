using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_LINQ.Models
{
    class StudentEqualityComparer
    {
        public bool Equals(Student? x, Student? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
