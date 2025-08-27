namespace Assets.Scripts.Unity.SimulationBehaviors;

public class CashRushGameMode : SimulationBehavior
{
	[CompilerGenerated]
	private sealed class <OnInitialiseGame>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CashRushGameMode <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <OnInitialiseGame>d__4(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public int cashGoal; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 86
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public CashRushGameMode() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator <>n__0() { }

	private void AddListeners() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

	public virtual void OnDestroyGame() { }

	[IteratorStateMachine(typeof(<OnInitialiseGame>d__4))]
	public virtual IEnumerator OnInitialiseGame() { }

}

