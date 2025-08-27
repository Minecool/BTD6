namespace Assets.Scripts.Simulation.Towers.Emissions;

public class NecromancerEmission : Emission
{
	public NecromancerEmissionModel necromancerEmissionModel; //Field offset: 0x70
	public SimNecromancerGraveyardManager graveyardManager; //Field offset: 0x78
	public NecroRateMutator[] rateMutators; //Field offset: 0x80
	public Weapon weapon; //Field offset: 0x88
	private int currentDamageBonus; //Field offset: 0x90
	private NecromancerTargetTrackWithinRange targetProvider; //Field offset: 0x98
	private ObjectId towerId; //Field offset: 0xA0
	public int registeredNecroIdx; //Field offset: 0xA4
	private int mutatorMultiplierAmount; //Field offset: 0xA8
	private Path path; //Field offset: 0xB0
	private PathSegment pathSegment; //Field offset: 0xB8
	private Vector3 position; //Field offset: 0xC0
	private Vector3 offset; //Field offset: 0xCC
	private Projectile projectile; //Field offset: 0xD8
	private TransformBehavior transform; //Field offset: 0xE0

	public NecromancerEmission() { }

	public void CheckAfterChangingStoredRbe() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

