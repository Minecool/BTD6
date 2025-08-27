namespace NinjaKiwi.LiNK;

public class ApiOptions
{
	public static readonly JsonSerializerSettings defaultJsonSettingsForLiNKHttp; //Field offset: 0x0
	public TimeSpan timeout; //Field offset: 0x10
	public Environments environment; //Field offset: 0x18
	public bool copySessionIDToAPI; //Field offset: 0x1C
	public JsonSerializerSettings jsonSettingsForLiNKHttp; //Field offset: 0x20
	public string rawHashForV2ProviderConfirmations; //Field offset: 0x28
	public HttpRequestFactory httpRequestFactory; //Field offset: 0x30

	public static HttpRequestFactory DefaultHttpRequestFactory
	{
		 get { } //Length: 206
	}

	private static ApiOptions() { }

	public ApiOptions() { }

	public static HttpRequestFactory get_DefaultHttpRequestFactory() { }

}

