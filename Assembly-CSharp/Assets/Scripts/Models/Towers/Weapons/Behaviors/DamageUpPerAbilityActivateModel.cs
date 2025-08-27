namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(DamageUpPerAbilityActivate), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageUpPerAbilityActivateModel : WeaponBehaviorModel
{
	public string abilityName; //Field offset: 0x30
	public float percentPerAbility; //Field offset: 0x38
	public int activationMax; //Field offset: 0x3C

	public DamageUpPerAbilityActivateModel(string name, string abilityName, float percentPerAbility, int activationMax) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

