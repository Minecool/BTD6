namespace NinjaKiwi.Common;

public class ReorderableListAttribute : PropertyAttribute
{
	public readonly string propertyName; //Field offset: 0x18
	public readonly bool inline; //Field offset: 0x20

	public ReorderableListAttribute(string propertyName, bool inline = true) { }

}

