namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SlowMaimMoab : ProjectileBehavior
{
	public SlowMaimMoab parent; //Field offset: 0x88
	public float moabDuration; //Field offset: 0x90
	public string expMoabDuration; //Field offset: 0x98
	public float bfbDuration; //Field offset: 0xA0
	public string expBfbDuration; //Field offset: 0xA8
	public float zomgDuration; //Field offset: 0xB0
	public string expZomgDuration; //Field offset: 0xB8
	public float ddtDuration; //Field offset: 0xC0
	public string expDdtDuration; //Field offset: 0xC8
	public float badDuration; //Field offset: 0xD0
	public string expBadDuration; //Field offset: 0xD8
	public float multiplier; //Field offset: 0xE0
	public string expMultiplier; //Field offset: 0xE8
	public float bloonPerHitDamageAddition; //Field offset: 0xF0
	public string expBloonPerHitDamageAddition; //Field offset: 0xF8
	public string overlayType; //Field offset: 0x100
	public string expOverlayType; //Field offset: 0x108

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 295
	}

	public SlowMaimMoab() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

