namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public abstract class ItemPurchaseButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler, IPointerClickHandler, IDraggable, IHighlightable, IDisablable
{
	private float selectionTimer; //Field offset: 0x20
	private float selectionTimerMax; //Field offset: 0x24
	private bool doubleClick; //Field offset: 0x28
	private float doubleClickTimer; //Field offset: 0x2C
	[SerializeField]
	protected GameObject highlight; //Field offset: 0x30
	[SerializeField]
	protected GameObject lockedIcon; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnItemClicked; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnItemDoubleClicked; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnItemLongPressSelected; //Field offset: 0x50
	private bool isLocked; //Field offset: 0x58
	private bool isDisabled; //Field offset: 0x59
	private bool isBeingDragged; //Field offset: 0x5A
	private bool isHighlighted; //Field offset: 0x5B

	public event Action OnItemClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action OnItemDoubleClicked
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action OnItemLongPressSelected
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public override bool IsBeingDragged
	{
		 get { } //Length: 5
	}

	public override bool IsDisabled
	{
		 get { } //Length: 5
	}

	public override bool IsHighlighted
	{
		 get { } //Length: 5
	}

	public override bool IsLocked
	{
		 get { } //Length: 5
	}

	protected ItemPurchaseButton() { }

	[CompilerGenerated]
	public void add_OnItemClicked(Action value) { }

	[CompilerGenerated]
	public void add_OnItemDoubleClicked(Action value) { }

	[CompilerGenerated]
	public void add_OnItemLongPressSelected(Action value) { }

	public override void Awake() { }

	protected void Bind() { }

	public override void ButtonActivated(bool isFromHotkey = false) { }

	public override void ButtonDeactivated() { }

	protected void CheckPointer() { }

	public override void DisableButton() { }

	public override void EnableButton() { }

	public override bool get_IsBeingDragged() { }

	public override bool get_IsDisabled() { }

	public override bool get_IsHighlighted() { }

	public override bool get_IsLocked() { }

	public override void OnDestroy() { }

	protected override void OnItemClickedEvent() { }

	protected override void OnItemDoubleClickedEvent() { }

	protected override void OnItemLongPressSelectedEvent() { }

	[CompilerGenerated]
	public void remove_OnItemClicked(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemDoubleClicked(Action value) { }

	[CompilerGenerated]
	public void remove_OnItemLongPressSelected(Action value) { }

	public override void SetLocked() { }

	public override void SetUnlocked() { }

	public override void StartDragging() { }

	public override void StartHighlight() { }

	public override void StopDragging() { }

	public override void StopHighlight() { }

	private override void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	protected override void Update() { }

}

