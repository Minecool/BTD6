namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(ResetRateOnInitialise), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ResetRateOnInitialiseModel : WeaponBehaviorModel
{
	public WeaponModel weaponModel; //Field offset: 0x30

	public ResetRateOnInitialiseModel(string name, WeaponModel weaponModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

