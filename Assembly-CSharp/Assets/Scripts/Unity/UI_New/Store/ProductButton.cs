namespace Assets.Scripts.Unity.UI_New.Store;

public class ProductButton : BaseProductButton
{
	private enum AnimState
	{
		Default = 0,
		LimitedTime = 1,
		Sale = 2,
		Promo = 3,
	}

	private StoreScreen storeScreen; //Field offset: 0x70
	public TMP_Text description; //Field offset: 0x78
	public LootPanel lootPanel; //Field offset: 0x80
	public Image bonusImage; //Field offset: 0x88
	public RectTransform buyGroup; //Field offset: 0x90
	public Transform saleTab; //Field offset: 0x98
	public TMP_Text saleOrigPrice; //Field offset: 0xA0
	[SerializeField]
	private ProductPanelType productPanelType; //Field offset: 0xA8
	[SerializeField]
	private ScrollRect lootPanelScrollRect; //Field offset: 0xB0
	[SerializeField]
	private float scrollSpeed; //Field offset: 0xB8
	public Animator animator; //Field offset: 0xC0
	private AnimState animationState; //Field offset: 0xC8
	[CompilerGenerated]
	private ProductPanelType <ProductPanelType>k__BackingField; //Field offset: 0xCC
	private float lootScrollRectPosition; //Field offset: 0xD0
	private bool isLootScrollIncrementing; //Field offset: 0xD4

	public string ProductId
	{
		 get { } //Length: 27
	}

	public private ProductPanelType ProductPanelType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ProductButton() { }

	protected override void Awake() { }

	public override void Bind(StoreScreen storeScreen, StoreItem productModel, ProductPanelType productPanelType) { }

	public string get_ProductId() { }

	[CompilerGenerated]
	public ProductPanelType get_ProductPanelType() { }

	protected virtual void OnBind(StoreItem productModel) { }

	private void OnDestroy() { }

	public virtual void OnPurchaseComplete() { }

	protected virtual void OnTemporarySaleFinished() { }

	[CompilerGenerated]
	private void set_ProductPanelType(ProductPanelType value) { }

	public void SetState() { }

	public void ShowPurchasePopup() { }

	public virtual void StartPurchase() { }

	protected virtual void Update() { }

}

