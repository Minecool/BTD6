namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class FadeProjectile : ProjectileBehavior
{
	public FadeProjectile parent; //Field offset: 0x88
	public float startFadingAt; //Field offset: 0x90
	public string expStartFadingAt; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public FadeProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

