namespace Assets.Scripts.Data.Quests;

public abstract class DialogueDataTaskInGame : DialogueDataTask
{
	[CompilerGenerated]
	private struct <TriggerDialogueEvent>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DialogueDataTaskInGame <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	protected InGame InGame
	{
		 get { } //Length: 54
	}

	public DialogueDataTaskInGame() { }

	public abstract void Bind(bool isLoadedSave) { }

	protected InGame get_InGame() { }

	private void OnCompleteAnimatedDialogueCallback() { }

	[AsyncStateMachine(typeof(<TriggerDialogueEvent>d__4))]
	protected void TriggerDialogueEvent() { }

	public abstract void Unbind() { }

}

