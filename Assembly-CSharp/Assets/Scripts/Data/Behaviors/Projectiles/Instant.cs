namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Instant", menuName = "BTD6/Behaviors/Projectiles/Instant")]
public class Instant : ProjectileBehavior
{
	public bool destroyIfInvalid; //Field offset: 0x30
	public bool ignoreTargetZ; //Field offset: 0x31
	public bool dontFollowTarget; //Field offset: 0x32

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 150
	}

	public Instant() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

