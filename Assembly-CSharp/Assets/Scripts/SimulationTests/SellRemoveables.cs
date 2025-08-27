namespace Assets.Scripts.SimulationTests;

public class SellRemoveables : ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <Run>d__0 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimulationTestEnvironment env; //Field offset: 0x20
		private UnityToSimulation <bridge>5__2; //Field offset: 0x28
		private IEnumerator<Removeable> <>7__wrap2; //Field offset: 0x30

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
		public <Run>d__0(int <>1__state) { }

		private void <>m__Finally1() { }

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


	public SellRemoveables() { }

	[IteratorStateMachine(typeof(<Run>d__0))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

