namespace UnityEngine.Audio;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
public class AudioMixer : object
{

	[NativeProperty]
	public AudioMixerGroup outputAudioMixerGroup
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	[NativeProperty]
	public AudioMixerUpdateMode updateMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	internal AudioMixer() { }

	[NativeMethod]
	public bool ClearFloat(string name) { }

	private static bool ClearFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = True, HasExplicitThis = True)]
	public AudioMixerGroup[] FindMatchingGroups(string subPath) { }

	private static AudioMixerGroup[] FindMatchingGroups_Injected(IntPtr _unity_self, ref ManagedSpanWrapper subPath) { }

	[NativeMethod("FindSnapshotFromName")]
	public AudioMixerSnapshot FindSnapshot(string name) { }

	private static IntPtr FindSnapshot_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public AudioMixerGroup get_outputAudioMixerGroup() { }

	private static IntPtr get_outputAudioMixerGroup_Injected(IntPtr _unity_self) { }

	public AudioMixerUpdateMode get_updateMode() { }

	private static AudioMixerUpdateMode get_updateMode_Injected(IntPtr _unity_self) { }

	[NativeMethod("AudioMixerBindings::GetAbsoluteAudibilityFromGroup", HasExplicitThis = True, IsFreeFunction = True)]
	internal float GetAbsoluteAudibilityFromGroup(AudioMixerGroup group) { }

	private static float GetAbsoluteAudibilityFromGroup_Injected(IntPtr _unity_self, IntPtr group) { }

	[NativeMethod]
	public bool GetFloat(string name, out float value) { }

	private static bool GetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out float value) { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	private static void set_outputAudioMixerGroup_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_updateMode(AudioMixerUpdateMode value) { }

	private static void set_updateMode_Injected(IntPtr _unity_self, AudioMixerUpdateMode value) { }

	[NativeMethod]
	public bool SetFloat(string name, float value) { }

	private static bool SetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value) { }

	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethod("TransitionToSnapshot")]
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	private static void TransitionToSnapshotInternal_Injected(IntPtr _unity_self, IntPtr snapshot, float timeToReach) { }

	[NativeMethod("AudioMixerBindings::TransitionToSnapshots", IsFreeFunction = True, HasExplicitThis = True, ThrowsException = True)]
	public void TransitionToSnapshots(AudioMixerSnapshot[] snapshots, Single[] weights, float timeToReach) { }

	private static void TransitionToSnapshots_Injected(IntPtr _unity_self, AudioMixerSnapshot[] snapshots, ref ManagedSpanWrapper weights, float timeToReach) { }

}

