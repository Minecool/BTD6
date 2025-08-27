namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageModifierForBloonType : DamageModifier
{
	public DamageModifierForBloonType parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public float additive; //Field offset: 0xA0
	public string expAdditive; //Field offset: 0xA8
	public string includeChildTypes; //Field offset: 0xB0
	public string expIncludeChildTypes; //Field offset: 0xB8
	[BloonType]
	public string bloonType; //Field offset: 0xC0
	[BloonType]
	public string expBloonType; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 230
	}

	public DamageModifierForBloonType() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

