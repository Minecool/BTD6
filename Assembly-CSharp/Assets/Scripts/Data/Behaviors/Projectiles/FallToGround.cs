namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "FallToGround", menuName = "BTD6/Behaviors/Projectiles/FallToGround")]
public class FallToGround : ProjectileBehavior
{
	public float timeToTake; //Field offset: 0x30
	public bool expireOnContact; //Field offset: 0x34
	public float groundOffset; //Field offset: 0x38

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public FallToGround() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

