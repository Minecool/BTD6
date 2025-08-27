namespace Assets.Scripts.Unity;

public abstract class EntityBehavior : CascadingItemProxy
{

	public abstract T Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected EntityBehavior`1() { }

	public abstract T get_Def() { }

	public virtual Model get_Model() { }

}

