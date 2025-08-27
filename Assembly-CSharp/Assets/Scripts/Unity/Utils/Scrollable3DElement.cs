namespace Assets.Scripts.Unity.Utils;

public class Scrollable3DElement : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[CompilerGenerated]
	private sealed class <ScaleCoroutine>d__35 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Scrollable3DElement <>4__this; //Field offset: 0x20
		public ScalePhase phase; //Field offset: 0x28
		private bool <isScalingIn>5__2; //Field offset: 0x2C
		private float <initialScale>5__3; //Field offset: 0x30
		private float <targetScale>5__4; //Field offset: 0x34
		private float <duration>5__5; //Field offset: 0x38
		private float <timeRemaining>5__6; //Field offset: 0x3C

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
		public <ScaleCoroutine>d__35(int <>1__state) { }

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

	private enum ScalePhase
	{
		ScaledIn = 0,
		ScaledOut = 1,
		ScalingIn = 2,
		ScalingOut = 3,
	}

	private const float kScaleTime = 0.1; //Field offset: 0x0
	[SerializeField]
	private Transform content; //Field offset: 0x20
	private Coroutine scaleRoutine; //Field offset: 0x28
	private ScalePhase scalePhase; //Field offset: 0x30
	private Collider _collider; //Field offset: 0x38
	private bool isScrolling; //Field offset: 0x40
	private Action<Scrollable3DElement, PointerEventData> m_OnBeginDragDelegate; //Field offset: 0x48
	private Action<Scrollable3DElement, PointerEventData> m_OnDragDelegate; //Field offset: 0x50
	private Action<Scrollable3DElement, PointerEventData> m_OnEndDragDelegate; //Field offset: 0x58
	private Action<Scrollable3DElement> m_OnDestroyDelegate; //Field offset: 0x60

	public event Action<Scrollable3DElement, PointerEventData> OnBeginDragDelegate
	{
		 add { } //Length: 164
		 remove { } //Length: 164
	}

	public event Action<Scrollable3DElement> OnDestroyDelegate
	{
		 add { } //Length: 164
		 remove { } //Length: 164
	}

	public event Action<Scrollable3DElement, PointerEventData> OnDragDelegate
	{
		 add { } //Length: 164
		 remove { } //Length: 164
	}

	public event Action<Scrollable3DElement, PointerEventData> OnEndDragDelegate
	{
		 add { } //Length: 164
		 remove { } //Length: 164
	}

	public bool ContentIsVisible
	{
		 get { } //Length: 44
	}

	public bool IsScrolling
	{
		 get { } //Length: 5
	}

	public Scrollable3DElement() { }

	public void add_OnBeginDragDelegate(Action<Scrollable3DElement, PointerEventData> value) { }

	public void add_OnDestroyDelegate(Action<Scrollable3DElement> value) { }

	public void add_OnDragDelegate(Action<Scrollable3DElement, PointerEventData> value) { }

	public void add_OnEndDragDelegate(Action<Scrollable3DElement, PointerEventData> value) { }

	private void Awake() { }

	public bool get_ContentIsVisible() { }

	public bool get_IsScrolling() { }

	private void OnDestroy() { }

	public void remove_OnBeginDragDelegate(Action<Scrollable3DElement, PointerEventData> value) { }

	public void remove_OnDestroyDelegate(Action<Scrollable3DElement> value) { }

	public void remove_OnDragDelegate(Action<Scrollable3DElement, PointerEventData> value) { }

	public void remove_OnEndDragDelegate(Action<Scrollable3DElement, PointerEventData> value) { }

	[IteratorStateMachine(typeof(<ScaleCoroutine>d__35))]
	private IEnumerator ScaleCoroutine(ScalePhase phase) { }

	public void ScaleIn() { }

	public void ScaleOut() { }

	public void SetScrolling(bool scrolling) { }

	private override void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData eventData) { }

}

