namespace Assets.Scripts.Simulation.Bloons;

public class BloonManager : RootBehavior
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__17 : IEnumerable<Bloon>, IEnumerable, IEnumerator<Bloon>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Bloon <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private int count; //Field offset: 0x24
		public int <>3__count; //Field offset: 0x28
		public BloonManager <>4__this; //Field offset: 0x30
		private bool cantTargetMoab; //Field offset: 0x38
		public bool <>3__cantTargetMoab; //Field offset: 0x39
		private bool cantTargetCamo; //Field offset: 0x3A
		public bool <>3__cantTargetCamo; //Field offset: 0x3B
		private bool onlyTargetsMoab; //Field offset: 0x3C
		public bool <>3__onlyTargetsMoab; //Field offset: 0x3D
		private float range; //Field offset: 0x40
		public float <>3__range; //Field offset: 0x44
		private Vector3 position; //Field offset: 0x48
		public Vector3 <>3__position; //Field offset: 0x54
		private TargetType targetType; //Field offset: 0x60
		public TargetType <>3__targetType; //Field offset: 0x78
		private BloonFilter filter; //Field offset: 0x90
		public BloonFilter <>3__filter; //Field offset: 0x98
		private Enumerator<Target> <>7__wrap1; //Field offset: 0xA0

		private override Bloon System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Bloons.Bloon>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetTargets>d__17(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Bloon> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Bloons.Bloon>.GetEnumerator() { }

		[DebuggerHidden]
		private override Bloon System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Bloons.Bloon>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class BloonFilter : MulticastDelegate
	{

		public BloonFilter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Bloon bloon, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(Bloon bloon) { }

	}

	public static readonly HashSet<String> mutatorRemovalExceptions; //Field offset: 0x0
	public BloonDegradeStepper bloonDegradeStepper; //Field offset: 0x58
	private int lastBloonCountUpdateFrame; //Field offset: 0x60
	public int activeBloonCount; //Field offset: 0x64
	private float lastCachedRbe; //Field offset: 0x68
	private readonly Dictionary<String, Int32> bloonBaseIdCounts; //Field offset: 0x70
	private List<PathSegmentInRange> brackets; //Field offset: 0x78
	private Vector2 compareClosePosition; //Field offset: 0x80

	private static BloonManager() { }

	public BloonManager() { }

	public void BloonDamage(Projectile projectile, long damage, Bloon bloon, Tower emittedBy) { }

	public void BloonDegrade(Projectile projectile, Bloon bloon, Tower emittedBy, DamageResult damageResult) { }

	public void BloonDestroy(Projectile projectile, Bloon bloon, Tower emittedBy, DamageResult damageResult) { }

	public void BloonLeak(Bloon bloon, float livesBefore, float livesAfter, float shieldBefore, float shieldAfter) { }

	public void BloonSpawned(Bloon bloon) { }

	private int CompareBracketClose(PathSegmentInRange a, PathSegmentInRange b) { }

	private int CompareBracketFirst(PathSegmentInRange a, PathSegmentInRange b) { }

	private int CompareBracketLast(PathSegmentInRange a, PathSegmentInRange b) { }

	public bool DoesTagExistOnMoabs(string tag) { }

	public Bloon GetBloonByID(ObjectId id) { }

	public Bloon GetBloonByIdLastSave(ObjectId id) { }

	public int GetBloonCountByBaseId(string baseId) { }

	private Bloon GetClosestTarget(float range, Vector3 position, BloonFilter filter = null, bool cantTargetMoab = false, bool cantTargetCamo = false, bool onlyTargetsMoab = false) { }

	public Bloon GetGlobalBest(Vector3 position, float range, TargetType targetType, BloonFilter filter = null, bool cantTargetMoab = false, bool cantTargetCamo = false) { }

	public float GetProportionOfTotalBloonCountByBaseId(string baseId) { }

	public Bloon GetTarget(float range, TargetType targetType, Vector3 position, BloonFilter filter = null, bool cantTargetMoab = false, bool cantTargetCamo = false, bool onlyTargetsMoab = false) { }

	[IteratorStateMachine(typeof(<GetTargets>d__17))]
	public IEnumerable<Bloon> GetTargets(float range, TargetType targetType, Vector3 position, int count, BloonFilter filter = null, bool cantTargetMoab = false, bool cantTargetCamo = false, bool onlyTargetsMoab = false) { }

	public float GetTotalRbeOfActiveBloons() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsMutatorIgnoredForRemoval(string mutatorId) { }

	private void UpdateBaseIdCount(BloonModel bloonModel) { }

	private void UpdateBloonCounts() { }

	private void UpdateTotalRbe(BloonModel bloonModel) { }

}

