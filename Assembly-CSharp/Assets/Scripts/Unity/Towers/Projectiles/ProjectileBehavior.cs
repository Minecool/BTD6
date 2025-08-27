namespace Assets.Scripts.Unity.Towers.Projectiles;

public abstract class ProjectileBehavior : CascadingItemProxy
{

	public abstract ProjectileBehaviorModel Def
	{
		 get { } //Length: 0
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	protected ProjectileBehavior() { }

	public abstract ProjectileBehaviorModel get_Def() { }

	public virtual Model get_Model() { }

}

