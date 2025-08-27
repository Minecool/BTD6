namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetSelectedPointOrDefault : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Single> <>9__27_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal float <GetDefaultTarget>b__27_1(Bloon bloon) { }

	}

	[CompilerGenerated]
	private sealed class <GetTargets>d__26 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public TargetSelectedPointOrDefault <>4__this; //Field offset: 0x68
		private Bloon <bloon>5__2; //Field offset: 0x70

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
		public <GetTargets>d__26(int <>1__state) { }

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

	public TargetSelectedPointOrDefaultModel targetSelectedPointOrDefaultModel; //Field offset: 0x68
	public Vector3 targetPoint; //Field offset: 0x70
	private Entity targetImg; //Field offset: 0x80
	private bool hasValidPoint; //Field offset: 0x88
	private bool findPathSegment; //Field offset: 0x89
	private Projectile pendingProjectileToDestroy; //Field offset: 0x90
	private bool assignWeaponToProjectile; //Field offset: 0x98
	private bool checkPendingProjectileToDestroy; //Field offset: 0x99
	private bool selectTargetModeActive; //Field offset: 0x9A
	private int lastSwapAt; //Field offset: 0x9C
	private TSMInfoModel newInfo; //Field offset: 0xA0
	private Nullable<Vector3> previousBloonPosition; //Field offset: 0xA8

	public bool HasValidPoint
	{
		 get { } //Length: 8
	}

	public TargetSelectedPointOrDefault() { }

	[CompilerGenerated]
	private bool <GetDefaultTarget>b__27_0(Bloon bloon) { }

	[CompilerGenerated]
	private bool <GetDefaultTarget>b__27_2(Bloon bloon) { }

	public virtual void ApplyTargetTypeData(Vector2 data) { }

	public virtual bool CanHaveTarget() { }

	private void DestroyProjectile(Projectile projectile) { }

	public bool get_HasValidPoint() { }

	private Bloon GetDefaultTarget() { }

	public virtual string GetName() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	[IteratorStateMachine(typeof(<GetTargets>d__26))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual object GetTargetTypeCustomInputData() { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsPointInRangeOfAttack(Vector2 targetPoint) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void SetTargetPosition(Vector3 position, bool ignorePlacementValidity = false) { }

	public void StartDraw(bool redraw = true) { }

	private void StopDraw() { }

	public virtual void ThrowCacheUpdated() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

