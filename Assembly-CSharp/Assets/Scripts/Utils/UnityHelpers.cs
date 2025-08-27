namespace Assets.Scripts.Utils;

[Extension]
public static class UnityHelpers
{
	[CompilerGenerated]
	private sealed class <GetAllComponents>d__5 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private Scene scene; //Field offset: 0x0
		public Scene <>3__scene; //Field offset: 0x0
		private bool includeInactive; //Field offset: 0x0
		public bool <>3__includeInactive; //Field offset: 0x0
		private GameObject[] <>7__wrap1; //Field offset: 0x0
		private int <>7__wrap2; //Field offset: 0x0
		private T[] <>7__wrap3; //Field offset: 0x0
		private int <>7__wrap4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetAllComponents>d__5`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetAllRootGameObjects>d__3 : IEnumerable<GameObject>, IEnumerable, IEnumerator<GameObject>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private GameObject <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerator<Int32> <>7__wrap1; //Field offset: 0x28
		private GameObject[] <>7__wrap2; //Field offset: 0x30
		private int <>7__wrap3; //Field offset: 0x38

		private override GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.Current
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
		public <GetAllRootGameObjects>d__3(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<GameObject> System.Collections.Generic.IEnumerable<UnityEngine.GameObject>.GetEnumerator() { }

		[DebuggerHidden]
		private override GameObject System.Collections.Generic.IEnumerator<UnityEngine.GameObject>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}


	private static int SceneCount
	{
		private get { } //Length: 64
	}

	[Extension]
	public static GameObject FindObject(GameObject parent, string name) { }

	private static int get_SceneCount() { }

	public static List<T> GetAllComponents(bool includeInactive = false) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetAllComponents>d__5`1))]
	public static IEnumerable<T> GetAllComponents(Scene scene, bool includeInactive = false) { }

	[IteratorStateMachine(typeof(<GetAllRootGameObjects>d__3))]
	public static IEnumerable<GameObject> GetAllRootGameObjects() { }

	[Extension]
	public static T GetComponent(Scene scene, bool includeInactive = false) { }

	public static T GetComponentInDirectChildren(GameObject gameObject) { }

	public static T GetEnabledComponent(GameObject gameObject) { }

	private static Scene GetSceneAt(int index) { }

	public static Rect RectTransformToScreenSpace(RectTransform transform) { }

	[Extension]
	public static bool TryFindObject(GameObject parent, string name, out GameObject gameObject) { }

}

