namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", StaticAccessorType::Dot (0))]
public sealed class AudioSettings
{
	internal sealed class AudioConfigurationChangeHandler : MulticastDelegate
	{

		public AudioConfigurationChangeHandler(object object, IntPtr method) { }

		public override void Invoke(bool deviceWasChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action OnAudioSystemShuttingDown; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action OnAudioSystemStartedUp; //Field offset: 0x10

	public static event AudioConfigurationChangeHandler OnAudioConfigurationChanged
	{
		[CompilerGenerated]
		 add { } //Length: 180
		[CompilerGenerated]
		 remove { } //Length: 180
	}

	[CompilerGenerated]
	public static void add_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value) { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	internal static void InvokeOnAudioSystemStartedUp() { }

	[CompilerGenerated]
	public static void remove_OnAudioConfigurationChanged(AudioConfigurationChangeHandler value) { }

}

