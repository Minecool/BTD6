//Type is in global namespace

public class TrackItem : MonoBehaviour
{
	public NK_TextMeshProUGUI trackNameField; //Field offset: 0x20
	public Button selectTrackBtn; //Field offset: 0x28
	public Button addBtn; //Field offset: 0x30
	public Button minusBtn; //Field offset: 0x38
	public Button trophyStoreBtn; //Field offset: 0x40
	public Image selectBGImg; //Field offset: 0x48
	public Image trackItemBGImg; //Field offset: 0x50
	public Animator equalizerAnimator; //Field offset: 0x58
	public TrackItemData trackItemData; //Field offset: 0x60
	public Color normalTrackBGColor; //Field offset: 0x68
	public Color trophyTrackBGColor; //Field offset: 0x78
	public Color normalSelectBGColor; //Field offset: 0x88
	public Color trophySelectBGColor; //Field offset: 0x98
	private bool isTrophyItem; //Field offset: 0xA8
	private JukeBoxScreen jukeBoxScreen; //Field offset: 0xB0
	private bool inPlaylist; //Field offset: 0xB8

	public TrackItem() { }

	[CompilerGenerated]
	private void <Start>b__16_0(GameObject obj) { }

	[CompilerGenerated]
	private bool <TrophyStoreBtnClicked>b__31_0(TrophyStoreItem x) { }

	private void AddBtnClicked() { }

	private void ChangeBtnBG() { }

	public Selectable GetActiveGamepadSelectable() { }

	public int GetTrackIndex() { }

	public string GetTrackName() { }

	public bool InPlaylist() { }

	public bool IsTrophyItem() { }

	private void MinusBtnClicked() { }

	private void SelectTrack() { }

	private void SelectTrackClicked() { }

	public void SetBtns(bool addBtnActive) { }

	public void SetEQ(bool show) { }

	private void SetIfTrophyItem() { }

	public void SetInPlaylist(bool isInPlaylist) { }

	public void SetSelectTrackImg(bool active) { }

	public void SetTrackIndex(int trackIndex) { }

	public void SetTrackItem(string assetId, JukeBoxScreen jukeBoxScreen, string localizedTitle) { }

	private void Start() { }

	private void TrophyStoreBtnClicked() { }

}

