namespace UnityEngine.Audio;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
public class AudioMixer : object
{

	[NativeProperty]
	public AudioMixerGroup outputAudioMixerGroup
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty]
	public AudioMixerUpdateMode updateMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	internal AudioMixer() { }

	[NativeMethod]
	public bool ClearFloat(string name) { }

	[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = True, HasExplicitThis = True)]
	public AudioMixerGroup[] FindMatchingGroups(string subPath) { }

	[NativeMethod("FindSnapshotFromName")]
	public AudioMixerSnapshot FindSnapshot(string name) { }

	public AudioMixerGroup get_outputAudioMixerGroup() { }

	public AudioMixerUpdateMode get_updateMode() { }

	[NativeMethod("AudioMixerBindings::GetAbsoluteAudibilityFromGroup", HasExplicitThis = True, IsFreeFunction = True)]
	internal float GetAbsoluteAudibilityFromGroup(AudioMixerGroup group) { }

	[NativeMethod]
	public bool GetFloat(string name, out float value) { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	public void set_updateMode(AudioMixerUpdateMode value) { }

	[NativeMethod]
	public bool SetFloat(string name, float value) { }

	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethod("TransitionToSnapshot")]
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethod("AudioMixerBindings::TransitionToSnapshots", IsFreeFunction = True, HasExplicitThis = True, ThrowsException = True)]
	public void TransitionToSnapshots(AudioMixerSnapshot[] snapshots, Single[] weights, float timeToReach) { }

}

