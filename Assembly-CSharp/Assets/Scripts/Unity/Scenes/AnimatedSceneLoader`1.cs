namespace Assets.Scripts.Unity.Scenes;

public class AnimatedSceneLoader
{
	[CompilerGenerated]
	private sealed class <Load>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public AnimatedSceneLoader<T> <>4__this; //Field offset: 0x0

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
		public <Load>d__7(int <>1__state) { }

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
	private sealed class <Unload>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public AnimatedSceneLoader<T> <>4__this; //Field offset: 0x0

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
		public <Unload>d__11(int <>1__state) { }

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
	private T <Component>k__BackingField; //Field offset: 0x0
	private string sceneName; //Field offset: 0x0
	private AsyncOperationHandle<SceneInstance> loadOperation; //Field offset: 0x0

	public private T Component
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public AnimatedSceneLoader`1(string sceneName) { }

	[CompilerGenerated]
	public T get_Component() { }

	private T GetComponentInScene() { }

	[IteratorStateMachine(typeof(<Load>d__7))]
	public IEnumerator Load() { }

	[CompilerGenerated]
	private void set_Component(T value) { }

	public IEnumerator StartCloseAnimation() { }

	[IteratorStateMachine(typeof(<Unload>d__11))]
	public IEnumerator Unload() { }

	public IEnumerator WaitForCloseAnimation() { }

	public IEnumerator WaitForOpenAnimation() { }

}

