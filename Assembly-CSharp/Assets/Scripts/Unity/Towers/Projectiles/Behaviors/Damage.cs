namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class Damage : ProjectileBehavior
{
	public Damage parent; //Field offset: 0x88
	public float damage; //Field offset: 0x90
	public string expDamage; //Field offset: 0x98
	public float maxDamage; //Field offset: 0xA0
	public string expMaxDamage; //Field offset: 0xA8
	public string damageType; //Field offset: 0xB0
	public string expDamageType; //Field offset: 0xB8
	public string distributeToChildren; //Field offset: 0xC0
	public string expDistributeToChildren; //Field offset: 0xC8
	public string overrideDistributeBlocker; //Field offset: 0xD0
	public string expOverrideDistributeBlocker; //Field offset: 0xD8
	public bool createPopEffect; //Field offset: 0xE0
	public string expCreatePopEffect; //Field offset: 0xE8
	public string ignoreImmunityForBloonTypes; //Field offset: 0xF0
	public string expIgnoreImmunityForBloonTypes; //Field offset: 0xF8
	public bool ignoreImmunityDestroy; //Field offset: 0x100
	public string expIgnoreImmunityDestroy; //Field offset: 0x108
	public bool ignoreDamageMultipliers; //Field offset: 0x110
	public string expIgnoreDamageMultipliers; //Field offset: 0x118

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 559
	}

	public Damage() { }

	public Tower FindParentTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

