namespace Assets.Scripts.Unity.UI_New.Main.Home;

public class HomeAchievementsButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ActiveAchievement, Boolean> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <UpdateNewAchievementIcon>b__5_0(ActiveAchievement achievement) { }

	}

	[CompilerGenerated]
	private sealed class <UpdateNewAchievementIcon>d__5 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public HomeAchievementsButton <>4__this; //Field offset: 0x20
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
		public <UpdateNewAchievementIcon>d__5(int <>1__state) { }

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
	private Sprite googleAchievementsIcon; //Field offset: 0x20
	[SerializeField]
	private Image icon; //Field offset: 0x28
	[SerializeField]
	private GameObject newAchieveIcon; //Field offset: 0x30

	public HomeAchievementsButton() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<UpdateNewAchievementIcon>d__5))]
	private IEnumerator UpdateNewAchievementIcon(float updateInterval) { }

}

