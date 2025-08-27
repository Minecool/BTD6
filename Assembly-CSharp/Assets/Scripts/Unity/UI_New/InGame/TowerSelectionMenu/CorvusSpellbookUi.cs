namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class CorvusSpellbookUi : SecondarySelectionMenuUi
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CorvusSpellModel, CorvusSpellCategory> <>9__36_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal CorvusSpellCategory <CheckForNewSpells>b__36_0(CorvusSpellModel spellModel) { }

	}

	public static CorvusSpellbookUi instance; //Field offset: 0x0
	public CorvusSpellbookSpellUi baseSpell; //Field offset: 0x40
	public GridLayoutGroup itemGroup; //Field offset: 0x48
	public Animator animator; //Field offset: 0x50
	public NK_TextMeshProUGUI levelText; //Field offset: 0x58
	public Image xpBar; //Field offset: 0x60
	public NK_TextMeshProUGUI manaPoolText; //Field offset: 0x68
	public Image manaBar; //Field offset: 0x70
	private bool isPopulated; //Field offset: 0x78
	private List<CorvusSpellbookSpellUi> uiItems; //Field offset: 0x80
	public bool ignoreSceneHit; //Field offset: 0x88
	public Button castButton; //Field offset: 0x90
	public Button deactivateButton; //Field offset: 0x98
	public NK_TextMeshProUGUI unlocksAtText; //Field offset: 0xA0
	public GameObject manaDrainingObject; //Field offset: 0xA8
	public Animator gainManaAnimator; //Field offset: 0xB0
	public bool isDraggingOut; //Field offset: 0xB8

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
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public virtual TowerBasedShopItemModel TowerBasedShopItemModel
	{
		 get { } //Length: 127
	}

	public CorvusSpellbookUi() { }

	private void AddSpellButton(CorvusSpellModel corvusSpellModel, int corvusLevel) { }

	private void Awake() { }

	private void CheckForNewSpells() { }

	public void Close() { }

	public void DeactivateSelectedSpell() { }

	public void EndPlacement() { }

	public virtual Animator get_Animator() { }

	private UnityToSimulation get_Bridge() { }

	public virtual bool get_IgnoreSceneHit() { }

	public virtual TowerBasedShopItemModel get_TowerBasedShopItemModel() { }

	private CorvusSpellbookSpellUi GetUiItem(string name) { }

	public bool InsideMenuRect(Vector2 pos) { }

	public virtual void InvokeButtonPress(string buttonId) { }

	public void OnCastButton() { }

	private void OnDestroy() { }

	private void OnRoundEnd(int roundnumber) { }

	private void OnRoundStart(int roundNumber) { }

	public virtual void OnShow() { }

	private void OnSpecialUiEvent(string eventId) { }

	private void OnTowerUpgraded(TowerToSimulation towerToSim) { }

	private void OnUpdateCorvusUiFromSim() { }

	private void Populate() { }

	public virtual void Select(TowerBasedShopMenuItemUi itemToSelect) { }

	public virtual void set_IgnoreSceneHit(bool value) { }

	public void StartListeners() { }

	public void StartPlacement(CorvusSpellModel corvusSpellModel) { }

	public void Update() { }

	private void UpdateCastButton() { }

	public void UpdateCooldowns() { }

	public void UpdateCorvusMana() { }

	public void UpdateCorvusXp() { }

	public void UpdateDeactivateButton() { }

	protected virtual void UpdateDescription() { }

	public void UpdatePlacer(Vector2 pos, bool canPlace) { }

	public void UpdateSpellbookUiSpells() { }

	public virtual void UpdateUi() { }

}

