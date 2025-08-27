namespace UnityEngine.Networking;

[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable
{
	internal enum Result
	{
		InProgress = 0,
		Success = 1,
		ConnectionError = 2,
		ProtocolError = 3,
		DataProcessingError = 4,
	}

	public enum UnityWebRequestError
	{
		OK = 0,
		OKCached = 1,
		Unknown = 2,
		SDKError = 3,
		UnsupportedProtocol = 4,
		MalformattedUrl = 5,
		CannotResolveProxy = 6,
		CannotResolveHost = 7,
		CannotConnectToHost = 8,
		AccessDenied = 9,
		GenericHttpError = 10,
		WriteError = 11,
		ReadError = 12,
		OutOfMemory = 13,
		Timeout = 14,
		HTTPPostError = 15,
		SSLCannotConnect = 16,
		Aborted = 17,
		TooManyRedirects = 18,
		ReceivedNoData = 19,
		SSLNotSupported = 20,
		FailedToSendData = 21,
		FailedToReceiveData = 22,
		SSLCertificateError = 23,
		SSLCipherNotAvailable = 24,
		SSLCACertError = 25,
		UnrecognizedContentEncoding = 26,
		LoginFailed = 27,
		SSLShutdownFailed = 28,
		RedirectLimitInvalid = 29,
		InvalidRedirect = 30,
		CannotModifyRequest = 31,
		HeaderNameContainsInvalidCharacters = 32,
		HeaderValueContainsInvalidCharacters = 33,
		CannotOverrideSystemHeaders = 34,
		AlreadySent = 35,
		InvalidMethod = 36,
		NotImplemented = 37,
		NoInternetConnection = 38,
		DataProcessingError = 39,
		InsecureConnectionNotAllowed = 40,
	}

	public enum UnityWebRequestMethod
	{
		Get = 0,
		Post = 1,
		Put = 2,
		Head = 3,
		Custom = 4,
	}

	public const string kHttpVerbGET = "GET"; //Field offset: 0x0
	public const string kHttpVerbHEAD = "HEAD"; //Field offset: 0x0
	public const string kHttpVerbPOST = "POST"; //Field offset: 0x0
	public const string kHttpVerbPUT = "PUT"; //Field offset: 0x0
	public const string kHttpVerbCREATE = "CREATE"; //Field offset: 0x0
	public const string kHttpVerbDELETE = "DELETE"; //Field offset: 0x0
	internal IntPtr m_Ptr; //Field offset: 0x10
	internal DownloadHandler m_DownloadHandler; //Field offset: 0x18
	internal UploadHandler m_UploadHandler; //Field offset: 0x20
	internal CertificateHandler m_CertificateHandler; //Field offset: 0x28
	internal Uri m_Uri; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; //Field offset: 0x3A

	public CertificateHandler certificateHandler
	{
		 get { } //Length: 7
		 set { } //Length: 259
	}

	public bool disposeCertificateHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool disposeDownloadHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool disposeUploadHandlerOnDispose
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ulong downloadedBytes
	{
		 get { } //Length: 51
	}

	public DownloadHandler downloadHandler
	{
		 get { } //Length: 7
		 set { } //Length: 259
	}

	public string error
	{
		 get { } //Length: 359
	}

	public bool isDone
	{
		 get { } //Length: 56
	}

	public bool isModifiable
	{
		[NativeMethod("IsModifiable")]
		 get { } //Length: 51
	}

	public string method
	{
		 get { } //Length: 222
		 set { } //Length: 592
	}

	public int redirectLimit
	{
		 set { } //Length: 64
	}

	public long responseCode
	{
		 get { } //Length: 51
	}

	public Result result
	{
		[NativeMethod("GetResult")]
		 get { } //Length: 51
	}

	public int timeout
	{
		 set { } //Length: 324
	}

	public UploadHandler uploadHandler
	{
		 get { } //Length: 159
		 set { } //Length: 259
	}

	public Uri uri
	{
		 get { } //Length: 123
		 set { } //Length: 231
	}

	public string url
	{
		 get { } //Length: 51
		 set { } //Length: 132
	}

	public UnityWebRequest(Uri uri, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler) { }

	public UnityWebRequest(Uri uri, string method) { }

	public UnityWebRequest(string url, string method) { }

	public UnityWebRequest(string url) { }

	[NativeMethod(IsThreadSafe = True)]
	public void Abort() { }

	[NativeThrows]
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	[NativeThrows]
	internal static IntPtr Create() { }

	public override void Dispose() { }

	private void DisposeHandlers() { }

	public static string EscapeURL(string s, Encoding e) { }

	public static string EscapeURL(string s) { }

	protected virtual void Finalize() { }

	public static Byte[] GenerateBoundary() { }

	public static UnityWebRequest Get(string uri) { }

	public CertificateHandler get_certificateHandler() { }

	[CompilerGenerated]
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	public bool get_disposeUploadHandlerOnDispose() { }

	public ulong get_downloadedBytes() { }

	public DownloadHandler get_downloadHandler() { }

	public string get_error() { }

	public bool get_isDone() { }

	[NativeMethod("IsModifiable")]
	public bool get_isModifiable() { }

	public string get_method() { }

	public long get_responseCode() { }

	[NativeMethod("GetResult")]
	public Result get_result() { }

	public UploadHandler get_uploadHandler() { }

	public Uri get_uri() { }

	public string get_url() { }

	internal string GetCustomMethod() { }

	private UnityWebRequestError GetError() { }

	[VisibleToOtherModules]
	internal static string GetHTTPStatusString(long responseCode) { }

	internal UnityWebRequestMethod GetMethod() { }

	public string GetResponseHeader(string name) { }

	internal String[] GetResponseHeaderKeys() { }

	public Dictionary<String, String> GetResponseHeaders() { }

	private string GetUrl() { }

	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	[NativeMethod(IsThreadSafe = True)]
	private static string GetWebErrorString(UnityWebRequestError err) { }

	internal void InternalDestroy() { }

	internal void InternalSetCustomMethod(string customMethodName) { }

	private void InternalSetDefaults() { }

	internal void InternalSetMethod(UnityWebRequestMethod methodType) { }

	[NativeMethod("SetRequestHeader")]
	internal UnityWebRequestError InternalSetRequestHeader(string name, string value) { }

	private void InternalSetUrl(string url) { }

	public static UnityWebRequest Post(Uri uri, WWWForm formData) { }

	public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, Byte[] boundary) { }

	public static UnityWebRequest Post(string uri, WWWForm formData) { }

	public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections) { }

	[NativeMethod(IsThreadSafe = True)]
	private void Release() { }

	public UnityWebRequestAsyncOperation SendWebRequest() { }

	public static Byte[] SerializeFormSections(List<IMultipartFormSection> multipartFormSections, Byte[] boundary) { }

	public void set_certificateHandler(CertificateHandler value) { }

	[CompilerGenerated]
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	public void set_downloadHandler(DownloadHandler value) { }

	public void set_method(string value) { }

	public void set_redirectLimit(int value) { }

	public void set_timeout(int value) { }

	public void set_uploadHandler(UploadHandler value) { }

	public void set_uri(Uri value) { }

	public void set_url(string value) { }

	private UnityWebRequestError SetCertificateHandler(CertificateHandler ch) { }

	private UnityWebRequestError SetCustomMethod(string customMethodName) { }

	private UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	private UnityWebRequestError SetMethod(UnityWebRequestMethod methodType) { }

	[NativeThrows]
	private void SetRedirectLimitFromScripting(int limit) { }

	public void SetRequestHeader(string name, string value) { }

	private UnityWebRequestError SetTimeoutMsec(int timeout) { }

	private UnityWebRequestError SetUploadHandler(UploadHandler uh) { }

	private static void SetupPost(UnityWebRequest request, WWWForm formData) { }

	private static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, Byte[] boundary) { }

	private UnityWebRequestError SetUrl(string url) { }

	public static string UnEscapeURL(string s) { }

	public static string UnEscapeURL(string s, Encoding e) { }

}

