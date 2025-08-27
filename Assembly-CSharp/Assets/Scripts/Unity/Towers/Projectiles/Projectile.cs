namespace Assets.Scripts.Unity.Towers.Projectiles;

public class Projectile : CascadingItemProxy
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__29_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <get_Def>b__29_0(int x) { }

	}

	public Projectile parent; //Field offset: 0x88
	public GameObject display; //Field offset: 0x90
	public GameObject expDisplay; //Field offset: 0x98
	public float pierce; //Field offset: 0xA0
	public string expPierce; //Field offset: 0xA8
	public float maxPierce; //Field offset: 0xB0
	public string expMaxPierce; //Field offset: 0xB8
	public float radius; //Field offset: 0xC0
	public string expRadius; //Field offset: 0xC8
	public float vsBlockerRadius; //Field offset: 0xD0
	public string expVsBlockerRadius; //Field offset: 0xD8
	public bool ignoreBlockers; //Field offset: 0xE0
	public string expIgnoreBlockers; //Field offset: 0xE8
	public bool usePointCollisionWithBloons; //Field offset: 0xF0
	public string expUsePointCollisionWithBloons; //Field offset: 0xF8
	public bool canCollisionBeBlockedByMapLos; //Field offset: 0x100
	public string expCanCollisionBeBlockedByMapLos; //Field offset: 0x108
	public bool dontUseCollisionChecker; //Field offset: 0x110
	public string expDontUseCollisionChecker; //Field offset: 0x118
	public float checkCollisionInterval; //Field offset: 0x120
	public string expCheckCollisionInterval; //Field offset: 0x128
	public bool ignoreInvulnerable; //Field offset: 0x130
	public string expIgnoreInvulnerable; //Field offset: 0x138
	public bool ignorePierceExhaustion; //Field offset: 0x140
	public string expIgnorePierceExhaustion; //Field offset: 0x148
	public string saveId; //Field offset: 0x150
	public string expSaveId; //Field offset: 0x158
	private ProjectileModel def; //Field offset: 0x160

	public ProjectileModel Def
	{
		 get { } //Length: 1687
	}

	public virtual Model Model
	{
		 get { } //Length: 7
	}

	public Projectile() { }

	public ProjectileModel get_Def() { }

	public virtual Model get_Model() { }

	private ProjectileBehavior[] StripDotModifiers(ProjectileBehavior[] projectileBehaviors) { }

}

