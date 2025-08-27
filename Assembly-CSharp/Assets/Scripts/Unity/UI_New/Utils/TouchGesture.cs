namespace Assets.Scripts.Unity.UI_New.Utils;

public class TouchGesture
{
	[CompilerGenerated]
	private sealed class <CheckHorizontalSwipes>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TouchGesture <>4__this; //Field offset: 0x20
		public Action onLeftSwipe; //Field offset: 0x28
		public Action onRightSwipe; //Field offset: 0x30

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
		public <CheckHorizontalSwipes>d__8(int <>1__state) { }

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

	internal class GestureSettings
	{
		public float minSwipeDist; //Field offset: 0x10
		public float maxSwipeTime; //Field offset: 0x14
		public RectTransform container; //Field offset: 0x18

		public GestureSettings() { }

	}

	private GestureSettings settings; //Field offset: 0x10
	private float swipeStartTime; //Field offset: 0x18
	private bool couldBeSwipe; //Field offset: 0x1C
	private Vector2 startPos; //Field offset: 0x20
	private int stationaryForFrames; //Field offset: 0x28
	private TouchPhase lastPhase; //Field offset: 0x2C

	public TouchGesture(GestureSettings gestureSettings) { }

	[IteratorStateMachine(typeof(<CheckHorizontalSwipes>d__8))]
	public IEnumerator CheckHorizontalSwipes(Action onLeftSwipe, Action onRightSwipe) { }

	private bool IsASwipe(Vector2 endPos) { }

	private bool IsContinouslyStationary(int frames) { }

	private void OnInputEnd(Vector2 endPos, Action onLeftSwipe, Action onRightSwipe) { }

}

