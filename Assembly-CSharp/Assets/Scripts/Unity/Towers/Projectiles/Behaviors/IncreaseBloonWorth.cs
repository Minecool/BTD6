namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class IncreaseBloonWorth : ProjectileBehavior
{
	public IncreaseBloonWorth parent; //Field offset: 0x88
	public string mutatorId; //Field offset: 0x90
	public string expMutatorId; //Field offset: 0x98
	public float cash; //Field offset: 0xA0
	public string expCash; //Field offset: 0xA8
	public float cashMultiplier; //Field offset: 0xB0
	public string expCashMultiplier; //Field offset: 0xB8
	public float charges; //Field offset: 0xC0
	public string expCharges; //Field offset: 0xC8
	public Filter bloonFilter; //Field offset: 0xD0
	public Filter expBloonFilter; //Field offset: 0xD8
	public string overlayType; //Field offset: 0xE0
	public string expOverlayType; //Field offset: 0xE8
	public float duration; //Field offset: 0xF0
	public string expDuration; //Field offset: 0xF8
	public string bloonPropertiesToRemove; //Field offset: 0x100
	public string expBloonPropertiesToRemove; //Field offset: 0x108

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 454
	}

	public IncreaseBloonWorth() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

