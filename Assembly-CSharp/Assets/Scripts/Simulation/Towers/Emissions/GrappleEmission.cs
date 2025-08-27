namespace Assets.Scripts.Simulation.Towers.Emissions;

public class GrappleEmission : Emission
{
	public GrappleEmissionModel grappleEmissionModel; //Field offset: 0x70
	private GrappleTagMutator grappleTagMutator; //Field offset: 0x78

	public GrappleEmission() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

