namespace Assets.Scripts.Data.Quests;

public class TaskData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <GetBehaviors>d__20 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public TaskData <>4__this; //Field offset: 0x0
		private SimulationBehavior[] <>7__wrap1; //Field offset: 0x0
		private int <>7__wrap2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetBehaviors>d__20`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetDialogues>d__18 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public TaskData <>4__this; //Field offset: 0x0
		private IEnumerator<DialogueDataTask> <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetDialogues>d__18`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetTaskBehaviors>d__19 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public TaskData <>4__this; //Field offset: 0x0
		private IEnumerator<TaskBehavior> <>7__wrap1; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <GetTaskBehaviors>d__19`1(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public string title; //Field offset: 0x18
	public string subTitle; //Field offset: 0x20
	public string victoryScreenLoc; //Field offset: 0x28
	public SpriteReference image; //Field offset: 0x30
	public SubGameType subGameType; //Field offset: 0x38
	[ExtendedDrawer]
	[ReorderableList("Dialogue", True)]
	[SerializeField]
	private DialogueDataTaskContainer DialogueDataTaskContainer; //Field offset: 0x40
	[ExtendedDrawer]
	[ReorderableList("Behaviors", True)]
	[SerializeField]
	private TaskBehaviorContainer TaskBehaviorContainer; //Field offset: 0x48
	[ExtendedDrawer]
	public ModModel TaskMods; //Field offset: 0x50
	public DailyChallengeData challengeData; //Field offset: 0x58

	public DailyChallengeModel DCM
	{
		 get { } //Length: 29
	}

	public IEnumerable<TaskBehavior> TaskBehaviors
	{
		 get { } //Length: 27
	}

	public IEnumerable<DialogueDataTask> TaskDialogues
	{
		 get { } //Length: 27
	}

	public TaskData() { }

	public DailyChallengeModel get_DCM() { }

	public IEnumerable<TaskBehavior> get_TaskBehaviors() { }

	public IEnumerable<DialogueDataTask> get_TaskDialogues() { }

	[IteratorStateMachine(typeof(<GetBehaviors>d__20`1))]
	public IEnumerable<T> GetBehaviors() { }

	[IteratorStateMachine(typeof(<GetDialogues>d__18`1))]
	public IEnumerable<T> GetDialogues() { }

	[IteratorStateMachine(typeof(<GetTaskBehaviors>d__19`1))]
	public IEnumerable<T> GetTaskBehaviors() { }

	public void ImportCustomMapModelData(CustomMapModel data) { }

	public void ImportDcmData(DailyChallengeModel data) { }

	public bool TryGetBehavior(out T data) { }

	public bool TryGetTaskBehavior(out T behavior) { }

	public bool TryGetTaskDialogue(out T data) { }

}

