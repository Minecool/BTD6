namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[UsedByNativeCode]
public struct GlobalKeyword
{
	internal readonly string m_Name; //Field offset: 0x0
	internal readonly uint m_Index; //Field offset: 0x8

	public virtual string ToString() { }

}

