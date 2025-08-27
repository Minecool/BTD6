namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public static class LiNKSocialHelpers
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public string linkID; //Field offset: 0x10
		public GameMenu menu; //Field offset: 0x18
		public ButtonsInteractableCallback buttonsInteractableCallback; //Field offset: 0x20

		public <>c__DisplayClass1_0() { }

		internal Task <OpenPlayersProfile>b__0() { }

	}

	[CompilerGenerated]
	private struct <GetPlayerStats>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Btd6PlayerStats> <>t__builder; //Field offset: 0x8
		public string playerId; //Field offset: 0x20
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenPlayersProfileAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ButtonsInteractableCallback buttonsInteractableCallback; //Field offset: 0x20
		public string linkID; //Field offset: 0x28
		public GameMenu menu; //Field offset: 0x30
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ButtonsInteractableCallback : MulticastDelegate
	{

		public ButtonsInteractableCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool interactable, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool interactable) { }

	}


	public static void AutoDashFriendInput(TMP_InputField textField, string s) { }

	public static string FormatFriendCode(string code) { }

	[AsyncStateMachine(typeof(<GetPlayerStats>d__3))]
	private static Task<Btd6PlayerStats> GetPlayerStats(string playerId) { }

	public static void OpenPlayersProfile(string linkID, GameMenu menu, ButtonsInteractableCallback buttonsInteractableCallback = null) { }

	[AsyncStateMachine(typeof(<OpenPlayersProfileAsync>d__2))]
	private static Task OpenPlayersProfileAsync(string linkID, GameMenu menu, ButtonsInteractableCallback buttonsInteractableCallback = null) { }

	public static string ParseFriendCode(string code) { }

	public static char ValidateInput(char c) { }

}

