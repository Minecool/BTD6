namespace NinjaKiwi.LiNK.Endpoints;

public class User_Find : Endpoint<Dictionary`2<String, UserModel>>
{
	[CompilerGenerated]
	private struct <Call>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<UserModel> <>t__builder; //Field offset: 0x8
		public string key; //Field offset: 0x20
		public User_Find <>4__this; //Field offset: 0x28
		public Method method; //Field offset: 0x30
		public bool includeOnlineStatus; //Field offset: 0x34
		private UserModel <userModel>5__2; //Field offset: 0x38
		private TaskAwaiter<Dictionary`2<String, UserModel>> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum Method
	{
		EMAIL = 0,
		LiNK_ID = 1,
		PROVIDER_ID = 2,
		DISPLAY_NAME = 3,
		SHORTCODE = 4,
	}


	internal User_Find(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Dictionary`2<String, UserModel>> Call(IEnumerable<String> keys, Method method, bool includeOnlineStatus = false) { }

	[AsyncStateMachine(typeof(<Call>d__3))]
	public Task<UserModel> Call(string key, Method method, bool includeOnlineStatus = false) { }

	protected virtual Dictionary<String, UserModel> Receive(string json) { }

}

