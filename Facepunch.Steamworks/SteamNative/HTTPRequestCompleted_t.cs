namespace SteamNative;

internal struct HTTPRequestCompleted_t
{
	public struct PackSmall
	{
		internal uint Request; //Field offset: 0x0
		internal ulong ContextValue; //Field offset: 0x4
		internal bool RequestSuccessful; //Field offset: 0xC
		internal HTTPStatusCode StatusCode; //Field offset: 0x10
		internal uint BodySize; //Field offset: 0x14

		public static HTTPRequestCompleted_t op_Implicit(PackSmall d) { }

	}

	internal uint Request; //Field offset: 0x0
	internal ulong ContextValue; //Field offset: 0x8
	internal bool RequestSuccessful; //Field offset: 0x10
	internal HTTPStatusCode StatusCode; //Field offset: 0x14
	internal uint BodySize; //Field offset: 0x18

	internal static HTTPRequestCompleted_t FromPointer(IntPtr p) { }

	[MonoPInvokeCallback]
	internal static int OnGetSize() { }

	[MonoPInvokeCallback]
	internal static int OnGetSizeThis(IntPtr self) { }

	[MonoPInvokeCallback]
	internal static void OnResult(IntPtr param) { }

	[MonoPInvokeCallback]
	internal static void OnResultThis(IntPtr self, IntPtr param) { }

	[MonoPInvokeCallback]
	internal static void OnResultWithInfo(IntPtr param, bool failure, SteamAPICall_t call) { }

	[MonoPInvokeCallback]
	internal static void OnResultWithInfoThis(IntPtr self, IntPtr param, bool failure, SteamAPICall_t call) { }

	internal static void Register(BaseSteamworks steamworks) { }

	internal static int StructSize() { }

}

