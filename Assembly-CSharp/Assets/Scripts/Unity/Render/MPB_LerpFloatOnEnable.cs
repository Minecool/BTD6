namespace Assets.Scripts.Unity.Render;

[RequireComponent(typeof(Renderer))]
public class MPB_LerpFloatOnEnable : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <LerpProperty>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MPB_LerpFloatOnEnable <>4__this; //Field offset: 0x20
		public float from; //Field offset: 0x28
		public float to; //Field offset: 0x2C
		private MaterialPropertyBlock <mpb>5__2; //Field offset: 0x30
		private float <timeElapsed>5__3; //Field offset: 0x38

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
		public <LerpProperty>d__11(int <>1__state) { }

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
	private string property; //Field offset: 0x20
	[SerializeField]
	private float duration; //Field offset: 0x28
	[SerializeField]
	private bool playOnEnable; //Field offset: 0x2C
	private Renderer _renderer; //Field offset: 0x30
	private int propertyId; //Field offset: 0x38
	private Coroutine lerpCoroutine; //Field offset: 0x40

	public MPB_LerpFloatOnEnable() { }

	public void Activate() { }

	public void Deactivate() { }

	[IteratorStateMachine(typeof(<LerpProperty>d__11))]
	private IEnumerator LerpProperty(float from, float to) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void TryLerp() { }

}

