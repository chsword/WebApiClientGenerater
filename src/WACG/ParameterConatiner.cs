using System;
using System.Linq.Expressions;

namespace WACG
{
    public class ParameterConatiner<T>
    {
        public bool Has<TProperty>(Expression<Func<T, TProperty>> expression)
        {
            return true;
        }

        public T Parameter { get; set; }

        public bool IsValid { get; private set; }

    }
}