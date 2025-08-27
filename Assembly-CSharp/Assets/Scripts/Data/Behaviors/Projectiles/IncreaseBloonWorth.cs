namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "IncreaseBloonWorth", menuName = "BTD6/Behaviors/Projectiles/IncreaseBloonWorth")]
public class IncreaseBloonWorth : ProjectileBehavior
{
	public string mutatorId; //Field offset: 0x30
	public float cash; //Field offset: 0x38
	public float cashMultiplier; //Field offset: 0x3C
	public float charges; //Field offset: 0x40
	public Filter bloonFilter; //Field offset: 0x48
	public string overlayType; //Field offset: 0x50
	public float duration; //Field offset: 0x58
	public BloonProperties bloonProperties; //Field offset: 0x5C

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 381
	}

	public IncreaseBloonWorth() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

