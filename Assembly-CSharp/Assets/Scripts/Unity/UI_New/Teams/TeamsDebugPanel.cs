namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsDebugPanel : MonoBehaviour
{
	public Button showBtn; //Field offset: 0x20
	public Lightbox backBtn; //Field offset: 0x28
	public GameObject debugPanel; //Field offset: 0x30
	public GameObject copyCodeTick; //Field offset: 0x38
	public Button refreshGuildBtn; //Field offset: 0x40
	public Button copyGuildIdBtn; //Field offset: 0x48
	public Button leaveGuildBtn; //Field offset: 0x50
	public Button toggleAutoJoinBtn; //Field offset: 0x58
	public NK_TextMeshProUGUI guildLeaveTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI guildIdTxt; //Field offset: 0x68
	public NK_TextMeshProUGUI guildShortCodeTxt; //Field offset: 0x70
	public NK_TextMeshProUGUI guildNameTxt; //Field offset: 0x78
	public NK_TextMeshProUGUI guildOwnerTxt; //Field offset: 0x80
	public NK_TextMeshProUGUI guildTagLineTxt; //Field offset: 0x88
	public NK_TextMeshProUGUI guildIsFullTxt; //Field offset: 0x90
	public NK_TextMeshProUGUI guildNumMembersPendingTxt; //Field offset: 0x98
	public NK_TextMeshProUGUI guildMaxMembersTxt; //Field offset: 0xA0
	public NK_TextMeshProUGUI guildNumMembersTxt; //Field offset: 0xA8
	public NK_TextMeshProUGUI guildAutoJoinEnabledTxt; //Field offset: 0xB0
	public NK_TextMeshProUGUI currentGuildTxt; //Field offset: 0xB8
	public Button joinGuildBtn; //Field offset: 0xC0
	public TMP_InputField joinGuildInput; //Field offset: 0xC8
	public NK_TextMeshProUGUI guildJoinedStateTxt; //Field offset: 0xD0
	public Button createGuildBtn; //Field offset: 0xD8
	public TMP_InputField createGuildInput; //Field offset: 0xE0
	public Button openTeamBrowser; //Field offset: 0xE8
	public Button clearInvitesSentList; //Field offset: 0xF0
	private bool showingPanel; //Field offset: 0xF8

	public TeamsDebugPanel() { }

}

