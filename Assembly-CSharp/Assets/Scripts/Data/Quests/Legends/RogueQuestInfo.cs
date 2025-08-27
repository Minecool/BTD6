namespace Assets.Scripts.Data.Quests.Legends;

public class RogueQuestInfo : QuestBehavior
{
	[CompilerGenerated]
	private sealed class <GoToRogueMap>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public DialogueData dialogue; //Field offset: 0x20

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
		public <GoToRogueMap>d__4(int <>1__state) { }

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

	public RogueMapTemplate mapTemplate; //Field offset: 0x10
	public RogueGameSaveData startData; //Field offset: 0x18
	public Vector2Int startPosition; //Field offset: 0x20

	public RogueQuestInfo() { }

	public void ApplyDataFromJson(RogueGameSaveData newData) { }

	public virtual void DebugClearDataTriggered() { }

	[IteratorStateMachine(typeof(<GoToRogueMap>d__4))]
	private IEnumerator GoToRogueMap(DialogueData dialogue) { }

	public virtual bool OnStartGameOverride(QuestScreen screen, QuestDetails questDetails, QuestPartData partData, TaskData taskData) { }

}

