namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public abstract class CustomMapItemPurchaseButton : ItemPurchaseButton
{
	[CompilerGenerated]
	private struct <SetIconDisplay>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpriteReference iconSprite; //Field offset: 0x20
		public CustomMapItemPurchaseButton <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnShowVarientsToggledEvent : MulticastDelegate
	{

		public OnShowVarientsToggledEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool showVarients, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool showVarients) { }

	}

	[CompilerGenerated]
	private EditorMenuPopout <EditorMenu>k__BackingField; //Field offset: 0x60
	[SerializeField]
	protected GameObject premiumPanelObj; //Field offset: 0x68
	[SerializeField]
	protected GameObject newObj; //Field offset: 0x70
	[SerializeField]
	private Image bg; //Field offset: 0x78
	[SerializeField]
	private Image icon; //Field offset: 0x80
	[SerializeField]
	private Material grayscaleMaterial; //Field offset: 0x88
	private EditorItemModel editorItemModel; //Field offset: 0x90
	protected bool variantIsHidden; //Field offset: 0x98
	[CompilerGenerated]
	private bool <IsCustomActor>k__BackingField; //Field offset: 0x99

	protected EditorMenuPopout EditorMenu
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Image Icon
	{
		 get { } //Length: 8
	}

	protected private bool IsCustomActor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected bool IsPrimaryVarient
	{
		 get { } //Length: 32
	}

	protected bool IsVariantAndHidden
	{
		 get { } //Length: 56
	}

	public int ItemId
	{
		 get { } //Length: 22
	}

	public string ItemName
	{
		 get { } //Length: 22
	}

	public string ItemVarientGroupId
	{
		 get { } //Length: 18
	}

	protected CustomMapItemPurchaseButton() { }

	public virtual void Awake() { }

	public override void Bind(EditorItemModel editorItemModel, SpriteReference iconSprite, bool showVarients) { }

	private void CheckToggleVarentsGroup() { }

	[CompilerGenerated]
	protected EditorMenuPopout get_EditorMenu() { }

	public Image get_Icon() { }

	[CompilerGenerated]
	protected bool get_IsCustomActor() { }

	protected bool get_IsPrimaryVarient() { }

	protected bool get_IsVariantAndHidden() { }

	public int get_ItemId() { }

	public string get_ItemName() { }

	public string get_ItemVarientGroupId() { }

	protected virtual void OnItemClickedEvent() { }

	protected virtual void OnItemDoubleClickedEvent() { }

	protected override void OnShowVarientsToggled(bool showVarients) { }

	public override void OnToggleChildVarientGroup(ItemVarientData data) { }

	protected override void OnToggleVarientsUI(bool showVarients) { }

	[CompilerGenerated]
	protected void set_EditorMenu(EditorMenuPopout value) { }

	[CompilerGenerated]
	private void set_IsCustomActor(bool value) { }

	[AsyncStateMachine(typeof(<SetIconDisplay>d__30))]
	private Task SetIconDisplay(SpriteReference iconSprite) { }

	public virtual void SetLocked() { }

	public virtual void StartDragging() { }

	public virtual void StopDragging() { }

}

