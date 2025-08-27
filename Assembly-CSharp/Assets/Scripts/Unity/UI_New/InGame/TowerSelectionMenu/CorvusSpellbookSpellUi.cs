namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class CorvusSpellbookSpellUi : TowerBasedShopMenuItemUi
{
	internal enum ButtonAnimationState
	{
		EMPTY = 0,
		AVAILABLE = 1,
		ACTIVE = 2,
		NOT_ENOUGH_MANA = 3,
	}

	private SpriteReference currentIcon; //Field offset: 0x40
	public NK_TextMeshProUGUI manaCost; //Field offset: 0x48
	public CorvusSpellModel corvusSpellModel; //Field offset: 0x50
	public GameObject isActiveGameObject; //Field offset: 0x58
	public Image activeImage; //Field offset: 0x60
	public Image cooldownImage; //Field offset: 0x68
	public GameObject cooldownObject; //Field offset: 0x70
	private bool isDragging; //Field offset: 0x78

	public CorvusSpellbookSpellUi() { }

	public void ActivateFromHotkey() { }

	public bool IsAvailable() { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnPrime() { }

	public void UpdateButtonState() { }

	public void UpdateCooldown(float cooldownPercent) { }

	public void UpdateUi(int corvusLevel) { }

}

