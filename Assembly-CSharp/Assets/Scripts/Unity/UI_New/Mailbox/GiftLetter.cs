namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class GiftLetter : MailboxLetter
{
	[CompilerGenerated]
	private sealed class <<Bind>g__getActiveOpenButtons|5_0>d : IEnumerable<Button>, IEnumerable, IEnumerator<Button>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Button <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public GiftLetter <>4__this; //Field offset: 0x28

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
		public <<Bind>g__getActiveOpenButtons|5_0>d(int <>1__state) { }

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
	private GameObject claimButtonContainer; //Field offset: 0x70
	[SerializeField]
	private Button claimButton; //Field offset: 0x78
	[SerializeField]
	private Button openButton; //Field offset: 0x80
	[SerializeField]
	private GameObject openButtonContainer; //Field offset: 0x88
	[SerializeField]
	private Button panelButton; //Field offset: 0x90

	public GiftLetter() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<Bind>g__getActiveOpenButtons|5_0>d))]
	private IEnumerable<Button> <Bind>g__getActiveOpenButtons|5_0() { }

	public virtual void Bind(string messageId, string localizedMessage, DateTime receivedTime, bool hasSeenMessage, bool canDeleteMessage, UnityAction onOpen, UnityAction onDelete) { }

}

