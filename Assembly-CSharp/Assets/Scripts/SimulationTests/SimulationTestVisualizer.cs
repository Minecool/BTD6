namespace Assets.Scripts.SimulationTests;

public class SimulationTestVisualizer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DebugRender>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimulationTestEnvironment env; //Field offset: 0x20

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
		public <DebugRender>d__8(int <>1__state) { }

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
	private sealed class <Start>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public SimulationTestVisualizer <>4__this; //Field offset: 0x20
		private SimulationTest <test>5__2; //Field offset: 0x28
		private Task<SimulationTestEnvironment> <loadEnvTask>5__3; //Field offset: 0x30
		private SimulationTestBlackboard <blackboard>5__4; //Field offset: 0x38
		private Coroutine <debugRender>5__5; //Field offset: 0x40
		private ISimulationTestStep[] <>7__wrap5; //Field offset: 0x48
		private int <>7__wrap6; //Field offset: 0x50

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
		public <Start>d__7(int <>1__state) { }

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

	[SerializeField]
	private LocalizationManager locManager; //Field offset: 0x20
	[SerializeField]
	private GameData gameData; //Field offset: 0x28
	[SerializeField]
	private SimulationTest toTest; //Field offset: 0x30
	[SerializeField]
	[TextArea]
	private string toTestJson; //Field offset: 0x38
	[Range(0, 10000)]
	[SerializeField]
	private int testSpeed; //Field offset: 0x40
	private SimulationTestEnvironment environment; //Field offset: 0x48

	public SimulationTestVisualizer() { }

	[IteratorStateMachine(typeof(<DebugRender>d__8))]
	private static IEnumerator DebugRender(SimulationTestEnvironment env) { }

	private SimulationTest GetTest() { }

	private void OnDestroy() { }

	private void OnValidate() { }

	[IteratorStateMachine(typeof(<Start>d__7))]
	private IEnumerator Start() { }

}

