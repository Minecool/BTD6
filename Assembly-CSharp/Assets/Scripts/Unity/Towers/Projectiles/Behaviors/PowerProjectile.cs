namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class PowerProjectile : ProjectileBehavior
{
	public PowerProjectile parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public PowerProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

