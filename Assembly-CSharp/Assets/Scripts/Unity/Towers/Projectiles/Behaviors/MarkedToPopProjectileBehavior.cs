namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class MarkedToPopProjectileBehavior : ProjectileBehavior
{
	public MarkedToPopProjectileBehavior parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public MarkedToPopProjectileBehavior() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

