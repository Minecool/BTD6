namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class MailboxLetter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <<Bind>g__getOpenButtons|23_0>d : IEnumerable<Button>, IEnumerable, IEnumerator<Button>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Button <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public MailboxLetter <>4__this; //Field offset: 0x28

		private override Button System.Collections.Generic.IEnumerator<UnityEngine.UI.Button>.Current
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
		public <<Bind>g__getOpenButtons|23_0>d(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Button> System.Collections.Generic.IEnumerable<UnityEngine.UI.Button>.GetEnumerator() { }

		[DebuggerHidden]
		private override Button System.Collections.Generic.IEnumerator<UnityEngine.UI.Button>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	protected NK_TextMeshProUGUI letterDescriptionTxt; //Field offset: 0x20
	[SerializeField]
	protected NK_TextMeshProUGUI letterDateTxt; //Field offset: 0x28
	[SerializeField]
	protected GameObject newMailPipObj; //Field offset: 0x30
	[SerializeField]
	protected Button binButton; //Field offset: 0x38
	[SerializeField]
	private Button visibleOpenButton; //Field offset: 0x40
	[SerializeField]
	private Button invisibleOpenButton; //Field offset: 0x48
	protected UnityAction onDelete; //Field offset: 0x50
	[CompilerGenerated]
	private string <MessageId>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private DateTime <ReceivedTime>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <CanDelete>k__BackingField; //Field offset: 0x68

	private bool CanDelete
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool HasSeenMessage
	{
		 get { } //Length: 35
		 set { } //Length: 33
	}

	public string MessageId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public DateTime ReceivedTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public MailboxLetter() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<Bind>g__getOpenButtons|23_0>d))]
	private IEnumerable<Button> <Bind>g__getOpenButtons|23_0() { }

	private void Awake() { }

	public override void Bind(string messageId, string localizedMessage, DateTime receivedTime, bool hasSeenMessage, bool canDeleteMessage, UnityAction onOpen, UnityAction onDelete) { }

	private void DeleteToggled(bool isDeletionEnabled) { }

	public void EnableDelete(bool canDelete) { }

	[CompilerGenerated]
	private bool get_CanDelete() { }

	public bool get_HasSeenMessage() { }

	[CompilerGenerated]
	public string get_MessageId() { }

	[CompilerGenerated]
	public DateTime get_ReceivedTime() { }

	[CompilerGenerated]
	private void set_CanDelete(bool value) { }

	public void set_HasSeenMessage(bool value) { }

	[CompilerGenerated]
	protected void set_MessageId(string value) { }

	[CompilerGenerated]
	protected void set_ReceivedTime(DateTime value) { }

}

