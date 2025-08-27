namespace UnityEngine.Rendering;

internal static class InstanceTypeInfo
{
	private static InstanceType[] s_ParentTypes; //Field offset: 0x0
	private static List<InstanceType>[] s_ChildTypes; //Field offset: 0x8

	private static InstanceTypeInfo() { }

	private static void FlattenChildInstanceTypes(InstanceType instanceType, NativeList<InstanceType> instanceTypes) { }

	public static List<InstanceType> GetChildTypes(InstanceType type) { }

	private static void InitChildTypes() { }

	private static void InitParentTypes() { }

	private static void ValidateTypeRelationsAreCorrectlySorted() { }

}

