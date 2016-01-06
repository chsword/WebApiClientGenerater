using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WACG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var param = CommandParameterHelper.Convert<Param>(args);
        }

       
    }

    public class Param
    {
        [CommandParameter("s",FullName ="src")]
        public string Source { get; set; }
    }
}
