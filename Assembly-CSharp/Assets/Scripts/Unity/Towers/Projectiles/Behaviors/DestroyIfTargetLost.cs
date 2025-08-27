namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DestroyIfTargetLost : ProjectileBehavior
{
	public DestroyIfTargetLost parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public DestroyIfTargetLost() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

