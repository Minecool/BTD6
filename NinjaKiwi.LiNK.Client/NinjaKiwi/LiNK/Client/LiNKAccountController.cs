namespace NinjaKiwi.LiNK.Client;

public class LiNKAccountController
{
	[CompilerGenerated]
	private struct <GetAuthProviderToken>d__31 : IAsyncStateMachine
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
	private struct <LinkToAuthProvider>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public AuthProviderType providerType; //Field offset: 0x28
		private LiNKAccount <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<AuthenticationProviderToken> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Load>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public LiNKAccountModel liNKAccountModel; //Field offset: 0x28
		private TaskAwaiter<LiNKAccount> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Login>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public AuthenticationProviderToken token; //Field offset: 0x28
		public bool trySignUpFirst; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<LiNKAccountModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoginToAuthProvider>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public AuthProviderType providerType; //Field offset: 0x28
		public bool trySignUpFirst; //Field offset: 0x2C
		private TaskAwaiter<AuthenticationProviderToken> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LogInToExistingChildAccount>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		public string recoveryCode; //Field offset: 0x28
		private TaskAwaiter<ChildLiNKAccountModel> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LogInToNewChildAccount>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public LiNKAccountController <>4__this; //Field offset: 0x20
		private ChildLiNKAccountModel <response>5__2; //Field offset: 0x28
		private TaskAwaiter<ChildLiNKAccountModel> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public readonly Api liNK; //Field offset: 0x10
	public readonly AuthenticationProvidersCollection authenticationProviders; //Field offset: 0x18
	internal readonly Logger logger; //Field offset: 0x20
	private readonly ILiNKAccountHolder liNKAccountHolder; //Field offset: 0x28
	private AuthenticationProviderToken currentAuthProviderToken; //Field offset: 0x30
	private bool deactivated; //Field offset: 0x38
	[CompilerGenerated]
	private Action<LiNKAccount> NewLiNKAccountEvent; //Field offset: 0x40
	[CompilerGenerated]
	private Action<LiNKAccount> LiNKAccountModifiedEvent; //Field offset: 0x48

	public event Action<LiNKAccount> LiNKAccountModifiedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<LiNKAccount> NewLiNKAccountEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public LiNKAccount LiNKAccount
	{
		 get { } //Length: 184
	}

	internal LiNKAccountController(Api liNK, ILiNKAccountHolder liNKAccountHolder) { }

	[CompilerGenerated]
	private void <MonitorLiNKAccountModification>b__26_0(LiNKAccount account) { }

	[CompilerGenerated]
	public void add_LiNKAccountModifiedEvent(Action<LiNKAccount> value) { }

	[CompilerGenerated]
	public void add_NewLiNKAccountEvent(Action<LiNKAccount> value) { }

	private void CheckNotDeactivated() { }

	internal void Deactivate() { }

	private void EnsureLiNKAccountExists() { }

	private void EnsureNoLiNKAccount() { }

	public LiNKAccount get_LiNKAccount() { }

	[AsyncStateMachine(typeof(<GetAuthProviderToken>d__31))]
	private Task<AuthenticationProviderToken> GetAuthProviderToken(AuthProviderType type) { }

	[AsyncStateMachine(typeof(<LinkToAuthProvider>d__15))]
	public Task LinkToAuthProvider(AuthProviderType providerType) { }

	public Task LinkToAuthProvider(AuthenticationProviderToken token) { }

	[AsyncStateMachine(typeof(<Load>d__19))]
	private Task Load(LiNKAccountModel liNKAccountModel) { }

	public void LoadNewLiNKAccountDetails(UserModel newUserModel) { }

	[AsyncStateMachine(typeof(<Login>d__18))]
	private Task Login(AuthenticationProviderToken token, bool trySignUpFirst) { }

	public Task LoginToAuthProvider(AuthenticationProviderToken token, bool trySignUpFirst = true) { }

	[AsyncStateMachine(typeof(<LoginToAuthProvider>d__10))]
	public Task LoginToAuthProvider(AuthProviderType providerType, bool trySignUpFirst = true) { }

	public Task LoginToAuthProvider(bool trySignUpFirst = true) { }

	[AsyncStateMachine(typeof(<LogInToExistingChildAccount>d__13))]
	public Task LogInToExistingChildAccount(string recoveryCode) { }

	[AsyncStateMachine(typeof(<LogInToNewChildAccount>d__12))]
	public Task<String> LogInToNewChildAccount() { }

	public Task LogPlayerIn(LiNKAccountModel liNKAccountModel) { }

	private void MonitorLiNKAccountModification(LiNKAccount liNKAccount) { }

	[CompilerGenerated]
	public void remove_LiNKAccountModifiedEvent(Action<LiNKAccount> value) { }

	[CompilerGenerated]
	public void remove_NewLiNKAccountEvent(Action<LiNKAccount> value) { }

}

