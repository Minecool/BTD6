namespace Assets.Scripts.Unity.UI_New.Twitch;

public class TwitchPollPanelOption : MonoBehaviour
{
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x20
	public NK_TextMeshProUGUI votesTxt; //Field offset: 0x28
	public TwitchItemStatusIcon statusIcon; //Field offset: 0x30
	private uint _votes; //Field offset: 0x38
	private PollItemStatus _status; //Field offset: 0x3C

	public PollItemStatus Status
	{
		 get { } //Length: 4
		 set { } //Length: 33
	}

	public private string Title
	{
		 get { } //Length: 42
		private set { } //Length: 30
	}

	public uint Votes
	{
		 get { } //Length: 4
		 set { } //Length: 124
	}

	public TwitchPollPanelOption() { }

	public PollItemStatus get_Status() { }

	public string get_Title() { }

	public uint get_Votes() { }

	public void Init(string title) { }

	public void set_Status(PollItemStatus value) { }

	private void set_Title(string value) { }

	public void set_Votes(uint value) { }

}

