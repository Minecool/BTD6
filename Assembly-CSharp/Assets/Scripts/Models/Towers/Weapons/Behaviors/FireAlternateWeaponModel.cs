namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(FireAlternateWeapon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FireAlternateWeaponModel : WeaponBehaviorModel
{
	public int weaponId; //Field offset: 0x30

	public FireAlternateWeaponModel(string name, int weaponId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

