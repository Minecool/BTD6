namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetSelectedPoint : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__20 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public TargetSelectedPoint <>4__this; //Field offset: 0x68

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
		public <GetTargets>d__20(int <>1__state) { }

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

	public TargetSelectedPointModel targetSelectedPointModel; //Field offset: 0x68
	public Vector3 targetPoint; //Field offset: 0x70
	private Entity targetImg; //Field offset: 0x80
	private bool hasValidPoint; //Field offset: 0x88
	private bool findPathSegment; //Field offset: 0x89
	private Projectile pendingProjectileToDestroy; //Field offset: 0x90
	private bool assignWeaponToProjectile; //Field offset: 0x98
	private bool checkPendingProjectileToDestroy; //Field offset: 0x99

	public bool HasValidPoint
	{
		 get { } //Length: 8
	}

	public TargetSelectedPoint() { }

	public virtual void ApplyTargetTypeData(Vector2 data) { }

	public virtual bool CanHaveTarget() { }

	private void DestroyProjectile(Projectile projectile) { }

	public bool get_HasValidPoint() { }

	public virtual string GetName() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	[IteratorStateMachine(typeof(<GetTargets>d__20))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual object GetTargetTypeCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsPointInRangeOfAttack(Vector2 targetPoint) { }

	protected virtual void OnDestroy() { }

	private void OnSelectionChanged(ISelectable selected) { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void SetTargetPosition(Vector3 position, bool ignorePlacementValidity = false) { }

	public void StartDraw(bool redraw = true) { }

	private void StopDraw() { }

	public virtual void ThrowCacheUpdated() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

