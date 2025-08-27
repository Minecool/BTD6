namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType::DoubleColon (2))]
public struct MaterialEffectPlayable : IPlayable, IEquatable<MaterialEffectPlayable>
{
	private PlayableHandle m_Handle; //Field offset: 0x0

	public override bool Equals(MaterialEffectPlayable other) { }

	public override PlayableHandle GetHandle() { }

}

