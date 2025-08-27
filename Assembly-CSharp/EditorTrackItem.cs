//Type is in global namespace

public class EditorTrackItem : MonoBehaviour
{
	public NK_TextMeshProUGUI trackNameField; //Field offset: 0x20
	public Button selectTrackBtn; //Field offset: 0x28
	public GameObject selectBG; //Field offset: 0x30
	public Animator equalizerAnimator; //Field offset: 0x38
	public TrackItemData trackItemData; //Field offset: 0x40
	private MapEditorMusicSelectPanel musicSelectPanel; //Field offset: 0x48

	public EditorTrackItem() { }

	public string GetTrackName() { }

	public void SelectTrack() { }

	private void SelectTrackClicked() { }

	private void SetEQ(bool show) { }

	public void SetSelectTrackDisplay(bool show) { }

	public void SetTrackItem(string assetId, MapEditorMusicSelectPanel musicSelectPanel, string localizedTitle) { }

	private void Start() { }

}

