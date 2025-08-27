namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorMusicSelectPanel : MonoBehaviour
{
	public EditorMenu editorMenu; //Field offset: 0x20
	public AudioPreviewModule audioPreviewMod; //Field offset: 0x28
	public GameObject trackContent; //Field offset: 0x30
	public EditorTrackItem editorTrackItemPrefab; //Field offset: 0x38
	public NK_TextMeshProUGUI musicTrackTxt; //Field offset: 0x40
	public Button closeBtn; //Field offset: 0x48
	private List<EditorTrackItem> trackItemsList; //Field offset: 0x50
	private string currentTrackName; //Field offset: 0x58

	public MapEditorMusicSelectPanel() { }

	public void ClearSelectedTracks() { }

	public void Close() { }

	public void DisplayCurrentTrack() { }

	private EditorTrackItem FindCurrentTrackItem() { }

	public void Init() { }

	private void OnSwitchMusicTrack(string track) { }

	public void Open() { }

	private void OrderTrackList() { }

	public void PlayPreview(string trackName) { }

	private void PopulateTrackItem(GameObject content, MusicItem track) { }

	public void RefreshDisplay() { }

}

