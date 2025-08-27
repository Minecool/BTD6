namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class MailboxLetter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public MailboxScreen mailboxScreen; //Field offset: 0x10
		public Action onOpen; //Field offset: 0x18
		public SweepstakesWinnerMessage sweepstakesWinnerMessage; //Field offset: 0x20
		public MailboxLetter <>4__this; //Field offset: 0x28

		public <>c__DisplayClass7_0() { }

		internal void <Bind>b__0() { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI letterDescriptionTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI letterDateTxt; //Field offset: 0x28
	[SerializeField]
	private GameObject newMailPipObj; //Field offset: 0x30
	[SerializeField]
	private Button binButton; //Field offset: 0x38
	[SerializeField]
	private Button claimButton; //Field offset: 0x40
	private MailboxScreen mailboxScreen; //Field offset: 0x48
	public string messageId; //Field offset: 0x50

	public MailboxLetter() { }

	public void Bind(MailboxScreen mailboxScreen, SweepstakesWinnerMessage sweepstakesWinnerMessage, bool hasSeenMessage, Action onOpen, string messageId) { }

	public void OnDeleteMailClicked() { }

}

