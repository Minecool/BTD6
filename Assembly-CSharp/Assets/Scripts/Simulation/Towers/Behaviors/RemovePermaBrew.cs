namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RemovePermaBrew : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <SerializeObjectIds>d__8 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IList<ObjectId> objectIds; //Field offset: 0x28
		public IList<ObjectId> <>3__objectIds; //Field offset: 0x30
		private IEnumerator<ObjectId> <>7__wrap1; //Field offset: 0x38

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <SerializeObjectIds>d__8(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public RemovePermaBrewModel bModel; //Field offset: 0x68
	public List<ObjectId> affectedTowers; //Field offset: 0x70

	public RemovePermaBrew() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void OnExpire() { }

	public virtual void OnSold(float amount) { }

	private void RemoveBuffs() { }

	[IteratorStateMachine(typeof(<SerializeObjectIds>d__8))]
	private static IEnumerable<String> SerializeObjectIds(IList<ObjectId> objectIds) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

