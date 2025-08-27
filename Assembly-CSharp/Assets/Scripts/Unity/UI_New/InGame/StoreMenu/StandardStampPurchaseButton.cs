namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class StandardStampPurchaseButton : CustomMapItemPurchaseButton
{
	private StampTextureModel stampTextureModel; //Field offset: 0xA0

	public StandardStampPurchaseButton() { }

	public virtual void Bind(EditorItemModel model, SpriteReference iconSprite, bool showVarients) { }

	public virtual void ButtonActivated(bool isFromHotkey = false) { }

	protected virtual void OnItemClickedEvent() { }

	protected virtual void OnItemLongPressSelectedEvent() { }

	public virtual void StartDragging() { }

}

