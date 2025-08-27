namespace Assets.Scripts.Models;

[AttributeUsage(AttributeTargets::All (32767))]
public class FormerlyExpressedAs : Attribute
{
	public readonly string name; //Field offset: 0x10

	public FormerlyExpressedAs(string name) { }

}

