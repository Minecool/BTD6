namespace Assets.Scripts.Models;

[AttributeUsage(AttributeTargets::All (32767))]
public class Implementation : Attribute
{
	public readonly Type type; //Field offset: 0x10
	public readonly bool boxInEntity; //Field offset: 0x18
	public readonly bool useLocalIds; //Field offset: 0x19
	public readonly Type[] extendedTypes; //Field offset: 0x20

	public Implementation(Type type, bool boxInEntity = false, bool useLocalIds = false, Type[] extendedTypes) { }

}

