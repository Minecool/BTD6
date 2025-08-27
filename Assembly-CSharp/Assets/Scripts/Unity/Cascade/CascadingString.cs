namespace Assets.Scripts.Unity.Cascade;

public class CascadingString : CascadingExpression<String>
{

	public CascadingString() { }

	protected virtual string Calculate() { }

	public string GetXParent(GenericCascadingExpression from) { }

}

