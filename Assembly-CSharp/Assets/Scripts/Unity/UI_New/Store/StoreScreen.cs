namespace Assets.Scripts.Unity.UI_New.Store;

public class StoreScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__35_0; //Field offset: 0x8
		public static Func<IReadOnlyCollection`1<StoreItemSettings>, IEnumerable`1<StoreItemSettings>> <>9__36_0; //Field offset: 0x10
		public static Func<StoreItemSettings, ProductPanelType> <>9__36_2; //Field offset: 0x18
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"productButton", "priority"}])]
		public static Func<ValueTuple`2<ProductButton, Int32>, Int32> <>9__41_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <DisplayTabItems>b__41_1(ValueTuple<ProductButton, Int32> x) { }

		internal void <Open>b__35_0() { }

		internal IEnumerable<StoreItemSettings> <Refresh>b__36_0(IReadOnlyCollection<StoreItemSettings> x) { }

		internal ProductPanelType <Refresh>b__36_2(StoreItemSettings x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public StoreScreen <>4__this; //Field offset: 0x10
		public string selectedProductId; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal GameObject <Open>b__1() { }

		internal bool <Open>b__2(ProductButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public StoreItem productModel; //Field offset: 0x10

		public <>c__DisplayClass36_0() { }

		internal bool <Refresh>b__1(StoreItemSettings x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass41_0
	{
		public ProductButton productButton; //Field offset: 0x10

		public <>c__DisplayClass41_0() { }

		internal bool <DisplayTabItems>b__0(StoreItemSettings x) { }

	}

	public ProductButton productButtonSmallPrefab; //Field offset: 0x48
	public ProductButton productButtonLargePrefab; //Field offset: 0x50
	public LegendsProductButton legendsLargePrefab; //Field offset: 0x58
	public LegendsProductButton legendsExtraLargePrefab; //Field offset: 0x60
	public Transform largeProductContainerTemplate; //Field offset: 0x68
	public Transform smallProductContainerTemplate; //Field offset: 0x70
	public Transform disabledContentContainer; //Field offset: 0x78
	public Button restoreButton; //Field offset: 0x80
	public GameObject bg; //Field offset: 0x88
	public ScrollRect scrollRect; //Field offset: 0x90
	public Button gamepadInfoButton; //Field offset: 0x98
	public GameObject nexusInfo; //Field offset: 0xA0
	public GameObject newLegendsPip; //Field offset: 0xA8
	public ToggleGroup storeTabs; //Field offset: 0xB0
	public Toggle popularTab; //Field offset: 0xB8
	public Toggle monkeyMoneyTab; //Field offset: 0xC0
	public Toggle heroesMonkeysTab; //Field offset: 0xC8
	public Toggle modesTab; //Field offset: 0xD0
	public Toggle legendsTab; //Field offset: 0xD8
	public NK_TextMeshProUGUI popularTxt; //Field offset: 0xE0
	public NK_TextMeshProUGUI monkeyMoneyTxt; //Field offset: 0xE8
	public NK_TextMeshProUGUI heroesMonkeysTxt; //Field offset: 0xF0
	public NK_TextMeshProUGUI modesTxt; //Field offset: 0xF8
	public NK_TextMeshProUGUI legendsTxt; //Field offset: 0x100
	public AudioClip purchasedItemSound; //Field offset: 0x108
	public AudioClip openSound; //Field offset: 0x110
	private StoreCategoryFilter storeCategoryFilter; //Field offset: 0x118
	private readonly List<ProductButton> productButtons; //Field offset: 0x120
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"productButton", "priority"}])]
	private readonly List<ValueTuple`2<ProductButton, Int32>> activeButtons; //Field offset: 0x128
	private readonly List<Transform> activeButtonContainers; //Field offset: 0x130
	[CompilerGenerated]
	private StoreCategoryFilter <SelectedTab>k__BackingField; //Field offset: 0x138

	public static bool CanBuyLegends
	{
		 get { } //Length: 501
	}

	public private StoreCategoryFilter SelectedTab
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public StoreScreen() { }

	[CompilerGenerated]
	private void <InitStoreTabs>b__37_0(bool selected) { }

	[CompilerGenerated]
	private void <InitStoreTabs>b__37_1(bool selected) { }

	[CompilerGenerated]
	private void <InitStoreTabs>b__37_2(bool selected) { }

	[CompilerGenerated]
	private void <InitStoreTabs>b__37_3(bool selected) { }

	[CompilerGenerated]
	private void <InitStoreTabs>b__37_4(bool selected) { }

	private void Awake() { }

	public void DisplayTabItems() { }

	public static bool get_CanBuyLegends() { }

	[CompilerGenerated]
	public StoreCategoryFilter get_SelectedTab() { }

	private Transform GetContainerTemplate(ProductPanelType productPanelType) { }

	private ProductButton GetProductButtonTemplate(ProductPanelType productPanelType, StoreItem productModel) { }

	private void InitStoreTabs() { }

	private bool IsLegendsProduct(string productId) { }

	private void OnTabClicked(StoreCategoryFilter categoryFilter) { }

	public virtual void Open(object menuData) { }

	public void Refresh() { }

	public virtual void ReOpen(object data) { }

	public void RestorePurchases() { }

	private void SeenPipEvent() { }

	[CompilerGenerated]
	private void set_SelectedTab(StoreCategoryFilter value) { }

	private void Update() { }

}

