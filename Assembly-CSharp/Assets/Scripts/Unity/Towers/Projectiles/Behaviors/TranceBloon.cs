namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class TranceBloon : ProjectileBehavior
{
	public float speedMultiplier; //Field offset: 0x88
	public string expSpeedMultiplier; //Field offset: 0x90
	public float duration; //Field offset: 0x98
	public string expDuration; //Field offset: 0xA0
	public float orbitRadius; //Field offset: 0xA8
	public string expOrbitRadius; //Field offset: 0xB0
	public float radiusBloonSizeMultiplier; //Field offset: 0xB8
	public string expRadiusBloonSizeMultiplier; //Field offset: 0xC0
	public float cooldown; //Field offset: 0xC8
	public string expCooldown; //Field offset: 0xD0
	public float moabOrbitSpeed; //Field offset: 0xD8
	public string expMoabOrbitSpeed; //Field offset: 0xE0
	public int maxDotDamage; //Field offset: 0xE8
	public string expMaxDotDamage; //Field offset: 0xF0
	public Damage fakeDamage; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 421
	}

	public TranceBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

