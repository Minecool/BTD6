namespace GestureSystem;

public class SimpleTapGestureDetector : IGestureDetector
{
	public const float MaxDragDistance = 999; //Field offset: 0x0
	public const float MaxTapDuration = 1; //Field offset: 0x0
	[CompilerGenerated]
	private Action<Gesture> Trigger; //Field offset: 0x10
	private TapOnDetector tapOnDetector; //Field offset: 0x18

	public event Action<Gesture> Trigger
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public SimpleTapGestureDetector(TapOnDetector tapOnDetector) { }

	[CompilerGenerated]
	public void add_Trigger(Action<Gesture> value) { }

	public override void Detect(Gesture[] gestures) { }

	public override void GestureEnd(Gesture gesture) { }

	[CompilerGenerated]
	public void remove_Trigger(Action<Gesture> value) { }

}

