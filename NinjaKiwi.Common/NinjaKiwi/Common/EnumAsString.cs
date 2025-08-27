namespace NinjaKiwi.Common;

[AttributeUsage(AttributeTargets::Field (256))]
public class EnumAsString : PropertyAttribute
{
	public Type enumType; //Field offset: 0x18

	public EnumAsString(Type enumType) { }

	public static T ToEnum(string enumString) { }

}

