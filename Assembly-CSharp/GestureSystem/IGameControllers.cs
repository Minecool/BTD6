namespace GestureSystem;

public interface IGameControllers
{

	public event MainControllerConnected_t onMainControllerConnected
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event MainControllerDisconnected_t onMainControllerDisconnected
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event ValueChanged_t onValueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_onMainControllerConnected(MainControllerConnected_t value) { }

	[CompilerGenerated]
	public void add_onMainControllerDisconnected(MainControllerDisconnected_t value) { }

	[CompilerGenerated]
	public void add_onValueChanged(ValueChanged_t value) { }

	[CompilerGenerated]
	public void remove_onMainControllerConnected(MainControllerConnected_t value) { }

	[CompilerGenerated]
	public void remove_onMainControllerDisconnected(MainControllerDisconnected_t value) { }

	[CompilerGenerated]
	public void remove_onValueChanged(ValueChanged_t value) { }

}

