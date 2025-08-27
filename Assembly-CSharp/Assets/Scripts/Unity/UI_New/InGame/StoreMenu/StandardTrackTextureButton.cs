namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class StandardTrackTextureButton : CustomMapItemPurchaseButton
{
	public TrackTextureModel trackTextureModel; //Field offset: 0xA0

	public StandardTrackTextureButton() { }

	public virtual void Awake() { }

	public virtual void Bind(EditorItemModel model, SpriteReference iconSprite, bool showVarients) { }

	public virtual void ButtonActivated(bool isFromHotkey = false) { }

	public int GetNumericId() { }

	protected virtual void OnItemClickedEvent() { }

	private void SetSelected(int textureId) { }

}

