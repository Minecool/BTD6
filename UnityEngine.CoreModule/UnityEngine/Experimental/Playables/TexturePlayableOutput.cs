namespace UnityEngine.Experimental.Playables;

[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[RequiredByNativeCode]
[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
public struct TexturePlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	public override PlayableOutputHandle GetHandle() { }

}

