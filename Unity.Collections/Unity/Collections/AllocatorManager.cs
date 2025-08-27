namespace Unity.Collections;

[Extension]
public static class AllocatorManager
{
	internal struct AllocatorHandle : IAllocator, IDisposable, IEquatable<AllocatorHandle>, IComparable<AllocatorHandle>
	{
		public ushort Index; //Field offset: 0x0
		public ushort Version; //Field offset: 0x2

		public override AllocatorHandle Handle
		{
			 get { } //Length: 3
		}

		internal TableEntry TableEntry
		{
			internal get { } //Length: 131
		}

		public override Allocator ToAllocator
		{
			 get { } //Length: 13
		}

		public int Value
		{
			 get { } //Length: 4
		}

		public override int CompareTo(AllocatorHandle other) { }

		public override void Dispose() { }

		public virtual bool Equals(object obj) { }

		public override bool Equals(AllocatorHandle other) { }

		public override AllocatorHandle get_Handle() { }

		internal TableEntry get_TableEntry() { }

		public override Allocator get_ToAllocator() { }

		public int get_Value() { }

		public virtual int GetHashCode() { }

		public static AllocatorHandle op_Implicit(Allocator a) { }

		internal void Rewind() { }

		public override int Try(ref Block block) { }

	}

	public struct Array16
	{
		internal T f0; //Field offset: 0x0
		internal T f1; //Field offset: 0x0
		internal T f2; //Field offset: 0x0
		internal T f3; //Field offset: 0x0
		internal T f4; //Field offset: 0x0
		internal T f5; //Field offset: 0x0
		internal T f6; //Field offset: 0x0
		internal T f7; //Field offset: 0x0
		internal T f8; //Field offset: 0x0
		internal T f9; //Field offset: 0x0
		internal T f10; //Field offset: 0x0
		internal T f11; //Field offset: 0x0
		internal T f12; //Field offset: 0x0
		internal T f13; //Field offset: 0x0
		internal T f14; //Field offset: 0x0
		internal T f15; //Field offset: 0x0

	}

	public struct Array256
	{
		internal Array16<T> f0; //Field offset: 0x0
		internal Array16<T> f1; //Field offset: 0x0
		internal Array16<T> f2; //Field offset: 0x0
		internal Array16<T> f3; //Field offset: 0x0
		internal Array16<T> f4; //Field offset: 0x0
		internal Array16<T> f5; //Field offset: 0x0
		internal Array16<T> f6; //Field offset: 0x0
		internal Array16<T> f7; //Field offset: 0x0
		internal Array16<T> f8; //Field offset: 0x0
		internal Array16<T> f9; //Field offset: 0x0
		internal Array16<T> f10; //Field offset: 0x0
		internal Array16<T> f11; //Field offset: 0x0
		internal Array16<T> f12; //Field offset: 0x0
		internal Array16<T> f13; //Field offset: 0x0
		internal Array16<T> f14; //Field offset: 0x0
		internal Array16<T> f15; //Field offset: 0x0

	}

	public struct Array32768 : IIndexable<T>
	{
		internal Array4096<T> f0; //Field offset: 0x0
		internal Array4096<T> f1; //Field offset: 0x0
		internal Array4096<T> f2; //Field offset: 0x0
		internal Array4096<T> f3; //Field offset: 0x0
		internal Array4096<T> f4; //Field offset: 0x0
		internal Array4096<T> f5; //Field offset: 0x0
		internal Array4096<T> f6; //Field offset: 0x0
		internal Array4096<T> f7; //Field offset: 0x0

		public override int Length
		{
			 get { } //Length: 6
		}

		public override T ElementAt(int index) { }

		public override int get_Length() { }

	}

	public struct Array4096
	{
		internal Array256<T> f0; //Field offset: 0x0
		internal Array256<T> f1; //Field offset: 0x0
		internal Array256<T> f2; //Field offset: 0x0
		internal Array256<T> f3; //Field offset: 0x0
		internal Array256<T> f4; //Field offset: 0x0
		internal Array256<T> f5; //Field offset: 0x0
		internal Array256<T> f6; //Field offset: 0x0
		internal Array256<T> f7; //Field offset: 0x0
		internal Array256<T> f8; //Field offset: 0x0
		internal Array256<T> f9; //Field offset: 0x0
		internal Array256<T> f10; //Field offset: 0x0
		internal Array256<T> f11; //Field offset: 0x0
		internal Array256<T> f12; //Field offset: 0x0
		internal Array256<T> f13; //Field offset: 0x0
		internal Array256<T> f14; //Field offset: 0x0
		internal Array256<T> f15; //Field offset: 0x0

	}

