namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DestroyWhenHitImmune : ProjectileBehavior
{
	public DestroyWhenHitImmune parent; //Field offset: 0x88
	public bool getsDestroyed; //Field offset: 0x90
	public string expGetsDestroyed; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public DestroyWhenHitImmune() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

