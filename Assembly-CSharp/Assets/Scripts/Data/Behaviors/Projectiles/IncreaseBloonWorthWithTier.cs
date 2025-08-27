namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "IncreaseBloonWorthWithTier", menuName = "BTD6/Behaviors/Projectiles/IncreaseBloonWorthWithTier")]
public class IncreaseBloonWorthWithTier : ProjectileBehavior
{
	public string mutatorId; //Field offset: 0x30
	public float cashPerTier; //Field offset: 0x38
	public string overlayType; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 151
	}

	public IncreaseBloonWorthWithTier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

