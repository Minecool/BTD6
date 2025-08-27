namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	internal AnimationClipPlayable(PlayableHandle handle) { }

	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) { }

	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) { }

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	public override bool Equals(AnimationClipPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

