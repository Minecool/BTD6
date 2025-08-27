namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class GeraldoShopMenuItemUi : TowerBasedShopMenuItemUi
{
	private enum ButtonAnimationState
	{
		EMPTY = 0,
		AVAILABLE = 1,
		CANT_AFFORD = 2,
		UNAVAILABLE = 3,
		MAX_USED = 4,
		RESTRICTED = 5,
	}

	public NK_TextMeshProUGUI quantity; //Field offset: 0x40
	public NK_TextMeshProUGUI cost; //Field offset: 0x48
	public Image quantityBar; //Field offset: 0x50
	public GeraldoItemModel geraldoItemModel; //Field offset: 0x58
	private SpriteReference currentIcon; //Field offset: 0x60
	private bool isLocked; //Field offset: 0x68

	public bool IsLocked
	{
		 get { } //Length: 5
	}

	public GeraldoShopMenuItemUi() { }

	public void ActivateFromHotkey() { }

	public bool get_IsLocked() { }

	public bool IsAvailable() { }

	public bool IsTowerRestricted() { }

	public bool ModeDisabled() { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPrime() { }

	public bool RoundDisabled() { }

	public void UpdateButtonState() { }

	public void UpdateUi(int geraldoLevel) { }

}

