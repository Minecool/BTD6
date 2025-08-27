namespace NinjaKiwi.Common;

[AttributeUsage(AttributeTargets::Field (256))]
public class ULongEnumFlagsAttribute : PropertyAttribute
{
	public Type enumType; //Field offset: 0x18
	public bool isFlags; //Field offset: 0x20

	public ULongEnumFlagsAttribute(Type enumType, bool isFlags = true) { }

}

