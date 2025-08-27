namespace NinjaKiwi.Common;

[AttributeUsage(AttributeTargets::Field (256))]
public class LongEnumFlagsAttribute : PropertyAttribute
{
	public Type enumType; //Field offset: 0x18
	public bool isFlags; //Field offset: 0x20

	public LongEnumFlagsAttribute(Type enumType, bool isFlags = true) { }

}

