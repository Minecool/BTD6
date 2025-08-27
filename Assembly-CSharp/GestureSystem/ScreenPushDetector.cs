namespace GestureSystem;

public class ScreenPushDetector : IGestureDetector
{
	[CompilerGenerated]
	private ScreenEdge <Edge>k__BackingField; //Field offset: 0x10
	private Gesture currentGesture; //Field offset: 0x18

	public private ScreenEdge Edge
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ScreenPushDetector() { }

	internal void Cancel() { }

	public override void Detect(Gesture[] gestures) { }

	public override void GestureEnd(Gesture gesture) { }

	[CompilerGenerated]
	public ScreenEdge get_Edge() { }

	private ScreenEdge GetGestureEdge(Gesture gesture) { }

	[CompilerGenerated]
	private void set_Edge(ScreenEdge value) { }

}

