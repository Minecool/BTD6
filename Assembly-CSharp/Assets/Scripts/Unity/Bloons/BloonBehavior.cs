namespace Assets.Scripts.Unity.Bloons;

public abstract class BloonBehavior : CascadingItemProxy
{

	public abstract BloonBehaviorModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected BloonBehavior() { }

	public abstract BloonBehaviorModel get_Def() { }

	public virtual Model get_Model() { }

}

