namespace System.Net;

public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public WindowsIdentity currentUser; //Field offset: 0x10
		public WebRequest <>4__this; //Field offset: 0x18

		public <>c__DisplayClass78_0() { }

		internal Task<Stream> <GetRequestStreamAsync>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public WindowsIdentity currentUser; //Field offset: 0x10
		public WebRequest <>4__this; //Field offset: 0x18

		public <>c__DisplayClass79_0() { }

		internal Task<WebResponse> <GetResponseAsync>b__1() { }

	}

	public class DesignerWebRequestCreate : IWebRequestCreate
	{

		public DesignerWebRequestCreate() { }

		public override WebRequest Create(Uri uri) { }

	}

	private static ArrayList s_PrefixList; //Field offset: 0x0
	private static object s_InternalSyncObject; //Field offset: 0x8
	private static Queue s_DefaultTimerQueue; //Field offset: 0x10
	private static DesignerWebRequestCreate webRequestCreate; //Field offset: 0x18
	private static IWebProxy s_DefaultWebProxy; //Field offset: 0x20
	private static bool s_DefaultWebProxyInitialized; //Field offset: 0x28
	private AuthenticationLevel m_AuthenticationLevel; //Field offset: 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; //Field offset: 0x1C
	private RequestCachePolicy m_CachePolicy; //Field offset: 0x20
	private RequestCacheProtocol m_CacheProtocol; //Field offset: 0x28
	private RequestCacheBinding m_CacheBinding; //Field offset: 0x30

	public override RequestCachePolicy CachePolicy
	{
		 set { } //Length: 189
	}

	internal RequestCacheProtocol CacheProtocol
	{
		internal get { } //Length: 5
		internal set { } //Length: 5
	}

	public override string ConnectionGroupName
	{
		 set { } //Length: 39
	}

	public override long ContentLength
	{
		 get { } //Length: 39
		 set { } //Length: 39
	}

	public override ICredentials Credentials
	{
		 get { } //Length: 39
		 set { } //Length: 39
	}

	public static RequestCachePolicy DefaultCachePolicy
	{
		 get { } //Length: 114
	}

	public override WebHeaderCollection Headers
	{
		 get { } //Length: 39
	}

	internal static IWebProxy InternalDefaultWebProxy
	{
		internal get { } //Length: 459
	}

	private static object InternalSyncObject
	{
		private get { } //Length: 234
	}

	public override string Method
	{
		 get { } //Length: 39
		 set { } //Length: 39
	}

	public override bool PreAuthenticate
	{
		 set { } //Length: 39
	}

	internal static ArrayList PrefixList
	{
		internal get { } //Length: 405
	}

	public override IWebProxy Proxy
	{
		 get { } //Length: 39
		 set { } //Length: 39
	}

	public override Uri RequestUri
	{
		 get { } //Length: 39
	}

	public override int Timeout
	{
		 get { } //Length: 39
		 set { } //Length: 39
	}

	public override bool UseDefaultCredentials
	{
		 get { } //Length: 39
	}

	private static WebRequest() { }

	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected WebRequest() { }

	[CompilerGenerated]
	private Task<Stream> <GetRequestStreamAsync>b__78_0() { }

	[CompilerGenerated]
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }

	public override void Abort() { }

	public override IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state) { }

	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	public static WebRequest Create(Uri requestUri) { }

	public static WebRequest Create(string requestUriString) { }

	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	public override Stream EndGetRequestStream(IAsyncResult asyncResult) { }

	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	internal RequestCacheProtocol get_CacheProtocol() { }

	public override long get_ContentLength() { }

	public override ICredentials get_Credentials() { }

	public static RequestCachePolicy get_DefaultCachePolicy() { }

	public override WebHeaderCollection get_Headers() { }

	internal static IWebProxy get_InternalDefaultWebProxy() { }

	private static object get_InternalSyncObject() { }

	public override string get_Method() { }

	internal static ArrayList get_PrefixList() { }

	public override IWebProxy get_Proxy() { }

	public override Uri get_RequestUri() { }

	public override int get_Timeout() { }

	public override bool get_UseDefaultCredentials() { }

	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	public override Task<Stream> GetRequestStreamAsync() { }

	public override WebResponse GetResponse() { }

	public override Task<WebResponse> GetResponseAsync() { }

	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	private static ArrayList PopulatePrefixList() { }

	private WindowsIdentity SafeCaptureIdenity() { }

	public override void set_CachePolicy(RequestCachePolicy value) { }

	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	public override void set_ConnectionGroupName(string value) { }

	public override void set_ContentLength(long value) { }

	public override void set_Credentials(ICredentials value) { }

	public override void set_Method(string value) { }

	public override void set_PreAuthenticate(bool value) { }

	public override void set_Proxy(IWebProxy value) { }

	public override void set_Timeout(int value) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

