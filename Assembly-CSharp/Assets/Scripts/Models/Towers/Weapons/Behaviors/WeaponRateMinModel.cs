namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(WeaponRateMin), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WeaponRateMinModel : WeaponBehaviorModel
{
	public float min; //Field offset: 0x30

	public WeaponRateMinModel(string name, float min) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

