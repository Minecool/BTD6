namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RandomPosition : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__20 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public RandomPosition <>4__this; //Field offset: 0x68
		private int <startIndex>5__2; //Field offset: 0x70

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

	private const float leniency = 0.01; //Field offset: 0x0
	public RandomPositionModel randomPositionModel; //Field offset: 0x68
	public List<Vector3> possibleOffsets; //Field offset: 0x70
	public List<Vector3> inRangeUnblocked; //Field offset: 0x78
	public List<Vector3> inRangeBlocked; //Field offset: 0x80
	public List<Vector3> outOfRangeUnblocked; //Field offset: 0x88
	public List<Vector3> outOfRangeBlocked; //Field offset: 0x90
	private int index; //Field offset: 0x98
	private TowerModel towerModelBlocks; //Field offset: 0xA0
	private TowerModel towerModelDoesNotBlock; //Field offset: 0xA8
	public bool onlyUseTowerPosition; //Field offset: 0xB0
	public bool needsToCalcPositions; //Field offset: 0xB1
	public bool calcPositionsNextFrame; //Field offset: 0xB2
	private Int32[] randomSwapIndexes; //Field offset: 0xB8

	public RandomPosition() { }

	private void CalculatePossibleOffsets(int ringsToCalculate) { }

	public virtual bool CanHaveTarget() { }

	public void CheckPositions() { }

	public virtual string GetName() { }

	[IteratorStateMachine(typeof(<GetTargets>d__20))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnAreasChanged() { }

	protected virtual void OnDestroy() { }

	private void OnTowerCreated(Tower tower, TowerModel def, float upgradeCost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	private void OnTowerDestroyed(Tower tower) { }

	private void Process(int elapsed) { }

	private void Shuffle(List<T> list) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateValidPositions() { }

}

