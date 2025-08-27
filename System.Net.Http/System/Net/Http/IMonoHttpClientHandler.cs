namespace System.Net.Http;

internal interface IMonoHttpClientHandler : IDisposable
{

	public SslClientAuthenticationOptions SslOptions
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public SslClientAuthenticationOptions get_SslOptions() { }

	public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) { }

	public void set_SslOptions(SslClientAuthenticationOptions value) { }

	public void SetWebRequestTimeout(TimeSpan timeout) { }

}

