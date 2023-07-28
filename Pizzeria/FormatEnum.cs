using System.ComponentModel;
using System.Reflection;

namespace Pizzeria;

public enum FormatEnum 
{
    [Description("json")]
    JSON,
    [Description("xml")]
    XML
}

public static class Extension {
    public static string GetDescription(this Enum e)
    {
        var attribute =
            e.GetType()
                .GetTypeInfo()
                .GetMember(e.ToString())
                .FirstOrDefault(member => member.MemberType == MemberTypes.Field)
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .SingleOrDefault()
                as DescriptionAttribute;

        return attribute?.Description ?? e.ToString();
    }
}