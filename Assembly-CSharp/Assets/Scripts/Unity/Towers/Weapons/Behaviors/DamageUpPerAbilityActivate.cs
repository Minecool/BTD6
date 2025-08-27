namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class DamageUpPerAbilityActivate : WeaponBehavior
{
	public DamageUpPerAbilityActivate parent; //Field offset: 0x90
	public string abilityName; //Field offset: 0x98
	public string expAbilityName; //Field offset: 0xA0
	public float percentPerAbility; //Field offset: 0xA8
	public string expPercentPerAbility; //Field offset: 0xB0
	public int activationMax; //Field offset: 0xB8
	public string expActivationMax; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public DamageUpPerAbilityActivate() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

