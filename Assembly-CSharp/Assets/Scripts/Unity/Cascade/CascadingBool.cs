namespace Assets.Scripts.Unity.Cascade;

public class CascadingBool : CascadingExpression<Boolean>
{

	public CascadingBool() { }

	protected virtual bool Calculate() { }

	protected virtual string Clean(string dirty) { }

}

