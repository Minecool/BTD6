namespace Assets.Scripts.Unity.SimulationBehaviors;

public class Behavior : IUIBehavior
{
	[CompilerGenerated]
	private sealed class <OnInitialiseGame>d__3 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <OnInitialiseGame>d__3(int <>1__state) { }

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

	[CompilerGenerated]
	private readonly string <Type>k__BackingField; //Field offset: 0x10

	public override string Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Behavior() { }

	[CompilerGenerated]
	public override string get_Type() { }

	public override void OnDestroyGame() { }

	[IteratorStateMachine(typeof(<OnInitialiseGame>d__3))]
	public override IEnumerator OnInitialiseGame() { }

	public override void OnResetQuestTriggered() { }

	public override void OnVictoryScreen() { }

}