	internal struct Block : IDisposable
	{
		public Range Range; //Field offset: 0x0
		public int BytesPerItem; //Field offset: 0x10
		public int AllocatedItems; //Field offset: 0x14
		public byte Log2Alignment; //Field offset: 0x18
		public byte Padding0; //Field offset: 0x19
		public ushort Padding1; //Field offset: 0x1A
		public uint Padding2; //Field offset: 0x1C

		public int Alignment
		{
			 get { } //Length: 15
			 set { } //Length: 75
		}

		public long AllocatedBytes
		{
			 get { } //Length: 13
		}

		public long Bytes
		{
			 get { } //Length: 13
		}

		public override void Dispose() { }

		public int get_Alignment() { }

		public long get_AllocatedBytes() { }

		public long get_Bytes() { }

		public void set_Alignment(int value) { }

		public int TryFree() { }

	}

	internal interface IAllocator : IDisposable
	{

		public AllocatorHandle Handle
		{
			 get { } //Length: 0
		}

		public AllocatorHandle get_Handle() { }

		public int Try(ref Block block) { }

	}

	public static class Managed
	{
		internal static TryFunction[] TryFunctionDelegates; //Field offset: 0x0

		private static Managed() { }

	}

	internal struct Range : IDisposable
	{
		public IntPtr Pointer; //Field offset: 0x0
		public int Items; //Field offset: 0x8
		public AllocatorHandle Allocator; //Field offset: 0xC

		public override void Dispose() { }

	}

	public sealed class SharedStatics
	{
		public sealed class TableEntry
		{
			internal static readonly SharedStatic<Array32768`1<TableEntry>> Ref; //Field offset: 0x0

			private static TableEntry() { }

		}


	}

	public struct TableEntry
	{
		internal IntPtr function; //Field offset: 0x0
		internal IntPtr state; //Field offset: 0x8

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	internal sealed class TryFunction : MulticastDelegate
	{

		public TryFunction(object object, IntPtr method) { }

		public override int Invoke(IntPtr allocatorState, ref Block block) { }

	}

	public static readonly AllocatorHandle Invalid; //Field offset: 0x0
	public static readonly AllocatorHandle None; //Field offset: 0x4
	public static readonly AllocatorHandle Temp; //Field offset: 0x8
	public static readonly AllocatorHandle TempJob; //Field offset: 0xC
	public static readonly AllocatorHandle Persistent; //Field offset: 0x10
	public static readonly AllocatorHandle AudioKernel; //Field offset: 0x14
	internal static readonly ushort NumGlobalScratchAllocators; //Field offset: 0x18
	internal static readonly ushort MaxNumGlobalAllocators; //Field offset: 0x1A
	internal static readonly uint GlobalAllocatorBaseIndex; //Field offset: 0x1C
	internal static readonly uint FirstGlobalScratchpadAllocatorIndex; //Field offset: 0x20

	private static AllocatorManager() { }

	[Extension]
	public static Void* Allocate(ref T t, int sizeOf, int alignOf, int items = 1) { }

	[Extension]
	internal static U* Allocate(ref T t, U u, int items) { }

	private static int allocate_block(ref Block block) { }

	[Extension]
	internal static Block AllocateBlock(ref T t, int sizeOf, int alignOf, int items) { }

	[BurstDiscard]
	private static void CheckDelegate(ref bool useDelegate) { }

	[BurstDiscard]
	private static void forward_mono_allocate_block(ref Block block, ref int error) { }

	[Extension]
	internal static void Free(ref T t, Void* pointer, int sizeOf, int alignOf, int items) { }

	[Extension]
	internal static void Free(ref T t, U* pointer, int items) { }

	public static void Free(AllocatorHandle handle, Void* pointer) { }

	public static void Free(AllocatorHandle handle, T* pointer, int items = 1) { }

	[Extension]
	internal static void FreeBlock(ref T t, ref Block block) { }

	internal static Allocator LegacyOf(AllocatorHandle handle) { }

	public static int Try(ref Block block) { }

	private static int TryLegacy(ref Block block) { }

	private static bool UseDelegate() { }

}

