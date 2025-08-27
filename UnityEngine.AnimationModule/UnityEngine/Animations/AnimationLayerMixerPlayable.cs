namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable>
{
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationLayerMixerPlayable() { }

	internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true) { }

	public override bool Equals(AnimationLayerMixerPlayable other) { }

	public override PlayableHandle GetHandle() { }

	[NativeThrows]
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

}

