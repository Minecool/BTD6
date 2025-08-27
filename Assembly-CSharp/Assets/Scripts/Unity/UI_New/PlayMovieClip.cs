namespace Assets.Scripts.Unity.UI_New;

public class PlayMovieClip : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <WaitForAnimationToEnd>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public PlayMovieClip <>4__this; //Field offset: 0x20
		private AnimatorStateInfo <animStateInfo>5__2; //Field offset: 0x28
		private int <stateHash>5__3; //Field offset: 0x4C

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
		public <WaitForAnimationToEnd>d__7(int <>1__state) { }

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

	private PlayMovieClipActionModel model; //Field offset: 0x20
	private Animator animator; //Field offset: 0x28
	private Action onEndAnimation; //Field offset: 0x30
	private bool forceResumeSimulation; //Field offset: 0x38

	public bool ForceResumeSimulation
	{
		 get { } //Length: 5
	}

	public PlayMovieClip() { }

	public bool get_ForceResumeSimulation() { }

	public void Initialise(PlayMovieClipActionModel model, Action onEndAnimation) { }

	private void ResumeSimulation() { }

	[IteratorStateMachine(typeof(<WaitForAnimationToEnd>d__7))]
	private IEnumerator WaitForAnimationToEnd() { }

}

