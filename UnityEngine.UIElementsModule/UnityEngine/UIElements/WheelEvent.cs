namespace UnityEngine.UIElements;

public class WheelEvent : MouseEventBase<WheelEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal WheelEvent <.cctor>b__1_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector3 <delta>k__BackingField; //Field offset: 0xA0

	public private Vector3 delta
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 2510
	}

	private static WheelEvent() { }

	public WheelEvent() { }

	internal virtual void Dispatch(BaseVisualElementPanel panel) { }

	[CompilerGenerated]
	public Vector3 get_delta() { }

	public static WheelEvent GetPooled(Event systemEvent) { }

	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers = 0) { }

	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_delta(Vector3 value) { }

}

