using System;

namespace WACG
{
    public class CommandParameterAttribute : Attribute
    {
        public CommandParameterAttribute()
        {
        }
        public CommandParameterAttribute(string shortName)
        {
            ShortName = shortName;
        }

        public string ShortName { get; set; }
        public string FullName { get; set; }

        /// <summary>
        /// 当做为默认参数时参数顺序
        /// </summary>
        public int DefaultOrder { get; set; }

    }
}