namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class StandardPropPurchaseButton : CustomMapItemPurchaseButton
{
	[SerializeField]
	private GameObject blockingIcon; //Field offset: 0xA0
	[SerializeField]
	private GameObject placementIcon; //Field offset: 0xA8
	[SerializeField]
	private GameObject tickObj; //Field offset: 0xB0
	[SerializeField]
	private GameObject varientsIcon; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI varientsCount; //Field offset: 0xC0
	[CompilerGenerated]
	private PropModel <PropModel>k__BackingField; //Field offset: 0xC8

	public private PropModel PropModel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public StandardPropPurchaseButton() { }

	public virtual void Bind(EditorItemModel model, SpriteReference iconSprite, bool showVarients) { }

	public virtual void ButtonActivated(bool isFromHotkey = false) { }

	[CompilerGenerated]
	public PropModel get_PropModel() { }

	protected virtual void OnItemClickedEvent() { }

	protected virtual void OnItemDoubleClickedEvent() { }

	protected virtual void OnItemLongPressSelectedEvent() { }

	public virtual void OnToggleChildVarientGroup(ItemVarientData data) { }

	protected virtual void OnToggleVarientsUI(bool showVarients) { }

	public void Select() { }

	[CompilerGenerated]
	private void set_PropModel(PropModel value) { }

	public virtual void StartDragging() { }

	public virtual void StartHighlight() { }

	public virtual void StopHighlight() { }

}

