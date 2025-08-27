namespace Assets.Scripts.Models.Towers.Projectiles;

[Implementation(typeof(Projectile), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileModel : Model
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <UpdateCollisionPassList>b__28_0(int x) { }

	}

	public PrefabReference display; //Field offset: 0x30
	public string id; //Field offset: 0x38
	public float maxPierce; //Field offset: 0x40
	public float pierce; //Field offset: 0x44
	public float scale; //Field offset: 0x48
	public bool ignoreBlockers; //Field offset: 0x4C
	public bool usePointCollisionWithBloons; //Field offset: 0x4D
	public bool canCollisionBeBlockedByMapLos; //Field offset: 0x4E
	[ExtendedDrawer]
	[SerializeReference]
	public FilterModel[] filters; //Field offset: 0x50
	[ExtendedDrawer]
	[SerializeReference]
	public Model[] behaviors; //Field offset: 0x58
	public Int32[] collisionPasses; //Field offset: 0x60
	public bool canCollideWithBloons; //Field offset: 0x68
	public float radius; //Field offset: 0x6C
	public float vsBlockerRadius; //Field offset: 0x70
	public bool hasDamageModifiers; //Field offset: 0x74
	public bool dontUseCollisionChecker; //Field offset: 0x75
	[SerializeField]
	private float checkCollisionInterval; //Field offset: 0x78
	public int checkCollisionIntervalFrames; //Field offset: 0x7C
	public bool ignoreNonTargetable; //Field offset: 0x80
	public bool ignorePierceExhaustion; //Field offset: 0x81
	public string saveId; //Field offset: 0x88
	public DisplayModel displayModel; //Field offset: 0x90

	public float CappedPierce
	{
		 get { } //Length: 30
	}

	public ProjectileModel(PrefabReference display, string id = "", float radius = 0.01, float vsBlockerRadius = 0.01, float pierce = 1, float maxPierce = -1, Model[] behaviors = null, FilterModel[] filters = null, bool ignoreBlockers = false, bool usePointCollisionWithBloons = false, bool canCollisionBeBlockedByMapLos = false, float scale = 1, Int32[] collisionPasses = null, bool dontUseCollisionChecker = false, float checkCollisionInterval = 0, bool ignoreNonTargetable = false, bool ignorePierceExhaustion = false, string saveId = null, DisplayModel displayModel = null) { }

	public virtual Model[] BehaviorModels() { }

	public float CapPierce(float _pierce) { }

	public virtual Model Clone() { }

	public float get_CappedPierce() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual void SetBehaviorModels(Model[] behaviors) { }

	public void UpdateCollisionPassList() { }

}

