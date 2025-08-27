namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(BananaPeelLimitProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BananaPeelLimitProjectileModel : WeaponBehaviorModel
{
	public string projectileId; //Field offset: 0x30
	public int bananasRequired; //Field offset: 0x38

	public BananaPeelLimitProjectileModel(string name, string projectileId, int bananasRequired) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

