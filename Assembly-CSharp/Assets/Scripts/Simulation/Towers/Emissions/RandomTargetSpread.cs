namespace Assets.Scripts.Simulation.Towers.Emissions;

public class RandomTargetSpread : Emission
{
	public RandomTargetSpreadModel randomTargetSpreadModel; //Field offset: 0x70
	public Vector3 currentEjectOffset; //Field offset: 0x78
	public int projectileCount; //Field offset: 0x84
	private bool changedThisFrame; //Field offset: 0x88

	public RandomTargetSpread() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

