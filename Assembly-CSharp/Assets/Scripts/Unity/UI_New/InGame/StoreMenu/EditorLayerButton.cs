namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public abstract class EditorLayerButton : MonoBehaviour
{
	internal sealed class OnVisbilityToggled : MulticastDelegate
	{

		public OnVisbilityToggled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isVisible, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isVisible) { }

	}

	public Button button; //Field offset: 0x20
	public Button deleteLayerButton; //Field offset: 0x28
	public Image layerIcon; //Field offset: 0x30
	public Toggle visibleTgl; //Field offset: 0x38
	public NK_TextMeshProUGUI title; //Field offset: 0x40
	public GameObject selectedObj; //Field offset: 0x48
	public GameObject linkedLayerObj; //Field offset: 0x50
	public GameObject linkedLayerHighlightedObj; //Field offset: 0x58
	[CompilerGenerated]
	private int <CategoryLayerIndex>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <WorldSortingOrderIndex>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private bool <IsSelected>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private EditorMenuPopout <EditorMenuPopout>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <IsSortable>k__BackingField; //Field offset: 0x78

	public int CategoryLayerIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private EditorMenuPopout EditorMenuPopout
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool IsSelected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsSortable
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public LayerData LayerData
	{
		 get { } //Length: 44
	}

	public int WorldSortingOrder
	{
		 get { } //Length: 10
	}

	public int WorldSortingOrderIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected EditorLayerButton() { }

	[CompilerGenerated]
	private void <Initialise>b__40_0() { }

	[CompilerGenerated]
	private void <Initialise>b__40_1() { }

	public override void Awake() { }

	[CompilerGenerated]
	public int get_CategoryLayerIndex() { }

	[CompilerGenerated]
	public EditorMenuPopout get_EditorMenuPopout() { }

	[CompilerGenerated]
	public bool get_IsSelected() { }

	[CompilerGenerated]
	public bool get_IsSortable() { }

	public LayerData get_LayerData() { }

	public int get_WorldSortingOrder() { }

	[CompilerGenerated]
	public int get_WorldSortingOrderIndex() { }

	public abstract string GetId() { }

	public abstract LayerType GetLayerType() { }

	public abstract string GetLocalisedTitle() { }

	public override bool HasButtonWarnings() { }

	public override void Initialise(int categoryLayerIndex, int worldSortingIndex, object metaData = null) { }

	public abstract void OnButtonClicked() { }

	public abstract void OnDeleteLayerButtonClicked() { }

	protected abstract void OnSetSelectedTriggered(EditorLayerButton buttonSelected) { }

	public void OnSyncToggleStateWithoutNotify(bool isOn, bool triggerEvent = false) { }

	public override void OnUpdateLayerIcon() { }

	public override void OnVisibleToggleClicked(bool isOn) { }

	public override void ReorderWorldSortingOrder(int newWorldSortingOrderIndex) { }

	[CompilerGenerated]
	public void set_CategoryLayerIndex(int value) { }

	[CompilerGenerated]
	private void set_EditorMenuPopout(EditorMenuPopout value) { }

	[CompilerGenerated]
	public void set_IsSelected(bool value) { }

	[CompilerGenerated]
	protected void set_IsSortable(bool value) { }

	[CompilerGenerated]
	public void set_WorldSortingOrderIndex(int value) { }

	public void SetIconSprite(SpriteReference spriteRef) { }

	public void UpdateLayerConnections(bool isLinked, bool isHighlighted) { }

	public void UpdateSelectedState() { }

}

