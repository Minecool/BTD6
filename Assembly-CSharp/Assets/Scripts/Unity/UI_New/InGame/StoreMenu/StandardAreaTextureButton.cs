namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class StandardAreaTextureButton : CustomMapItemPurchaseButton
{
	public AreaTextureModel areaTextureModel; //Field offset: 0xA0
	[SerializeField]
	private GameObject waterIcon; //Field offset: 0xA8
	[SerializeField]
	private GameObject noPlaceIcon; //Field offset: 0xB0
	[SerializeField]
	private GameObject blockingIcon; //Field offset: 0xB8

	public StandardAreaTextureButton() { }

	public virtual void Awake() { }

	public virtual void Bind(EditorItemModel model, SpriteReference iconSprite, bool showVarients) { }

	public virtual void ButtonActivated(bool isFromHotkey = false) { }

	public int GetNumericId() { }

	protected virtual void OnItemClickedEvent() { }

	private void SetSelected(int textureId) { }

}

