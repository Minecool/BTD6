namespace UnityEngine.InputSystem.LowLevel;

public struct EnableDeviceCommand : IInputDeviceCommandInfo
{
	internal const int kSize = 8; //Field offset: 0x0
	public InputDeviceCommand baseCommand; //Field offset: 0x0

	public static FourCC Type
	{
		 get { } //Length: 53
	}

	public override FourCC typeStatic
	{
		 get { } //Length: 53
	}

	public static EnableDeviceCommand Create() { }

	public static FourCC get_Type() { }

	public override FourCC get_typeStatic() { }

}

