namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class BonusProjectileAfterInterval : WeaponBehavior
{
	public BonusProjectileAfterInterval parent; //Field offset: 0x90
	public int interval; //Field offset: 0x98
	public string expInterval; //Field offset: 0xA0
	public Projectile projectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public bool useTowerPosition; //Field offset: 0xB8
	public string expUseTowerPosition; //Field offset: 0xC0
	public float cooldown; //Field offset: 0xC8
	public string expCooldown; //Field offset: 0xD0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 250
	}

	public BonusProjectileAfterInterval() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

