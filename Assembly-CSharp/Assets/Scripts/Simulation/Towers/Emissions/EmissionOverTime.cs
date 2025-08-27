namespace Assets.Scripts.Simulation.Towers.Emissions;

public class EmissionOverTime : Emission
{
	public EmissionOverTimeModel emissionOverTimeModel; //Field offset: 0x70
	private int currCount; //Field offset: 0x78
	private int lastEmit; //Field offset: 0x7C
	private int timeFrames; //Field offset: 0x80
	private ProjectileModel projectileDef; //Field offset: 0x88
	private Vector3 ejectPoint; //Field offset: 0x90
	private Target target; //Field offset: 0xA0
	private Tower owner; //Field offset: 0xE8
	private Weapon weapon; //Field offset: 0xF0
	private AirUnit airUnit; //Field offset: 0xF8

	public EmissionOverTime() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

