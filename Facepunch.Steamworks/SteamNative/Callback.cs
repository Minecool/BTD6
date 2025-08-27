namespace SteamNative;

internal class Callback
{
	internal class VTable
	{
		[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
		internal sealed class GetSizeD : MulticastDelegate
		{

			public GetSizeD(object object, IntPtr method) { }

			public override int Invoke() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
		internal sealed class ResultD : MulticastDelegate
		{

			public ResultD(object object, IntPtr method) { }

			public override void Invoke(IntPtr pvParam) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
		internal sealed class ResultWithInfoD : MulticastDelegate
		{

			public ResultWithInfoD(object object, IntPtr method) { }

			public override void Invoke(IntPtr pvParam, bool bIOFailure, SteamAPICall_t hSteamAPICall) { }

		}

		public ResultD ResultA; //Field offset: 0x10
		public ResultWithInfoD ResultB; //Field offset: 0x18
		public GetSizeD GetSize; //Field offset: 0x20

		public VTable() { }

	}

	internal class VTableThis
	{
		[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
		internal sealed class GetSizeD : MulticastDelegate
		{

			public GetSizeD(object object, IntPtr method) { }

			public override int Invoke(IntPtr thisptr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
		internal sealed class ResultD : MulticastDelegate
		{

			public ResultD(object object, IntPtr method) { }

			public override void Invoke(IntPtr thisptr, IntPtr pvParam) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
		internal sealed class ResultWithInfoD : MulticastDelegate
		{

			public ResultWithInfoD(object object, IntPtr method) { }

			public override void Invoke(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, SteamAPICall_t hSteamAPICall) { }

		}

		public ResultD ResultA; //Field offset: 0x10
		public ResultWithInfoD ResultB; //Field offset: 0x18
		public GetSizeD GetSize; //Field offset: 0x20

		public VTableThis() { }

	}

	internal class VTableWin
	{
		[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
		internal sealed class GetSizeD : MulticastDelegate
		{

			public GetSizeD(object object, IntPtr method) { }

			public override int Invoke() { }

		}

		[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
		internal sealed class ResultD : MulticastDelegate
		{

			public ResultD(object object, IntPtr method) { }

			public override void Invoke(IntPtr pvParam) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::StdCall (3))]
		internal sealed class ResultWithInfoD : MulticastDelegate
		{

			public ResultWithInfoD(object object, IntPtr method) { }

			public override void Invoke(IntPtr pvParam, bool bIOFailure, SteamAPICall_t hSteamAPICall) { }

		}

		public ResultWithInfoD ResultB; //Field offset: 0x10
		public ResultD ResultA; //Field offset: 0x18
		public GetSizeD GetSize; //Field offset: 0x20

		public VTableWin() { }

	}

	internal class VTableWinThis
	{
		[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
		internal sealed class GetSizeD : MulticastDelegate
		{

			public GetSizeD(object object, IntPtr method) { }

			public override int Invoke(IntPtr thisptr) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
		internal sealed class ResultD : MulticastDelegate
		{

			public ResultD(object object, IntPtr method) { }

			public override void Invoke(IntPtr thisptr, IntPtr pvParam) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::ThisCall (4))]
		internal sealed class ResultWithInfoD : MulticastDelegate
		{

			public ResultWithInfoD(object object, IntPtr method) { }

			public override void Invoke(IntPtr thisptr, IntPtr pvParam, bool bIOFailure, SteamAPICall_t hSteamAPICall) { }

		}

		public ResultWithInfoD ResultB; //Field offset: 0x10
		public ResultD ResultA; //Field offset: 0x18
		public GetSizeD GetSize; //Field offset: 0x20

		public VTableWinThis() { }

	}

	public IntPtr vTablePtr; //Field offset: 0x10
	public byte CallbackFlags; //Field offset: 0x18
	public int CallbackId; //Field offset: 0x1C

	public Callback() { }

}

