namespace Assets.Scripts.Simulation.Towers.Emissions;

public class PrinceOfDarknessEmission : Emission
{
	public PrinceOfDarknessEmissionModel princeOfDarknessEmissionModel; //Field offset: 0x70
	public Weapon weapon; //Field offset: 0x78
	private SimNecromancerGraveyardManager graveyardManager; //Field offset: 0x80
	private Path path; //Field offset: 0x88
	private PathSegment pathSegment; //Field offset: 0x90
	private Vector3 position; //Field offset: 0x98
	private Vector3 offset; //Field offset: 0xA4
	private Projectile projectile; //Field offset: 0xB0
	private TransformBehavior transform; //Field offset: 0xB8
	private NecromancerEmission _necromancerEmission; //Field offset: 0xC0

	public private NecromancerEmission NecromancerEmission
	{
		 get { } //Length: 106
		private set { } //Length: 8
	}

	public PrinceOfDarknessEmission() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public NecromancerEmission get_NecromancerEmission() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void set_NecromancerEmission(NecromancerEmission value) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

