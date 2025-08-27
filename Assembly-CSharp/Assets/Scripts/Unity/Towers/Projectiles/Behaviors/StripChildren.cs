namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class StripChildren : ProjectileBehavior
{
	public StripChildren parent; //Field offset: 0x88
	public string overlayType; //Field offset: 0x90
	public string expOverlayType; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public StripChildren() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

