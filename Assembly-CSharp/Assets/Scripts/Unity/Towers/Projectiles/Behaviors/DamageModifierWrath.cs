namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class DamageModifierWrath : DamageModifier
{
	public DamageModifierWrath parent; //Field offset: 0x88
	public int rbeThreshold; //Field offset: 0x90
	public string expRbeThreshold; //Field offset: 0x98
	public int damage; //Field offset: 0xA0
	public string expDamage; //Field offset: 0xA8
	public int maxDamageBoost; //Field offset: 0xB0
	public string expMaxDamageBoost; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 154
	}

	public DamageModifierWrath() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

