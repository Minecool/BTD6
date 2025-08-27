namespace UnityEngine.InputSystem.LowLevel;

public struct QueryEnabledStateCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 9; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0
	public bool isEnabled; //Field offset: 0x8

	public static FourCC Type
	{
		 get { } //Length: 53
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 53
	}

	public static QueryEnabledStateCommand Create() { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

