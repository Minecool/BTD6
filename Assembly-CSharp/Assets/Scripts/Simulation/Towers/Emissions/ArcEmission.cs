namespace Assets.Scripts.Simulation.Towers.Emissions;

public class ArcEmission : Emission
{
	public ArcEmissionModel arcEmissionModel; //Field offset: 0x70
	private int count; //Field offset: 0x78

	public int Count
	{
		 get { } //Length: 4
	}

	public ArcEmission() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public int get_Count() { }

	public virtual Vector3 GetDirection(ProjectileModel def, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

