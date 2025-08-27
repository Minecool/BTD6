namespace Assets.Scripts.Simulation.Towers.Emissions;

public class EmitFromSharedTowers : Emission
{
	public EmitFromSharedTowersModel emitFromSharedTowersModel; //Field offset: 0x70

	public EmitFromSharedTowers() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

