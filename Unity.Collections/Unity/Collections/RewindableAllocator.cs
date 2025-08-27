namespace Unity.Collections;

[BurstCompile]
public struct RewindableAllocator : IAllocator, IDisposable
{
	[BurstCompatible]
	public struct MemoryBlock : IDisposable
	{
		public Byte* m_pointer; //Field offset: 0x0
		public long m_bytes; //Field offset: 0x8
		public long m_current; //Field offset: 0x10
		public long m_allocations; //Field offset: 0x18

		public MemoryBlock(long bytes) { }

		public bool Contains(IntPtr ptr) { }

		public override void Dispose() { }

		public void Rewind() { }

		public int TryAllocate(ref Block block) { }

	}

	public static class Try_000006E8$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static Try_000006E8$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static int Invoke(IntPtr state, ref Block block) { }

	}

	internal sealed class Try_000006E8$PostfixBurstDelegate : MulticastDelegate
	{

		public Try_000006E8$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override int Invoke(IntPtr state, ref Block block) { }

	}

	private Spinner m_spinner; //Field offset: 0x0
	private AllocatorHandle m_handle; //Field offset: 0x4
	private UnmanagedArray<MemoryBlock> m_block; //Field offset: 0x8
	private int m_best; //Field offset: 0x18
	private int m_last; //Field offset: 0x1C
	private int m_used; //Field offset: 0x20
	private bool m_enableBlockFree; //Field offset: 0x24

	public override AllocatorHandle Handle
	{
		 get { } //Length: 4
	}

	public override void Dispose() { }

	public override AllocatorHandle get_Handle() { }

	public void Rewind() { }

	public override int Try(ref Block block) { }

	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	internal static int Try(IntPtr state, ref Block block) { }

	[BurstCompile]
	[MonoPInvokeCallback(typeof(TryFunction))]
	public static int Try$BurstManaged(IntPtr state, ref Block block) { }

}

