namespace WACG
{
    public class CommandParameterHelper
    {
        public  static ParameterConatiner<T> Convert<T>(string[] args) where T : new()
        {
            var result = new T();
            return new ParameterConatiner<T>();
        }
    }
}