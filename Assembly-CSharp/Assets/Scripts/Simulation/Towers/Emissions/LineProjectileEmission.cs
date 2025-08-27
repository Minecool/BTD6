namespace Assets.Scripts.Simulation.Towers.Emissions;

public class LineProjectileEmission : Emission
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Vector3 ejectPoint; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal float <Emit>b__0(Bloon b) { }

	}

	public LineProjectileEmissionModel lineProjectileEmissionModel; //Field offset: 0x70
	private Entity effectAtEnd; //Field offset: 0x78
	private Entity effectAtStart; //Field offset: 0x80
	private int endEffectLastUpdated; //Field offset: 0x88
	private float currentMagnitude; //Field offset: 0x8C
	private float targetMagnitude; //Field offset: 0x90
	private Emission emissionAtEnd; //Field offset: 0x98
	private Weapon weapon; //Field offset: 0xA0
	private bool showEndEffect; //Field offset: 0xA8
	private readonly List<Vector3> collisionPositions; //Field offset: 0xB0

	public float CurrentMagnitude
	{
		 get { } //Length: 9
	}

	public bool ShowEndEffect
	{
		 get { } //Length: 8
	}

	public Weapon Weapon
	{
		 get { } //Length: 8
	}

	public LineProjectileEmission() { }

	public virtual void Emit(ProjectileModel projectileDef, Vector3 ejectPoint, Target target, int elapsed, Tower owner, Weapon weapon, List<Projectile> created, bool doubleShot = false, List<ObjectId> collidedWith = null) { }

	public float get_CurrentMagnitude() { }

	public bool get_ShowEndEffect() { }

	public Weapon get_Weapon() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

