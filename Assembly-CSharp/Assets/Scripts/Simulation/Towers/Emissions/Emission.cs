namespace Assets.Scripts.Simulation.Towers.Emissions;

public abstract class Emission : RootBehavior
{
	public EmissionModel emissionModel; //Field offset: 0x58
	private List<RootBehavior> createdBehaviors; //Field offset: 0x60
	private AirUnit airUnit; //Field offset: 0x68

	protected Emission() { }

	public Projectile BaseEmit(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, Projectile projectileFrom) { }

	public override void Emit(ProjectileModel def, Vector3 ejectPoint, Target collidedTarget, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public override Vector3 GetDirection(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public override void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public override void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

