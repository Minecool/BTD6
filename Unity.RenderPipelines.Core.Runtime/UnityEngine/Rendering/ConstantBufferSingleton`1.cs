namespace UnityEngine.Rendering;

internal class ConstantBufferSingleton : ConstantBuffer<CBType>
{
	private static ConstantBufferSingleton<CBType> s_Instance; //Field offset: 0x0

	internal static ConstantBufferSingleton<CBType> instance
	{
		internal get { } //Length: 714
		internal set { } //Length: 132
	}

	public ConstantBufferSingleton`1() { }

	internal static ConstantBufferSingleton<CBType> get_instance() { }

	public virtual void Release() { }

	internal static void set_instance(ConstantBufferSingleton<CBType> value) { }

}

