namespace UnityEngine;

[NativeClass("BitField", "struct BitField;")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct LayerMask
{
	[NativeName("m_Bits")]
	private int m_Mask; //Field offset: 0x0

	public int value
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public int get_value() { }

	public static int GetMask(String[] layerNames) { }

	[NativeMethod("StringToLayer")]
	[StaticAccessor("GetTagManager()", StaticAccessorType::Dot (0))]
	public static int NameToLayer(string layerName) { }

	public static int op_Implicit(LayerMask mask) { }

	public static LayerMask op_Implicit(int intVal) { }

	public void set_value(int value) { }

}

