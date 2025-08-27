namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CantBeReflected : ProjectileBehavior
{
	public CantBeReflected parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 118
	}

	public CantBeReflected() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

