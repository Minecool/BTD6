namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SpawnZombieOnBloonDestroyed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnZombieOnBloonDestroyedModel : ProjectileBehaviorModel
{
	public int graveyardManaCost; //Field offset: 0x38
	public ProjectileModel zombieProjectile; //Field offset: 0x40
	public SingleEmissionModel singleEmissionModel; //Field offset: 0x48

	public SpawnZombieOnBloonDestroyedModel(string name, int graveyardManaCost, ProjectileModel zombieProjectile) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

