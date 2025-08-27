namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ScaleDamageWithTime : DamageModifier
{
	public float maxDamage; //Field offset: 0x88
	public string expMaxDamage; //Field offset: 0x90
	public float damageIncreasePerSecond; //Field offset: 0x98
	public string expDamageIncreasePerSecond; //Field offset: 0xA0
	public float baseDamage; //Field offset: 0xA8
	public string expBaseDamage; //Field offset: 0xB0

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 198
	}

	public ScaleDamageWithTime() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

