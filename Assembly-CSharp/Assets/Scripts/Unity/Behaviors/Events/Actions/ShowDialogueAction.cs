namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ShowDialogueAction : HudModifier
{
	[CompilerGenerated]
	private struct <ModifyHud>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ShowDialogueAction <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public DialogueDataAction dialogueToShow; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ShowDialogueAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

	[AsyncStateMachine(typeof(<ModifyHud>d__5))]
	public virtual void ModifyHud(HookCondition condition, object metadata) { }

	public void OnCompleteAnimatedDialogueCallback() { }

}

