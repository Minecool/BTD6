namespace Assets.Scripts.Simulation.Towers.Emissions.Behaviors;

public class AcidPoolEmission : EmissionBehavior
{
	public AcidPoolEmissionModel acidPoolEmissionModel; //Field offset: 0x68
	private int currentIndex; //Field offset: 0x70

	public AcidPoolEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual Projectile OnEmit(Projectile projectile, ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

