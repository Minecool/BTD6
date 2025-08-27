namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class StandardMapTextureButton : CustomMapItemPurchaseButton
{
	private MapTextureModel mapTextureModel; //Field offset: 0xA0
	[SerializeField]
	private GameObject waterIcon; //Field offset: 0xA8

	public MapTextureModel MapTextureModel
	{
		 get { } //Length: 8
	}

	public StandardMapTextureButton() { }

	public virtual void Bind(EditorItemModel model, SpriteReference iconSprite, bool showVarients) { }

	public virtual void ButtonActivated(bool isFromHotkey = false) { }

	public MapTextureModel get_MapTextureModel() { }

	public int GetNumericId() { }

	protected virtual void OnItemClickedEvent() { }

}

