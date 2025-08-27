namespace GestureSystem;

public class NoGameControllers : MonoBehaviourSingleton<NoGameControllers>, IGameControllers
{
	[CompilerGenerated]
	private MainControllerConnected_t onMainControllerConnected; //Field offset: 0x20
	[CompilerGenerated]
	private MainControllerDisconnected_t onMainControllerDisconnected; //Field offset: 0x28
	[CompilerGenerated]
	private ValueChanged_t onValueChanged; //Field offset: 0x30

	public override event MainControllerConnected_t onMainControllerConnected
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event MainControllerDisconnected_t onMainControllerDisconnected
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override event ValueChanged_t onValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public NoGameControllers() { }

	[CompilerGenerated]
	public override void add_onMainControllerConnected(MainControllerConnected_t value) { }

	[CompilerGenerated]
	public override void add_onMainControllerDisconnected(MainControllerDisconnected_t value) { }

	[CompilerGenerated]
	public override void add_onValueChanged(ValueChanged_t value) { }

	[CompilerGenerated]
	public override void remove_onMainControllerConnected(MainControllerConnected_t value) { }

	[CompilerGenerated]
	public override void remove_onMainControllerDisconnected(MainControllerDisconnected_t value) { }

	[CompilerGenerated]
	public override void remove_onValueChanged(ValueChanged_t value) { }

}

