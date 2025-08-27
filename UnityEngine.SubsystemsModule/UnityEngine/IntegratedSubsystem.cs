namespace UnityEngine;

[NativeHeader("Modules/Subsystems/Subsystem.h")]
[UsedByNativeCode]
public class IntegratedSubsystem : ISubsystem
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(IntegratedSubsystem integratedSubsystem) { }

	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"}])]
	internal IntPtr m_Ptr; //Field offset: 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; //Field offset: 0x18

	public override bool running
	{
		 get { } //Length: 78
	}

	internal bool valid
	{
		internal get { } //Length: 9
	}

	public IntegratedSubsystem() { }

	public override bool get_running() { }

	internal bool get_valid() { }

	internal bool IsRunning() { }

	private static bool IsRunning_Injected(IntPtr _unity_self) { }

	internal void SetHandle(IntegratedSubsystem subsystem) { }

	private static void SetHandle_Injected(IntPtr _unity_self, IntegratedSubsystem subsystem) { }

}

