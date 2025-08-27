namespace UnityEngine.UIElements;

[EventCategory(EventCategory::StyleTransition (13))]
public abstract class TransitionEventBase : EventBase<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly StylePropertyNameCollection <stylePropertyNames>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private double <elapsedTime>k__BackingField; //Field offset: 0x0

	protected double elapsedTime
	{
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public override StylePropertyNameCollection stylePropertyNames
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected TransitionEventBase`1() { }

	[CompilerGenerated]
	public override StylePropertyNameCollection get_stylePropertyNames() { }

	public static T GetPooled(StylePropertyName stylePropertyName, double elapsedTime) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	protected void set_elapsedTime(double value) { }

}

