namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets::Parameter (2048), AllowMultiple = False, Inherited = False)]
[VisibleToOtherModules]
internal class SpanAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <SizeParameter>k__BackingField; //Field offset: 0x18

	public SpanAttribute(string sizeParameter, bool isReadOnly = false) { }

}

