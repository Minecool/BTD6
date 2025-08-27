namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "SlowMaimMoab", menuName = "BTD6/Behaviors/Projectiles/SlowMaimMoab")]
public class SlowMaimMoab : ProjectileBehavior
{
	public float moabDuration; //Field offset: 0x30
	public float bfbDuration; //Field offset: 0x34
	public float zomgDuration; //Field offset: 0x38
	public float ddtDuration; //Field offset: 0x3C
	public float badDuration; //Field offset: 0x40
	public float multiplier; //Field offset: 0x44
	public float bloonPerHitDamageAddition; //Field offset: 0x48
	public string overlayType; //Field offset: 0x50

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 271
	}

	public SlowMaimMoab() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

