namespace Assets.Scripts.Unity.UI_New.TrophyStore;

public class TrophyItemPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__59_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__59_0() { }

	}

	public Image icon; //Field offset: 0x20
	public Image typeIcon; //Field offset: 0x28
	public TMP_Text price; //Field offset: 0x30
	public TMP_Text saleOrgPrice; //Field offset: 0x38
	public TMP_Text shortName; //Field offset: 0x40
	public TMP_Text timeLeftText; //Field offset: 0x48
	public TMP_Text questBannerTxt; //Field offset: 0x50
	public Image standardBgImage; //Field offset: 0x58
	public Image purchasedBgImage; //Field offset: 0x60
	public Image selectedImage; //Field offset: 0x68
	public Color available; //Field offset: 0x70
	public Color unavailable; //Field offset: 0x80
	public GameObject saleBannerSprite; //Field offset: 0x90
	public GameObject newBannerSprite; //Field offset: 0x98
	public GameObject purchasedBannerSprite; //Field offset: 0xA0
	public GameObject notPurchasedGroup; //Field offset: 0xA8
	public GameObject enabledTick; //Field offset: 0xB0
	public GameObject limitedTime; //Field offset: 0xB8
	public GameObject questBanner; //Field offset: 0xC0
	public GameObject questLockedImage; //Field offset: 0xC8
	public GameObject questGlowImage; //Field offset: 0xD0
	public GameObject questRayImage; //Field offset: 0xD8
	public GameObject costBanner; //Field offset: 0xE0
	public GameObject container; //Field offset: 0xE8
	public Button button; //Field offset: 0xF0
	public TMP_Text emoteText; //Field offset: 0xF8
	public bool isPurchased; //Field offset: 0x100
	public bool isFeatured; //Field offset: 0x101
	public bool isEnabled; //Field offset: 0x102
	public bool isLimitedTime; //Field offset: 0x103
	public bool isQuestItem; //Field offset: 0x104
	public bool isQuestLocked; //Field offset: 0x105
	public bool isNexusItem; //Field offset: 0x106
	public bool hasClaimedBaseQuestRewards; //Field offset: 0x107
	public bool isQuestLimitedTime; //Field offset: 0x108
	public bool onSale; //Field offset: 0x109
	public bool isNew; //Field offset: 0x10A
	public bool showCost; //Field offset: 0x10B
	public bool hideQuestItemAsLinkedEventNotActive; //Field offset: 0x10C
	public bool hideUnOwnedNexusItems; //Field offset: 0x10D
	public int currentPrice; //Field offset: 0x110
	public TrophyStoreItem trophyStoreItem; //Field offset: 0x118
	private QuestDetails questDetails; //Field offset: 0x120
	private DateTime saleEndDate; //Field offset: 0x128
	public bool isPurchasing; //Field offset: 0x130
	[CompilerGenerated]
	private Action SaleEnded; //Field offset: 0x138

	public event Action SaleEnded
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool LimitedTimeExpired
	{
		 get { } //Length: 111
	}

	public QuestDetails QuestDetails
	{
		 get { } //Length: 8
	}

	public TrophyItemPanel() { }

	[CompilerGenerated]
	public void add_SaleEnded(Action value) { }

	public void Bind(TrophyItemBinding binding) { }

	public bool CanBeEnabled() { }

	public bool get_LimitedTimeExpired() { }

	public QuestDetails get_QuestDetails() { }

	public string GetQuestText(string defaultText) { }

	public void RefreshDisplay() { }

	[CompilerGenerated]
	public void remove_SaleEnded(Action value) { }

	public void SetSelected(bool selected) { }

	public bool ShowActive() { }

	public void Update() { }

}

