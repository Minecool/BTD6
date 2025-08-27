namespace Assets.Scripts.SimulationTests;

public class GiveAllArtifacts : ISimulationTestStep
{
	[CompilerGenerated]
	private sealed class <Run>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GiveAllArtifacts <>4__this; //Field offset: 0x20
		public SimulationTestEnvironment env; //Field offset: 0x28

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
		public <Run>d__4(int <>1__state) { }

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

	internal enum ArtifactType
	{
		Item = 0,
		Boost = 1,
	}

	[SerializeField]
	private ArtifactType artifactType; //Field offset: 0x10
	[Range(0, 2)]
	[SerializeField]
	private int tier; //Field offset: 0x14

	public GiveAllArtifacts(ArtifactType artifactType, int tier) { }

	[IteratorStateMachine(typeof(<Run>d__4))]
	public override IEnumerator Run(SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

}

