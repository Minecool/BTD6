namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class FallToGround : ProjectileBehavior
{
	public FallToGround parent; //Field offset: 0x88
	public float timeToTake; //Field offset: 0x90
	public string expTimeToTake; //Field offset: 0x98
	public bool expireOnContact; //Field offset: 0xA0
	public string expExpireOnContact; //Field offset: 0xA8
	public float groundOffset; //Field offset: 0xB0
	public string expGroundOffset; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 194
	}

	public FallToGround() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

