namespace NinjaKiwi.Common;

[AttributeUsage(AttributeTargets::Field (256))]
public class TypeSelectionAsString : PropertyAttribute
{
	public string rootNamespace; //Field offset: 0x18
	public Type baseType; //Field offset: 0x20

	public TypeSelectionAsString(string rootNamespace, Type baseType) { }

}

