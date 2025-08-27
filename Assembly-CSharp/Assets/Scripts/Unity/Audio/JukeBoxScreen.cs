namespace Assets.Scripts.Unity.Audio;

public class JukeBoxScreen : GameMenu
{
	public NK_TextMeshProUGUI headingTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI availableTracksTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI playListTxt; //Field offset: 0x58
	public NK_TextMeshProUGUI currentTrackTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI addAllTxt; //Field offset: 0x68
	public NK_TextMeshProUGUI removeAllTxt; //Field offset: 0x70
	public TrackItem trackItemPrefab; //Field offset: 0x78
	public Image trackLength; //Field offset: 0x80
	public Image pauseImg; //Field offset: 0x88
	public Image playImg; //Field offset: 0x90
	public GameObject moveTrackUpObj; //Field offset: 0x98
	public GameObject moveTrackDownObj; //Field offset: 0xA0
	public GameObject trackContent; //Field offset: 0xA8
	public GameObject playlistContent; //Field offset: 0xB0
	public Button previewBtn; //Field offset: 0xB8
	public Button addAllBtn; //Field offset: 0xC0
	public Button removeAllBtn; //Field offset: 0xC8
	public Button prevTrackBtn; //Field offset: 0xD0
	public Button nextTrackBtn; //Field offset: 0xD8
	public Button moveTrackUpBtn; //Field offset: 0xE0
	public Button moveTrackDownBtn; //Field offset: 0xE8
	public Animator equalizerAnimator; //Field offset: 0xF0
	public Action<String> SelectTrackEvent; //Field offset: 0xF8
	public Action<String, Int32> AddToPlaylistEvent; //Field offset: 0x100
	public Action<Int32> RemoveFromPlaylistEvent; //Field offset: 0x108
	public GameObject nothingAvailableObj; //Field offset: 0x110
	public GameObject nothingInPlaylistObj; //Field offset: 0x118
	private List<TrackItem> trackItemsList; //Field offset: 0x120
	private List<TrackItem> playListItemsList; //Field offset: 0x128
	private List<TrackItemData> playListDataList; //Field offset: 0x130
	private string currentTrackId; //Field offset: 0x138
	private string previewTrackId; //Field offset: 0x140
	private AudioClip previewTrackClip; //Field offset: 0x148
	private bool previewPaused; //Field offset: 0x150
	private Dictionary<String, String> locTrackNames; //Field offset: 0x158
	private bool pauseTrackPositionFill; //Field offset: 0x160
	private AudioClip titleMusic; //Field offset: 0x168

	public JukeBoxScreen() { }

	[CompilerGenerated]
	private GameObject <Open>b__38_0() { }

	private void AddAllClicked() { }

	private void AddToPlayListClicked(string trackName, int index) { }

	private void AddTrackToPlaylist(int index) { }

	public void ClearSelectedTracks() { }

	public void ClearTrackEQ() { }

	public virtual void Close() { }

	private TrackItem FindCurrentTrackItem() { }

	private int GetTrackIndex(string trackName) { }

	private void Init() { }

	private bool IsLegendsTrackOrHiddenLimitedTimeItem(MusicItem track) { }

	private void LoadPlaylist() { }

	private void MoveTrackDown() { }

	private void MoveTrackUp() { }

	private void NextTrackClicked() { }

	public virtual void Open(object data) { }

	private void OrderTrackList() { }

	private void PlayNewTrack() { }

	private void PopulateTrackItem(GameObject content, MusicItem track) { }

	private void PreviewTrackClicked() { }

	private void PrevTrackClicked() { }

	private void RefreshPlayList() { }

	private void RemoveAllClicked() { }

	private void RemoveFromPlayListClicked(int index) { }

	private void RemoveTrackFromPlayList(int index, bool doSort = true) { }

	private void SelectedTrackClicked(string trackName) { }

	private void SetPreviewBtnImg(bool isPaused) { }

	private void SetTrackEQ(bool turnOn) { }

	private void ShowTrackBtns(bool show) { }

	private void Start() { }

	private void StopCurrentTrack() { }

	private void StopTitleMusic() { }

	private void Update() { }

	private void UpdateCurrentTrackTxt(string currentTrackName) { }

	private void UpdateDataListIndices() { }

	private void UpdateListIndices(List<TrackItem> trackList, GameObject nothingFoundObj) { }

	private void UpdateText() { }

	private void UpdateTrackDisplay() { }

	private void UpdateTrackTime() { }

}

