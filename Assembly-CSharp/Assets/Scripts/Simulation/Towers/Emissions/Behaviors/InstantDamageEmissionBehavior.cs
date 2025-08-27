namespace Assets.Scripts.Simulation.Towers.Emissions.Behaviors;

public class InstantDamageEmissionBehavior : EmissionBehavior
{
	public InstantDamageEmissionBehaviorModel modl; //Field offset: 0x68
	public Projectile proj; //Field offset: 0x70
	public Target target; //Field offset: 0x78
	public bool once; //Field offset: 0xC0

	public InstantDamageEmissionBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual Projectile OnEmit(Projectile projectile, ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

