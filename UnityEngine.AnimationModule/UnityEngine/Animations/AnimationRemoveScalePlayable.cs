namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType::DoubleColon (2))]
internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable>
{
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; //Field offset: 0x0
	private PlayableHandle m_Handle; //Field offset: 0x0

	private static AnimationRemoveScalePlayable() { }

	internal AnimationRemoveScalePlayable(PlayableHandle handle) { }

	public override bool Equals(AnimationRemoveScalePlayable other) { }

	public override PlayableHandle GetHandle() { }

}

