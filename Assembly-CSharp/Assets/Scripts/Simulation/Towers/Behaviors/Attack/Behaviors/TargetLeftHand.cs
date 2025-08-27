namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class TargetLeftHand : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__9 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public TargetLeftHand <>4__this; //Field offset: 0x68

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
		public <GetTargets>d__9(int <>1__state) { }

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

	public TargetLeftHandModel targetLeftHandModel; //Field offset: 0x68
	public TargetType targetType; //Field offset: 0x70
	private TargetRightHand rightHand; //Field offset: 0x88

	public TargetLeftHand() { }

	public virtual void Attatched() { }

	public virtual string GetName() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual Target GetTarget() { }

	[IteratorStateMachine(typeof(<GetTargets>d__9))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void GetTsmThemeInfo(out TSMInfoModel info, out string infoId) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTsmThemeAction(string themeId, string buttonId, object info) { }

	private void SetNextTargetType(bool prev = false) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private int WrapIndex(int index, int arrayLength) { }

}

