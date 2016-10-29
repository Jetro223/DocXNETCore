using System;

#if NETSTANDARD1_6
namespace DocX.NETCorePort
{

    public class DescriptionAttribute:Attribute
    {
        public DescriptionAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; }
    }
}
#endif
