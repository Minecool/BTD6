namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(CreateProjectileOnPickup), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateProjectileOnPickupModel : ProjectileBehaviorModel
{
	[ExtendedDrawer]
	public ProjectileModel projectile; //Field offset: 0x38
	[ExtendedDrawer]
	public EmissionModel emission; //Field offset: 0x40
	public bool useRotation; //Field offset: 0x48
	public bool useTowerPosition; //Field offset: 0x49

	public CreateProjectileOnPickupModel(string name, ProjectileModel projectile, EmissionModel emission, bool useRotation, bool useTowerPosition) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

