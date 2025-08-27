namespace Assets.Scripts.Simulation.Towers.Emissions;

public class RandomEmission : Emission
{
	public RandomEmissionModel randomEmissionModel; //Field offset: 0x70
	private Projectile projectile; //Field offset: 0x78
	private Attack mainAttack; //Field offset: 0x80

	public RandomEmission() { }

	private void DebugProcess(int elapsed) { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target collidedTarget, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

