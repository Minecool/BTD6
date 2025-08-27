namespace Assets.Scripts.Simulation.Towers.Emissions;

public class InstantDamageEmission : Emission
{
	public InstantDamageEmissionModel instantDamageEmissionModel; //Field offset: 0x70
	private Projectile proj; //Field offset: 0x78
	private Target target; //Field offset: 0x80
	private bool once; //Field offset: 0xC8

	public InstantDamageEmission() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public override void SetTarget(Target target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

