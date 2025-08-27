//Type is in global namespace

public class UniWebViewAuthenticationFlow
{
	[CompilerGenerated]
	private sealed class <SendTokenRequest>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private object <>2__current; //Field offset: 0x0
		public UnityWebRequest request; //Field offset: 0x0
		public Action<Int64, String> errorAction; //Field offset: 0x0
		public UniWebViewAuthenticationFlow<TTokenType> <>4__this; //Field offset: 0x0
		public Action<TTokenType> finishAction; //Field offset: 0x0
		private UnityWebRequest <www>5__2; //Field offset: 0x0

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SendTokenRequest>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private IUniWebViewAuthenticationFlow<TTokenType> service; //Field offset: 0x0

	public UniWebViewAuthenticationFlow`1(IUniWebViewAuthenticationFlow<TTokenType> service) { }

	[CompilerGenerated]
	private void <StartAuth>b__2_0(UniWebViewAuthenticationSession _, string resultUrl) { }

	[CompilerGenerated]
	private void <StartAuth>b__2_1(UniWebViewAuthenticationSession _, int errorCode, string message) { }

	private void ExchangeToken(string response) { }

	private void ExchangeTokenErrored(long code, string message) { }

	private void ExchangeTokenFinished(TTokenType token) { }

	private string GetAuthUrl() { }

	private UnityWebRequest GetTokenRequest(Dictionary<String, String> args) { }

	public void RefreshToken(string refreshToken) { }

	private void RefreshTokenErrored(long code, string message) { }

	private void RefreshTokenFinished(TTokenType token) { }

	private IEnumerator SendExchangeTokenRequest(UnityWebRequest request) { }

	private IEnumerator SendRefreshTokenRequest(UnityWebRequest request) { }

	[IteratorStateMachine(typeof(<SendTokenRequest>d__9))]
	private IEnumerator SendTokenRequest(UnityWebRequest request, Action<TTokenType> finishAction, Action<Int64, String> errorAction) { }

	public void StartAuth() { }

}

