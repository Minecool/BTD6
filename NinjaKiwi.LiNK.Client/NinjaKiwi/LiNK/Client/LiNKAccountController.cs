namespace NinjaKiwi.LiNK.Client;

public class LiNKAccountController
{
	[CompilerGenerated]
	private struct <GetAuthProviderToken>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<AuthenticationProviderToken> <>t__builder; //Field offset: 0x8
		public AuthProviderType type; //Field offset: 0x20
		public LiNKAccountController <>4__this; //Field offset: 0x28
		private TaskAwaiter<FacebookToken> <>u__1; //Field offset: 0x30
		private TaskAwaiter<GooglePlayToken> <>u__2; //Field offset: 0x38
		private TaskAwaiter<GameCenterToken> <>u__3; //Field offset: 0x40
		private TaskAwaiter<NKWebsiteToken> <>u__4; //Field offset: 0x48
		private TaskAwaiter<EmailToken> <>u__5; //Field offset: 0x50
		private TaskAwaiter<KongToken> <>u__6; //Field offset: 0x58
		private TaskAwaiter<SteamToken> <>u__7; //Field offset: 0x60
		private TaskAwaiter<AppleToken> <>u__8; //Field offset: 0x68
		private TaskAwaiter<XboxToken> <>u__9; //Field offset: 0x70
		private TaskAwaiter<PlaystationToken> <>u__10; //Field offset: 0x78
		private TaskAwaiter<AppleArcadeToken> <>u__11; //Field offset: 0x80
		private TaskAwaiter<NetflixToken> <>u__12; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkToAuthProvider>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public AuthProviderType providerType; //Field offset: 0x28
		private TaskAwaiter<AuthenticationProviderToken> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LinkToAuthProvider>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public AuthenticationProviderToken token; //Field offset: 0x28
		private TaskAwaiter<UserModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadNewLiNKAccount>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public Identity newIdentity; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoginToAuthProvider>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public AuthProviderType providerType; //Field offset: 0x28
		public bool tryCreateFirst; //Field offset: 0x2C
		private TaskAwaiter<AuthenticationProviderToken> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoginToAuthProvider>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public AuthenticationProviderToken token; //Field offset: 0x28
		public bool tryCreateFirst; //Field offset: 0x30
		private TaskAwaiter<Identity> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LogInToNewChildAccount>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		private string <recoverCode>5__2; //Field offset: 0x28
		private TaskAwaiter<Response> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshLiNKAccountDetails>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private TaskAwaiter<UserModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action<LiNKAccount> NewLiNKAccountEvent; //Field offset: 0x10
	[CompilerGenerated]
	private Action<LiNKAccount> LiNKAccountUpdatedEvent; //Field offset: 0x18
	public readonly Api liNK; //Field offset: 0x20
	public readonly AuthenticationProvidersCollection authenticationProviders; //Field offset: 0x28
	[CompilerGenerated]
	private LiNKAccount <LiNKAccount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Func<LiNKAccount, Task> LoadNewLiNKAccountEvent; //Field offset: 0x38
	internal readonly Logger logger; //Field offset: 0x40
	private AuthenticationProviderToken currentAuthProviderToken; //Field offset: 0x48
	private bool deactivated; //Field offset: 0x50

	public event Action<LiNKAccount> LiNKAccountUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	internal event Func<LiNKAccount, Task> LoadNewLiNKAccountEvent
	{
		[CompilerGenerated]
		internal add { } //Length: 172
		[CompilerGenerated]
		internal remove { } //Length: 172
	}

	public event Action<LiNKAccount> NewLiNKAccountEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public private LiNKAccount LiNKAccount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public LiNKAccountController(Api liNK, LiNKAccount existingLiNKAccount = null) { }

	[CompilerGenerated]
	public void add_LiNKAccountUpdatedEvent(Action<LiNKAccount> value) { }

	[CompilerGenerated]
	internal void add_LoadNewLiNKAccountEvent(Func<LiNKAccount, Task> value) { }

	[CompilerGenerated]
	public void add_NewLiNKAccountEvent(Action<LiNKAccount> value) { }

	private void CheckDeactivated() { }

	internal void Deactivate() { }

	[CompilerGenerated]
	public LiNKAccount get_LiNKAccount() { }

	[AsyncStateMachine(typeof(<GetAuthProviderToken>d__30))]
	private Task<AuthenticationProviderToken> GetAuthProviderToken(AuthProviderType type) { }

	[AsyncStateMachine(typeof(<LinkToAuthProvider>d__25))]
	public Task LinkToAuthProvider(AuthenticationProviderToken token) { }

	[AsyncStateMachine(typeof(<LinkToAuthProvider>d__24))]
	public Task LinkToAuthProvider(AuthProviderType providerType) { }

	[AsyncStateMachine(typeof(<LoadNewLiNKAccount>d__29))]
	private Task LoadNewLiNKAccount(Identity newIdentity) { }

	public void LoadNewLiNKAccountDetails(UserModel userModel) { }

	[AsyncStateMachine(typeof(<LoginToAuthProvider>d__21))]
	public Task LoginToAuthProvider(AuthProviderType providerType, bool tryCreateFirst = true) { }

	public Task LoginToAuthProvider() { }

	[AsyncStateMachine(typeof(<LoginToAuthProvider>d__22))]
	public Task LoginToAuthProvider(AuthenticationProviderToken token, bool tryCreateFirst = true) { }

	[AsyncStateMachine(typeof(<LogInToNewChildAccount>d__23))]
	public Task<String> LogInToNewChildAccount() { }

	public Task LogPlayerIn(LoginResponseModel loginResponseModel) { }

	[AsyncStateMachine(typeof(<RefreshLiNKAccountDetails>d__27))]
	public Task RefreshLiNKAccountDetails(CancellationToken canceller) { }

	[CompilerGenerated]
	public void remove_LiNKAccountUpdatedEvent(Action<LiNKAccount> value) { }

	[CompilerGenerated]
	internal void remove_LoadNewLiNKAccountEvent(Func<LiNKAccount, Task> value) { }

	[CompilerGenerated]
	public void remove_NewLiNKAccountEvent(Action<LiNKAccount> value) { }

	[CompilerGenerated]
	private void set_LiNKAccount(LiNKAccount value) { }

	private void TriggerEvent(Action<T> eventToTrigger, T data) { }

}

