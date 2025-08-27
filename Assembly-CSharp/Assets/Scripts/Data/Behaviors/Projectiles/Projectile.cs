namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "Projectile", menuName = "BTD6/Behaviors/Projectile Asset", order = 1)]
public class Projectile : EntityBehavior<ProjectileModel>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GatherCollisionPasses>b__20_0(int x) { }

	}

	public PrefabReference display; //Field offset: 0x28
	public float pierce; //Field offset: 0x30
	public float maxPierce; //Field offset: 0x34
	public float radius; //Field offset: 0x38
	public float vsBlockerRadius; //Field offset: 0x3C
	public bool ignoreBlockers; //Field offset: 0x40
	public bool usePointCollisionWithBloons; //Field offset: 0x41
	public bool canCollisionBeBlockedByMapLos; //Field offset: 0x42
	public bool dontUseCollisionChecker; //Field offset: 0x43
	public float checkCollisionInterval; //Field offset: 0x44
	public bool ignoreInvulnerable; //Field offset: 0x48
	public bool ignorePierceExhaustion; //Field offset: 0x49
	public string saveId; //Field offset: 0x50
	public Filter[] filters; //Field offset: 0x58
	[JsonConverter(typeof(BehaviorConverter))]
	public Behavior[] behaviors; //Field offset: 0x60
	[JsonConverter(typeof(BehaviorConverter))]
	public Display displayBehavior; //Field offset: 0x68

	public virtual ProjectileModel Def
	{
		 get { } //Length: 617
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public Projectile() { }

	private Int32[] GatherCollisionPasses(Behavior[] behaviors) { }

	private List<ProjectileBehavior> GatherProjectileBehaviors(Behavior[] behaviors) { }

	public virtual ProjectileModel get_Def() { }

	public virtual Model get_Model() { }

	private List<ProjectileBehavior> StripDotModifiers(List<ProjectileBehavior> projectileBehaviors) { }

}

