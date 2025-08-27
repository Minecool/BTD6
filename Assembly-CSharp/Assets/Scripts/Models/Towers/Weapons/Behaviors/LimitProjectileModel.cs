namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(LimitProjectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LimitProjectileModel : WeaponBehaviorModel
{
	public string projectileId; //Field offset: 0x30
	public int limit; //Field offset: 0x38
	public int delayInFrames; //Field offset: 0x3C
	public bool limitByDestroyedPriorProjectile; //Field offset: 0x40
	public bool globalForPlayer; //Field offset: 0x41

	public LimitProjectileModel(string name, string projectileId, int limit, int delayInFrames, bool limitByDestroyedPriorProjectile, bool globalForPlayer) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

