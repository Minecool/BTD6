namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(Orbit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OrbitModel : TowerBehaviorModel
{
	public ProjectileModel projectile; //Field offset: 0x30
	public int count; //Field offset: 0x38
	public float range; //Field offset: 0x3C

	public OrbitModel(string name, ProjectileModel projectile, int count, float range) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

