namespace Assets.Scripts.Unity.UI_New;

public class InGameObjects : DynamicUiObject
{
	[CompilerGenerated]
	private sealed class <Initialise>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InGameObjects <>4__this; //Field offset: 0x20

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
		public <Initialise>d__5(int <>1__state) { }

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

	public static InGameObjects instance; //Field offset: 0x0
	public GameObject powerIcon; //Field offset: 0x20
	private Image powerIconImg; //Field offset: 0x28
	private bool isPlacingDisplayNode; //Field offset: 0x30
	private UnityDisplayNode placingDisplayNode; //Field offset: 0x38

	public InGameObjects() { }

	[CompilerGenerated]
	private void <PlacingDisplayStart>b__10_0(UnityDisplayNode node) { }

	public void IconEnd() { }

	public void IconStart(Sprite icon) { }

	public void IconUpdate(Vector2 pos, bool canPlace) { }

	[IteratorStateMachine(typeof(<Initialise>d__5))]
	public virtual IEnumerator Initialise() { }

	private void OnDestroy() { }

	public void PlacingDisplayEnd() { }

	public void PlacingDisplayStart(PrefabReference reference) { }

	public void PlacingDisplayUpdate(Vector3 position) { }

}

