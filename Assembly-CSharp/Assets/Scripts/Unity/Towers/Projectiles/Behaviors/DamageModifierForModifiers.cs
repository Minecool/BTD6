namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageModifierForModifiers : DamageModifier
{
	public DamageModifierForModifiers parent; //Field offset: 0x88
	public float multiplier; //Field offset: 0x90
	public string expMultiplier; //Field offset: 0x98
	public float additive; //Field offset: 0xA0
	public string expAdditive; //Field offset: 0xA8
	public string modifiers; //Field offset: 0xB0
	public string expModifiers; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 159
	}

	public DamageModifierForModifiers() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

