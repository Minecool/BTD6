namespace Assets.Scripts.Unity.UI_New.Twitch;

public class TwitchPollCreationPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction<Int32> <>9__31_1; //Field offset: 0x8
		public static Func<TwitchTowerButton, String> <>9__37_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <SelectAllClicked>b__37_0(TwitchTowerButton x) { }

		internal void <Start>b__31_1(int value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public string towerId; //Field offset: 0x10
		public TwitchPollCreationPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal bool <OnTowerClicked>b__0(TwitchTowerButton x) { }

		internal bool <OnTowerClicked>b__1(TwitchTowerButton x) { }

		internal int <OnTowerClicked>b__2(TwitchTowerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_1
	{
		public TwitchTowerButton x; //Field offset: 0x10

		public <>c__DisplayClass35_1() { }

		internal bool <OnTowerClicked>b__3(TowerDetailsModel y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public Btd6Player player; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal bool <GetAvailableTowers>b__0(TowerDetailsModel x) { }

		internal bool <GetAvailableTowers>b__1(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_1
	{
		public Dictionary<String, Int32> towerInventory; //Field offset: 0x10

		public <>c__DisplayClass39_1() { }

		internal bool <GetAvailableTowers>b__2(TowerDetailsModel x) { }

		internal bool <GetAvailableTowers>b__3(TowerDetailsModel x) { }

	}

	private const int kDurationDefault = 30; //Field offset: 0x0
	private const int kBitVotePriceDefault = 100; //Field offset: 0x0
	private const string kDurationKey = "twitch_duration"; //Field offset: 0x0
	private const string kPointVotePriceKey = "twitch_pointVotingPrice"; //Field offset: 0x0
	private const string kCanPointVoteKey = "twitch_canPointVote"; //Field offset: 0x0
	private const string kBitVotePriceKey = "twitch_bitVotingPrice"; //Field offset: 0x0
	private const string kCanBitVoteKey = "twitch_canBitVote"; //Field offset: 0x0
	private static int _maxWinners; //Field offset: 0x0
	private const int kMaxDropdownOption = 10; //Field offset: 0x0
	private const int kPointVotePriceDefault = 1000; //Field offset: 0x0
	public NK_TextMeshProUGUI requiredPollNumberTxt; //Field offset: 0x20
	public NK_TextMeshProUGUI totalDurationTxt; //Field offset: 0x28
	public Slider pollDurationSlider; //Field offset: 0x30
	public TMP_Text pollDurationTxt; //Field offset: 0x38
	public TMP_Dropdown maxWinners; //Field offset: 0x40
	public Button closeBtn; //Field offset: 0x48
	public Button createBtn; //Field offset: 0x50
	public Button selectAllBtn; //Field offset: 0x58
	public TwitchTowerButton towerDisplayPrefab; //Field offset: 0x60
	public Transform excludedTowers; //Field offset: 0x68
	public Transform includedTowers; //Field offset: 0x70
	public GameObject excludedTowersContent; //Field offset: 0x78
	public GameObject includedTowersContent; //Field offset: 0x80
	public Toggle bitVoteToggle; //Field offset: 0x88
	public Toggle pointVoteToggle; //Field offset: 0x90
	public TMP_InputField bitsPerVoteInput; //Field offset: 0x98
	public TMP_InputField pointsPerVoteInput; //Field offset: 0xA0
	public Button backgroundCloseBtn; //Field offset: 0xA8
	public Action OnCreatePollClicked; //Field offset: 0xB0
	private List<TowerDetailsModel> availableTowers; //Field offset: 0xB8
	private readonly List<TwitchTowerButton> selectedTowerButtons; //Field offset: 0xC0
	private readonly List<TwitchTowerButton> excludedTowerButtons; //Field offset: 0xC8
	private int _requiredPolls; //Field offset: 0xD0

	private int BitVotePrice
	{
		private get { } //Length: 78
		private set { } //Length: 58
	}

	private bool CanBitVote
	{
		private get { } //Length: 80
		private set { } //Length: 59
	}

	private bool CanPointVote
	{
		private get { } //Length: 80
		private set { } //Length: 59
	}

	private int Duration
	{
		private get { } //Length: 78
		private set { } //Length: 58
	}

	public private static int MaxWinners
	{
		 get { } //Length: 53
		private set { } //Length: 58
	}

	private int PointVotePrice
	{
		private get { } //Length: 78
		private set { } //Length: 58
	}

	public private int RequiredPolls
	{
		 get { } //Length: 7
		private set { } //Length: 116
	}

	public TwitchPollCreationPanel() { }

	[CompilerGenerated]
	private void <Start>b__31_0() { }

	[CompilerGenerated]
	private void <Start>b__31_2(bool value) { }

	[CompilerGenerated]
	private void <Start>b__31_3(bool value) { }

	[CompilerGenerated]
	private void <Start>b__31_4(string value) { }

	[CompilerGenerated]
	private void <Start>b__31_5(string value) { }

	[CompilerGenerated]
	private void <Start>b__31_6(float value) { }

	[CompilerGenerated]
	private void <Start>b__31_7() { }

	private void CreatePollClicked() { }

	private int get_BitVotePrice() { }

	private bool get_CanBitVote() { }

	private bool get_CanPointVote() { }

	private int get_Duration() { }

	public static int get_MaxWinners() { }

	private int get_PointVotePrice() { }

	public int get_RequiredPolls() { }

	private List<TowerDetailsModel> GetAvailableTowers() { }

	public List<PollItem> GetPollItems() { }

	private void OnDestroy() { }

	private void OnTowerClicked(string towerId) { }

	private int ParseInt(string txt) { }

	private void PollDurationChanged(float subPollDurationInSecs) { }

	private void SelectAllClicked() { }

	private void set_BitVotePrice(int value) { }

	private void set_CanBitVote(bool value) { }

	private void set_CanPointVote(bool value) { }

	private void set_Duration(int value) { }

	private static void set_MaxWinners(int value) { }

	private void set_PointVotePrice(int value) { }

	private void set_RequiredPolls(int value) { }

	private void SetContentSizes() { }

	private void SetMaxDropdown(int count) { }

	private void SetMonkeyIcons() { }

	private void Start() { }

}

