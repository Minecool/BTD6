namespace Assets.Scripts.Unity.UI_New.Teams;

public class FriendsDebugPanel : MonoBehaviour
{
	public Button showBtn; //Field offset: 0x20
	public Button backBtn; //Field offset: 0x28
	public GameObject debugPanel; //Field offset: 0x30
	public LinkFriendsScreen screen; //Field offset: 0x38
	public Button clearSentInvitesBtn; //Field offset: 0x40
	public NK_TextMeshProUGUI guildLeaveTxt; //Field offset: 0x48
	private bool showingPanel; //Field offset: 0x50

	private Btd6Player Player
	{
		private get { } //Length: 7
	}

	private ProfileModel PlayerData
	{
		private get { } //Length: 68
	}

	public FriendsDebugPanel() { }

	private Btd6Player get_Player() { }

	private ProfileModel get_PlayerData() { }

}

