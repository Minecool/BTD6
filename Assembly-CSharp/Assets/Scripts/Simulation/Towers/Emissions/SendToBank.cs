namespace Assets.Scripts.Simulation.Towers.Emissions;

public class SendToBank : Emission
{
	public SendToBankModel sendToBankModel; //Field offset: 0x70

	public SendToBank() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target collidedTarget, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

