namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class CurrentUpgrade : DynamicUiObject, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	public GameObject notUpgraded; //Field offset: 0x20
	public NK_TextMeshProUGUI label; //Field offset: 0x28
	public NK_TextMeshProUGUI cost; //Field offset: 0x30
	public Image icon; //Field offset: 0x38
	public SpriteReference backgroundActive; //Field offset: 0x40
	public SpriteReference backgroundInactive; //Field offset: 0x48
	public Animator wobbleAnimation; //Field offset: 0x50
	public Image background; //Field offset: 0x58
	public GameObject beastPowerGameObject; //Field offset: 0x60
	public GameObject beastPowerBorderGameObject; //Field offset: 0x68
	public GameObject beastMergedGameObject; //Field offset: 0x70
	public NK_TextMeshProUGUI beastPowerText; //Field offset: 0x78
	public NK_TextMeshProUGUI beastPowerMergedText; //Field offset: 0x80
	protected UpgradeModel current; //Field offset: 0x88
	protected string title; //Field offset: 0x90
	protected string desc; //Field offset: 0x98
	public int row; //Field offset: 0xA0
	protected TowerToSimulation currentTower; //Field offset: 0xA8
	protected float hoverPopupDelay; //Field offset: 0xB0
	protected bool hovering; //Field offset: 0xB4
	protected float hoverTimer; //Field offset: 0xB8

	public CurrentUpgrade() { }

	public ValueTuple<Boolean, String, String> GetShowTitleDesc() { }

	public UpgradeModel GetUpgradeModel() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	protected void SetImageActive(GameObject obj, bool active) { }

	protected void SetTextActive(GameObject obj, bool active) { }

	public void SetUpgradeModel(UpgradeModel um, TowerToSimulation currentTower) { }

	public void Update() { }

	private void UpdateBeastHandlerDisplay() { }

	public override void UpdateVisuals() { }

	public void WobbleUpgrade() { }

}

