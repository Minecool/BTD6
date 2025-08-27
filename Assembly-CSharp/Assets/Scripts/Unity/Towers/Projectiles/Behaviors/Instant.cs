namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Instant : ProjectileBehavior
{
	public Instant parent; //Field offset: 0x88
	public bool destroyIfInvalid; //Field offset: 0x90
	public string expDestroyIfInvalid; //Field offset: 0x98
	public bool ignoreTargetZ; //Field offset: 0xA0
	public string expIgnoreTargetZ; //Field offset: 0xA8
	public bool dontFollowTarget; //Field offset: 0xB0
	public string expdontFollowTarget; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 159
	}

	public Instant() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

