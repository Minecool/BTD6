namespace Assets.Scripts.Unity.Display;

public class QualityPurgeStopAtTime : QualityPurge
{
	[CompilerGenerated]
	private sealed class <GoToAnimationTime>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public QualityPurgeStopAtTime <>4__this; //Field offset: 0x20

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
		public <GoToAnimationTime>d__5(int <>1__state) { }

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

	public Animator animator; //Field offset: 0x30
	public string stateName; //Field offset: 0x38
	public float stopAtTime; //Field offset: 0x40
	public bool hasBeenDisabled; //Field offset: 0x44

	public QualityPurgeStopAtTime() { }

	[IteratorStateMachine(typeof(<GoToAnimationTime>d__5))]
	private IEnumerator GoToAnimationTime() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public virtual void Purge() { }

}

