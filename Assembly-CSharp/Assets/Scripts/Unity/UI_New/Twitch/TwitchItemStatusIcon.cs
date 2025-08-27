namespace Assets.Scripts.Unity.UI_New.Twitch;

public class TwitchItemStatusIcon : MonoBehaviour
{
	public GameObject wonGo; //Field offset: 0x20
	public GameObject lostGo; //Field offset: 0x28
	public GameObject pendingGo; //Field offset: 0x30
	public GameObject votingGo; //Field offset: 0x38
	public GameObject completedGo; //Field offset: 0x40

	public TwitchItemStatusIcon() { }

	public void SetIcon(PollItemStatus status) { }

}

