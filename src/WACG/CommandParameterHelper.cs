
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;

namespace WACG
{
    public class CommandParameterHelper
    {
        public  static ParameterConatiner<T> Convert<T>(string[] args) where T : new()
        {
            var result = new T();
            var props = typeof (T).GetTypeInfo()
                .DeclaredProperties.Where(c => c.GetMethod.IsPublic
                                               &&
                                               !c.GetMethod.IsStatic).ToArray();
            foreach (var propertyInfo in props)
            {
                var attrs = propertyInfo.GetCustomAttributes().Where(c => c is CommandParameterAttribute).ToArray();
                Contract.Assert(attrs.Length <= 1);
                if (!attrs.Any()) continue;
            }
            return new ParameterConatiner<T>();
        }
    }
}