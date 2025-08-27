namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(FireWhenAlternateWeaponIsReady), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FireWhenAlternateWeaponIsReadyModel : WeaponBehaviorModel
{
	public int weaponId; //Field offset: 0x30

	public FireWhenAlternateWeaponIsReadyModel(string name, int weaponId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

