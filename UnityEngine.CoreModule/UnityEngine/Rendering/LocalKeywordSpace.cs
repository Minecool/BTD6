namespace UnityEngine.Rendering;

[IsReadOnly]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
public struct LocalKeywordSpace : IEquatable<LocalKeywordSpace>
{
	private readonly IntPtr m_KeywordSpace; //Field offset: 0x0

	public virtual bool Equals(object o) { }

	public override bool Equals(LocalKeywordSpace rhs) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(LocalKeywordSpace lhs, LocalKeywordSpace rhs) { }

}

