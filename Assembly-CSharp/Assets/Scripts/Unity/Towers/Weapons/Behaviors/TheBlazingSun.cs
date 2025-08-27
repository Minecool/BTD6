namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class TheBlazingSun : WeaponBehavior
{
	public TheBlazingSun parent; //Field offset: 0x90
	public int maxStacks; //Field offset: 0x98
	public string expMaxStacks; //Field offset: 0xA0
	public int stacksToBurn; //Field offset: 0xA8
	public string expStacksToBurn; //Field offset: 0xB0
	public AddBehaviorToBloon burnBehavior; //Field offset: 0xB8
	public AddBehaviorToBloon expBurnBehavior; //Field offset: 0xC0
	public float attackSpeedPerStack; //Field offset: 0xC8
	public string expAttackSpeedPerStack; //Field offset: 0xD0
	public float debuffExpiresAfter; //Field offset: 0xD8
	public string expDebuffExpiresAfter; //Field offset: 0xE0
	public Projectile burnBehaviorArea; //Field offset: 0xE8
	public Projectile expBurnBehaviorArea; //Field offset: 0xF0
	public Effect ejectEffect; //Field offset: 0xF8
	public Effect expEjectEffect; //Field offset: 0x100
	public Effect ejectEffectOverheat; //Field offset: 0x108
	public Effect expEjectEffectOverheat; //Field offset: 0x110

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 534
	}

	public TheBlazingSun() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

