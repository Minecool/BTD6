namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class GeraldoShopMenuUi : SecondarySelectionMenuUi
{
	public static GeraldoShopMenuUi instance; //Field offset: 0x0
	public GeraldoShopMenuItemUi baseItem; //Field offset: 0x40
	public GridLayoutGroup itemGroup; //Field offset: 0x48
	public Animator animator; //Field offset: 0x50
	public NK_TextMeshProUGUI levelText; //Field offset: 0x58
	public Image xpBar; //Field offset: 0x60
	private bool isPopulated; //Field offset: 0x68
	private bool wasStunnedLastFrame; //Field offset: 0x69
	private List<GeraldoShopMenuItemUi> uiItems; //Field offset: 0x70
	public bool ignoreSceneHit; //Field offset: 0x78

	public virtual Animator Animator
	{
		 get { } //Length: 5
	}

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	public virtual bool IgnoreSceneHit
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public virtual TowerBasedShopItemModel TowerBasedShopItemModel
	{
		 get { } //Length: 104
	}

	public GeraldoShopMenuUi() { }

	private void AddShopItemButton(GeraldoItemModel geraldoItemModel, int geraldoLevel) { }

	private void Awake() { }

	public void Close() { }

	public void EndPlacement() { }

	public virtual Animator get_Animator() { }

	private UnityToSimulation get_Bridge() { }

	public virtual bool get_IgnoreSceneHit() { }

	public virtual TowerBasedShopItemModel get_TowerBasedShopItemModel() { }

	private GeraldoShopMenuItemUi GetUiItem(string name) { }

	public bool InsideMenuRect(Vector2 pos) { }

	public virtual void InvokeButtonPress(string buttonId) { }

	private void OnCashChanged() { }

	private void OnCurrentRoundIncreased(int currentRound) { }

	private void OnDestroy() { }

	private void OnGeraldoItemPurchased(GeraldoItemModel geraldoItemModel, Vector2 position, int inputId) { }

	private void OnSceneHit() { }

	public virtual void OnShow() { }

	private void OnStockChanged() { }

	private void OnTowerSold(TowerToSimulation tower) { }

	private void OnTowerTransformed(TowerToSimulation towerToSimulation) { }

	private void OnTowerUpgraded(TowerToSimulation towerToSim) { }

	private void Populate() { }

	public void PurchaseFailed(GeraldoItemModel geraldoItemModel) { }

	public void PurchaseSuccess(GeraldoItemModel geraldoItemModel) { }

	public virtual void set_IgnoreSceneHit(bool value) { }

	public void StartListeners() { }

	public void StartPlacement(GeraldoItemModel geraldoItemModel) { }

	public void Update() { }

	public void UpdateGeraldoXp() { }

	public void UpdatePlacer(Vector2 pos, bool canPlace) { }

	public void UpdateShopUiItems() { }

	public virtual void UpdateUi() { }

}

