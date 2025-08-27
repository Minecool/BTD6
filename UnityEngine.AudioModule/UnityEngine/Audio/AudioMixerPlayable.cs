namespace UnityEngine.Audio;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AudioMixerPlayable : IPlayable, IEquatable<AudioMixerPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(AudioMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

