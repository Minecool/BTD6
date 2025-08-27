namespace UnityEngine;

[NativeClass("RenderingLayerMask", "struct RenderingLayerMask;")]
[NativeHeader("Runtime/Graphics/RenderingLayerMask.h")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct RenderingLayerMask
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static readonly RenderingLayerMask <defaultRenderingLayerMask>k__BackingField; //Field offset: 0x0
	internal const int maxRenderingLayerSize = 32; //Field offset: 0x0
	[NativeName("m_Bits")]
	private uint m_Bits; //Field offset: 0x0

	private static RenderingLayerMask() { }

	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static int GetDefinedRenderingLayerCount() { }

	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static String[] GetDefinedRenderingLayerNames() { }

	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static uint GetDefinedRenderingLayersCombinedMaskValue() { }

	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static int GetRenderingLayerCount() { }

	public static uint op_Implicit(RenderingLayerMask mask) { }

	public static RenderingLayerMask op_Implicit(uint intVal) { }

	public static int op_Implicit(RenderingLayerMask mask) { }

	public static RenderingLayerMask op_Implicit(int intVal) { }

	[NativeMethod("RenderingLayerToString")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static string RenderingLayerToName(int layer) { }

	private static void RenderingLayerToName_Injected(int layer, out ManagedSpanWrapper ret) { }

}

