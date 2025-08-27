namespace System.Net;

public static class Dns
{
	private sealed class GetHostAddressesCallback : MulticastDelegate
	{

		public GetHostAddressesCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

		public override IPAddress[] EndInvoke(IAsyncResult result) { }

		public override IPAddress[] Invoke(string hostName) { }

	}

	private sealed class GetHostEntryIPCallback : MulticastDelegate
	{

		public GetHostEntryIPCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IPAddress hostAddress, AsyncCallback callback, object object) { }

		public override IPHostEntry EndInvoke(IAsyncResult result) { }

		public override IPHostEntry Invoke(IPAddress hostAddress) { }

	}

	private sealed class GetHostEntryNameCallback : MulticastDelegate
	{

		public GetHostEntryNameCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

		public override IPHostEntry EndInvoke(IAsyncResult result) { }

		public override IPHostEntry Invoke(string hostName) { }

	}


	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	public static IAsyncResult BeginGetHostEntry(string hostNameOrAddress, AsyncCallback requestCallback, object stateObject) { }

	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	public static IPHostEntry EndGetHostEntry(IAsyncResult asyncResult) { }

	private static void Error_11001(string hostName) { }

	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }

	private static bool GetHostByAddr_icall(string addr, out string h_name, out String[] h_aliases, out String[] h_addr_list, int hint) { }

	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	[Obsolete("Use GetHostEntry instead")]
	public static IPHostEntry GetHostByName(string hostName) { }

	private static bool GetHostByName_icall(string host, out string h_name, out String[] h_aliases, out String[] h_addr_list, int hint) { }

	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	public static IPHostEntry GetHostEntry(IPAddress address) { }

	public static Task<IPHostEntry> GetHostEntryAsync(string hostNameOrAddress) { }

	public static string GetHostName() { }

	private static bool GetHostName_icall(out string h_name) { }

	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, String[] h_aliases, String[] h_addrlist) { }

}

