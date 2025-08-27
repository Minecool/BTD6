namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsCosmeticDisplayPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__44_0; //Field offset: 0x8
		public static ReturnCallback <>9__44_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal void <SetupPanel>b__44_0() { }

		internal void <SetupPanel>b__44_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public TeamsCosmeticDisplayPanel <>4__this; //Field offset: 0x10
		public AvatarItem item; //Field offset: 0x18
		public Dictionary<String, AvatarItem> list; //Field offset: 0x20
		public AvatarItemType itemType; //Field offset: 0x28

		public <>c__DisplayClass47_0() { }

		internal void <PopulateItem>b__0(bool selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public TeamsCosmeticDisplayPanel <>4__this; //Field offset: 0x10
		public BannerItem item; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal void <PopulateBannerItem>b__0(bool selected) { }

	}

	[CompilerGenerated]
	private struct <SetupPanel>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsCosmeticDisplayPanel <>4__this; //Field offset: 0x20
		public TeamsCreatePanel screen; //Field offset: 0x28
		public string selectedIconId; //Field offset: 0x30
		public string selectedFrameId; //Field offset: 0x38
		public string selectedBannerId; //Field offset: 0x40
		private TaskAwaiter<Dictionary`2<String, TeamStoreItemContributions>> <>u__1; //Field offset: 0x48
		private TaskAwaiter<TrophyStoreBankData> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class CosmeticSelectionChangedDelegate : MulticastDelegate
	{

		public CosmeticSelectionChangedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AvatarItem icon, AvatarItem frame, BannerItem banner, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(AvatarItem icon, AvatarItem frame, BannerItem banner) { }

	}

	internal enum CosmeticType
	{
		Icon = 0,
		Frame = 1,
		Banner = 2,
	}

	public AvatarItem itemIconPrefab; //Field offset: 0x20
	public AvatarItem itemFramePrefab; //Field offset: 0x28
	public BannerItem itemBannerPrefab; //Field offset: 0x30
	public GameObject contentIconPanel; //Field offset: 0x38
	public GameObject contentFramePanel; //Field offset: 0x40
	public GameObject contentBannerPanel; //Field offset: 0x48
	private Dictionary<String, AvatarItem> iconItems; //Field offset: 0x50
	private Dictionary<String, AvatarItem> frameItems; //Field offset: 0x58
	private Dictionary<String, BannerItem> bannerItems; //Field offset: 0x60
	private AvatarItem equippedIcon; //Field offset: 0x68
	private AvatarItem equippedFrame; //Field offset: 0x70
	private BannerItem equippedBanner; //Field offset: 0x78
	private string selectedIconId; //Field offset: 0x80
	private string selectedFrameId; //Field offset: 0x88
	private string selectedBannerId; //Field offset: 0x90
	private Dictionary<String, TeamStoreItemContributions> itemContributions; //Field offset: 0x98
	private TrophyStoreBankData trophyStoreBankData; //Field offset: 0xA0
	private TeamsCreatePanel screen; //Field offset: 0xA8
	[HideInInspector]
	public AvatarItem selectedIcon; //Field offset: 0xB0
	[HideInInspector]
	public AvatarItem selectedFrame; //Field offset: 0xB8
	[HideInInspector]
	public BannerItem selectedBanner; //Field offset: 0xC0
	[CompilerGenerated]
	private AvatarItem <SelectedLockedIcon>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private AvatarItem <SelectedLockedFrame>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private BannerItem <SelectedLockedBanner>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private CosmeticSelectionChangedDelegate CosmeticSelectionChanged; //Field offset: 0xE0

	public event CosmeticSelectionChangedDelegate CosmeticSelectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public bool ChangesDetected
	{
		 get { } //Length: 429
	}

	public bool HasLockedItemSelected
	{
		 get { } //Length: 195
	}

	public BannerItem SelectedLockedBanner
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public string SelectedLockedCosmeticId
	{
		 get { } //Length: 90
	}

	public AvatarItem SelectedLockedFrame
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public AvatarItem SelectedLockedIcon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public TeamsCosmeticDisplayPanel() { }

	[CompilerGenerated]
	public void add_CosmeticSelectionChanged(CosmeticSelectionChangedDelegate value) { }

	public void BannerItemClicked(BannerItem selectedItem, bool isSelected) { }

	public bool get_ChangesDetected() { }

	public bool get_HasLockedItemSelected() { }

	[CompilerGenerated]
	public BannerItem get_SelectedLockedBanner() { }

	public string get_SelectedLockedCosmeticId() { }

	[CompilerGenerated]
	public AvatarItem get_SelectedLockedFrame() { }

	[CompilerGenerated]
	public AvatarItem get_SelectedLockedIcon() { }

	private bool IsLimitedItem(string trophyStoreId) { }

	public void ItemClicked(AvatarItem selectedItem, bool isSelected, Dictionary<String, AvatarItem> items, AvatarItemType type) { }

	private void PopulateBannerItem(Transform transform, ProfileBanner banner) { }

	private void PopulateItem(Transform transform, ProfileAvatar icon, AvatarItem itemPrefab, Dictionary<String, AvatarItem> list, CosmeticType type, ref AvatarItem selectedItem, ref AvatarItem origionalSelectedItem) { }

	[CompilerGenerated]
	public void remove_CosmeticSelectionChanged(CosmeticSelectionChangedDelegate value) { }

	public void ResetSelected(string selectedIconId = "", string selectedFrameId = "", string selectedBannerId = "") { }

	public void ResetSelectedLockedItems() { }

	[CompilerGenerated]
	public void set_SelectedLockedBanner(BannerItem value) { }

	[CompilerGenerated]
	public void set_SelectedLockedFrame(AvatarItem value) { }

	[CompilerGenerated]
	public void set_SelectedLockedIcon(AvatarItem value) { }

	[AsyncStateMachine(typeof(<SetupPanel>d__44))]
	public Task SetupPanel(TeamsCreatePanel screen, string selectedIconId = "", string selectedFrameId = "", string selectedBannerId = "") { }

}

