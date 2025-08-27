namespace Assets.Scripts.Unity.Utils;

public class AtlasLateBinding : MonoBehaviourSingleton<AtlasLateBinding>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public bool originalRequest; //Field offset: 0x10
		public AsyncOperationHandle<SpriteAtlas> handle; //Field offset: 0x18
		public string atlasName; //Field offset: 0x30
		public AtlasLateBinding <>4__this; //Field offset: 0x38
		public Action<SpriteAtlas> callback; //Field offset: 0x40

		public <>c__DisplayClass9_0() { }

		internal void <OnAtlasRequested>b__0(AsyncOperationHandle<SpriteAtlas> _) { }

	}

	[CompilerGenerated]
	private sealed class <ActivateAfterLateBind>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public AtlasLateBinding <>4__this; //Field offset: 0x20
		public Scene scene; //Field offset: 0x28
		private List<GameObject> <disabledObjects>5__2; //Field offset: 0x30

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
		public <ActivateAfterLateBind>d__7(int <>1__state) { }

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

	private Dictionary<String, AsyncOperationHandle`1<SpriteAtlas>> atlasHandles; //Field offset: 0x20

	public bool AtlasesAreLoading
	{
		 get { } //Length: 170
	}

	public AtlasLateBinding() { }

	[IteratorStateMachine(typeof(<ActivateAfterLateBind>d__7))]
	private IEnumerator ActivateAfterLateBind(Scene scene) { }

	public bool get_AtlasesAreLoading() { }

	private void Init() { }

	private void OnAtlasRequested(string atlasName, Action<SpriteAtlas> callback = null) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RuntimeInitializeOnLoadMethod]
	private static void sInit() { }

	public bool TryReleaseAtlas(string atlasName) { }

}

