namespace Assets.Scripts.Simulation.Towers.Emmisions;

public class SingleEmissionDisplayOffset : Emission
{
	public SingleEmissionDisplayOffsetModel singleEmissionDisplayOffsetModel; //Field offset: 0x70
	public DisplayBehavior displayBehavior; //Field offset: 0x78
	public DisplayNode node; //Field offset: 0x80
	public float offsetRotation; //Field offset: 0x88

	public SingleEmissionDisplayOffset() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

