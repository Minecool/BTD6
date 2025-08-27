namespace Assets.Scripts.Simulation.Towers.Emissions;

public class AdoraEmission : Emission
{
	public AdoraEmissionModel adoraEmissionModel; //Field offset: 0x70
	private int currentProjectileIndex; //Field offset: 0x78

	public AdoraEmission() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual Vector3 GetDirection(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

