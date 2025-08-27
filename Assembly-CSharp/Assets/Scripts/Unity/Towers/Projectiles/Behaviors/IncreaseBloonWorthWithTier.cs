namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class IncreaseBloonWorthWithTier : ProjectileBehavior
{
	public IncreaseBloonWorthWithTier parent; //Field offset: 0x88
	public string mutatorId; //Field offset: 0x90
	public string expMutatorId; //Field offset: 0x98
	public float cashPerTier; //Field offset: 0xA0
	public string expCashPerTier; //Field offset: 0xA8
	public string overlayType; //Field offset: 0xB0
	public string expOverlayType; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 160
	}

	public IncreaseBloonWorthWithTier() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

