namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack;

public class Attack : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PathSegmentInRange, Single> <>9__46_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <SetVisiblePathSegments>b__46_0(PathSegmentInRange bracket) { }

	}

	[CompilerGenerated]
	private sealed class <GetAdditionalDisplayMeshes>d__65 : IEnumerable<Mesh>, IEnumerable, IEnumerator<Mesh>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Mesh <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Attack <>4__this; //Field offset: 0x28
		private Vector3 position; //Field offset: 0x30
		public Vector3 <>3__position; //Field offset: 0x3C
		private TowerModel towerModel; //Field offset: 0x48
		public TowerModel <>3__towerModel; //Field offset: 0x50

		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.Current
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
		public <GetAdditionalDisplayMeshes>d__65(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Mesh> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Display.Mesh>.GetEnumerator() { }

		[DebuggerHidden]
		private override Mesh System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Display.Mesh>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetVisibleInRangePathSegments>d__32 : IEnumerable<PathSegment>, IEnumerable, IEnumerator<PathSegment>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private PathSegment <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Attack <>4__this; //Field offset: 0x28
		private TargetType targetType; //Field offset: 0x30
		public TargetType <>3__targetType; //Field offset: 0x48
		private Enumerator<PathSegmentInRange> <>7__wrap1; //Field offset: 0x60

		private override PathSegment System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Track.PathSegment>.Current
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
		public <GetVisibleInRangePathSegments>d__32(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<PathSegment> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Track.PathSegment>.GetEnumerator() { }

		[DebuggerHidden]
		private override PathSegment System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Track.PathSegment>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetVisibleTargets>d__31 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public Attack <>4__this; //Field offset: 0x68
		private TargetType targetType; //Field offset: 0x70
		public TargetType <>3__targetType; //Field offset: 0x88
		private Enumerator<Target> <>7__wrap1; //Field offset: 0xA0

		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 45
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 107
		}

		[DebuggerHidden]
		public <GetVisibleTargets>d__31(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Target> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Towers.Target>.GetEnumerator() { }

		[DebuggerHidden]
		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public AttackModel attackModel; //Field offset: 0x68
	private List<RootBehavior> createdBehaviors; //Field offset: 0x70
	public List<AttackBehavior> attackBehaviors; //Field offset: 0x78
	private List<PathSegmentInRange> visiblePathSegmentsUnordered; //Field offset: 0x80
	private Dictionary<String, List`1<PathSegmentInRange>> visiblePathSegments; //Field offset: 0x88
	private TargetSupplier activeTargetSupplier; //Field offset: 0x90
	private bool isThrowCacheInitialised; //Field offset: 0x98
	public float range; //Field offset: 0x9C
	private bool onlyTargetsMoab; //Field offset: 0xA0
	private bool cantTargetMoab; //Field offset: 0xA1
	private bool cantTargetCamo; //Field offset: 0xA2
	public bool usingSharedRange; //Field offset: 0xA3
	public bool useOnTheMoveTargetting; //Field offset: 0xA4
	private bool newTarget; //Field offset: 0xA5
	private int targetLastClearedTime; //Field offset: 0xA8
	private Target frameTarget; //Field offset: 0xB0
	private BloonFilter filterTarget; //Field offset: 0xF8
	private List<PathSegmentInRange> segsReturn; //Field offset: 0x100
	private Vector2 compareClosePosition; //Field offset: 0x108

	public bool CantTargetCamo
	{
		 get { } //Length: 8
	}

	public bool CantTargetMoab
	{
		 get { } //Length: 8
	}

	public Target target
	{
		 get { } //Length: 60
	}

	public Attack() { }

	[CompilerGenerated]
	private float <SetVisiblePathSegments>b__46_1(PathSegmentInRange bracket) { }

	private bool CalcCantTargetCamo() { }

	private bool CalcCantTargetMoab() { }

	private bool CalcOnlyTargetsMoab() { }

	public override bool CanHaveTarget() { }

	public override Vector3 CheckFromOffset() { }

	public bool CheckIfCreatedBehaviorExists() { }

	public override float CheckOffsetRadius() { }

	public void ClearTarget(bool bypassCooldown = false) { }

	private int CompareBracketClose(PathSegmentInRange a, PathSegmentInRange b) { }

	private int CompareBracketFar(PathSegmentInRange a, PathSegmentInRange b) { }

	private int CompareBracketFirst(PathSegmentInRange a, PathSegmentInRange b) { }

	private int CompareBracketLast(PathSegmentInRange a, PathSegmentInRange b) { }

	public bool FilterTarget(Bloon bloon) { }

	public bool FilterTargetWithLineOfSight(Bloon bloon) { }

	public void FindTarget() { }

	public bool get_CantTargetCamo() { }

	public bool get_CantTargetMoab() { }

	public Target get_target() { }

	public TargetSupplier GetActiveTargetSupplier() { }

	[IteratorStateMachine(typeof(<GetAdditionalDisplayMeshes>d__65))]
	public virtual IEnumerable<Mesh> GetAdditionalDisplayMeshes(TowerModel towerModel, Vector3 position, bool isFromHover) { }

	public List<PathSegmentInRange> GetPathSegmentsInRange(float rangeToUse) { }

	public List<PathSegmentInRange> GetPathSegmentsInRangeFast(float rangeToUse, TargetType targetType) { }

	public Target GetTarget() { }

	public IEnumerable<Target> GetTargets() { }

	public PathSegment GetVisibleInRangePathSegment(TargetType targetType) { }

	[IteratorStateMachine(typeof(<GetVisibleInRangePathSegments>d__32))]
	public IEnumerable<PathSegment> GetVisibleInRangePathSegments(TargetType targetType) { }

	public Target GetVisibleTarget(TargetType targetType) { }

	[IteratorStateMachine(typeof(<GetVisibleTargets>d__31))]
	public IEnumerable<Target> GetVisibleTargets(TargetType targetType) { }

	public bool HasValidTarget() { }

	public virtual void Initialise(Entity targetLocal, Model modelToUse) { }

	public void InitTargetPathSegments() { }

	public void OnAnimationReadyForFire() { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	public virtual void OnPreChangeTargetPriority(TargetType targetType) { }

	public void SetActiveTargetSupplier(TargetType targetType) { }

	public void SetOnTheMoveTargetting(bool val) { }

	public virtual void SetTarget(Target target) { }

	public void SetUpAttack() { }

	public void SetVisiblePathSegments(List<PathSegmentInRange> visiblePathSegmentsToUse) { }

	private void UpdateActiveTargetSupplier() { }

	private void UpdateBehaviors() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateRange() { }

	public void UpdateThrowCache() { }

}

