namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class ScaleProjectile : ProjectileBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector3, Single> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <get_Def>b__8_0(Vector3 p) { }

	}

	public ScaleProjectile parent; //Field offset: 0x88
	public int numSamples; //Field offset: 0x90
	public string expNumSamples; //Field offset: 0x98
	public AnimCurve scaleCurve; //Field offset: 0xA0
	public AnimCurve expScaleCurve; //Field offset: 0xA8
	public PointSource scale; //Field offset: 0xB0
	public PointSource expScale; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 608
	}

	public ScaleProjectile() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

