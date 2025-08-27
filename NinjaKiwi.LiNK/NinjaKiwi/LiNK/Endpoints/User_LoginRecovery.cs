namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginRecovery : Endpoint<ChildLiNKAccountModel>
{
	[CompilerGenerated]
	private struct <Call>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ChildLiNKAccountModel> <>t__builder; //Field offset: 0x8
		public string recoveryCode; //Field offset: 0x20
		public User_LoginRecovery <>4__this; //Field offset: 0x28
		private TaskAwaiter<ChildLiNKAccountModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	internal User_LoginRecovery(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	[AsyncStateMachine(typeof(<Call>d__1))]
	public Task<ChildLiNKAccountModel> Call(string recoveryCode) { }

}

