namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[UsedByNativeCode]
public struct LocalKeyword : IEquatable<LocalKeyword>
{
	internal readonly LocalKeywordSpace m_SpaceInfo; //Field offset: 0x0
	internal readonly string m_Name; //Field offset: 0x8
	internal readonly uint m_Index; //Field offset: 0x10

	public LocalKeyword(Shader shader, string name) { }

	public LocalKeyword(ComputeShader shader, string name) { }

	public virtual bool Equals(object o) { }

	public override bool Equals(LocalKeyword rhs) { }

	[FreeFunction("ShaderScripting::GetKeywordCount")]
	private static uint GetComputeShaderKeywordCount(ComputeShader shader) { }

	private static uint GetComputeShaderKeywordCount_Injected(IntPtr shader) { }

	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	private static uint GetComputeShaderKeywordIndex(ComputeShader shader, string keyword) { }

	private static uint GetComputeShaderKeywordIndex_Injected(IntPtr shader, ref ManagedSpanWrapper keyword) { }

	public virtual int GetHashCode() { }

	[FreeFunction("ShaderScripting::GetKeywordCount")]
	private static uint GetShaderKeywordCount(Shader shader) { }

	private static uint GetShaderKeywordCount_Injected(IntPtr shader) { }

	[FreeFunction("ShaderScripting::GetKeywordIndex")]
	private static uint GetShaderKeywordIndex(Shader shader, string keyword) { }

	private static uint GetShaderKeywordIndex_Injected(IntPtr shader, ref ManagedSpanWrapper keyword) { }

	public virtual string ToString() { }

}

