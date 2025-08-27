namespace Assets.Scripts.Unity.UI_New.Main.Home;

public class HomeFeatsButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LegendsFeatActive, Boolean> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateNewFeatsIcon>b__5_0(LegendsFeatActive feat) { }

	}

	[CompilerGenerated]
	private sealed class <UpdateNewFeatsIcon>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HomeFeatsButton <>4__this; //Field offset: 0x20
		public float updateInterval; //Field offset: 0x28

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
		public <UpdateNewFeatsIcon>d__5(int <>1__state) { }

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

	private const float kUpdateInterval = 1; //Field offset: 0x0
	[SerializeField]
	private Image icon; //Field offset: 0x20
	[SerializeField]
	private GameObject newFeatIcon; //Field offset: 0x28

	public HomeFeatsButton() { }

	private void Awake() { }

	private void OnEnable() { }

	[IteratorStateMachine(typeof(<UpdateNewFeatsIcon>d__5))]
	private IEnumerator UpdateNewFeatsIcon(float updateInterval) { }

}

