namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsItemUnlockPopup : MonoBehaviour
{
	public TMP_Text title; //Field offset: 0x20
	public TMP_Text description; //Field offset: 0x28
	public Image image; //Field offset: 0x30
	public Button goButton; //Field offset: 0x38
	public Lightbox backgroundButton; //Field offset: 0x40
	public Action<TeamsStoreItem> OnGo; //Field offset: 0x48
	public Action<TeamsStoreItem> OnBack; //Field offset: 0x50
	private TeamsStoreItem item; //Field offset: 0x58

	public TeamsItemUnlockPopup() { }

	public void OnBackButton() { }

	public void OnGoButton() { }

	public void Show(TeamsStoreItem item) { }

	public void Start() { }

}

