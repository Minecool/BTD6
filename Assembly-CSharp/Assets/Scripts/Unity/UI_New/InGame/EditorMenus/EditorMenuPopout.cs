namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class EditorMenuPopout : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StoreItem, Boolean> <>9__350_0; //Field offset: 0x8
		public static Func<String, Boolean> <>9__351_1; //Field offset: 0x10
		public static Func<StandardMapTextureButton, Boolean> <>9__351_0; //Field offset: 0x18
		public static Func<String, Boolean> <>9__352_0; //Field offset: 0x20
		public static Func<String, Boolean> <>9__353_0; //Field offset: 0x28
		public static Func<String, Boolean> <>9__354_0; //Field offset: 0x30
		public static Func<MapEditorPropData, Boolean> <>9__356_0; //Field offset: 0x38
		public static Func<String, Boolean> <>9__356_1; //Field offset: 0x40
		public static Func<String, Boolean> <>9__357_0; //Field offset: 0x48
		public static Func<StandardPropPurchaseButton, PropSetType> <>9__360_0; //Field offset: 0x50
		public static Func<StandardPropPurchaseButton, Int32> <>9__360_2; //Field offset: 0x58
		public static Func<StandardPropPurchaseButton, Boolean> <>9__360_5; //Field offset: 0x60
		public static Func<StandardPropPurchaseButton, Int32> <>9__360_6; //Field offset: 0x68
		public static Comparison<EditorLayerButton> <>9__363_0; //Field offset: 0x70
		public static Predicate<PropLayerButton> <>9__370_0; //Field offset: 0x78
		public static Predicate<AreaLayerButton> <>9__464_0; //Field offset: 0x80
		public static Comparison<EditorLayerButton> <>9__514_0; //Field offset: 0x88

		private static <>c() { }

		public <>c() { }

		internal int <BindData>b__363_0(EditorLayerButton a, EditorLayerButton b) { }

		internal bool <BuildAreaSet>b__354_0(string packName) { }

		internal bool <BuildBackgroundSet>b__351_0(StandardMapTextureButton x) { }

		internal bool <BuildBackgroundSet>b__351_1(string packName) { }

		internal bool <BuildPathSet>b__352_0(string packName) { }

		internal bool <BuildPropPacksSet>b__350_0(StoreItem x) { }

		internal bool <BuildPropSet>b__356_0(MapEditorPropData x) { }

		internal bool <BuildPropSet>b__356_1(string packName) { }

		internal bool <BuildSpecialEffectPropSet>b__357_0(string packName) { }

		internal bool <BuildStampSet>b__353_0(string packName) { }

		internal bool <OnUpdateLinkedLayerIcons>b__464_0(AreaLayerButton x) { }

		internal bool <RecreatePropGroupLayerButtonList>b__370_0(PropLayerButton x) { }

		internal int <SortMainLayersDefaultElementsToTop>b__514_0(EditorLayerButton x, EditorLayerButton y) { }

		internal PropSetType <SortPropButtonList>b__360_0(StandardPropPurchaseButton x) { }

		internal int <SortPropButtonList>b__360_2(StandardPropPurchaseButton x) { }

		internal bool <SortPropButtonList>b__360_5(StandardPropPurchaseButton x) { }

		internal int <SortPropButtonList>b__360_6(StandardPropPurchaseButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__509
	{
		public static readonly <>c__509<T> <>9; //Field offset: 0x0
		public static Func<T, Int32> <>9__509_0; //Field offset: 0x0

		private static <>c__509`1() { }

		public <>c__509`1() { }

		internal int <FindFirstUnusedIndex>b__509_0(T obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass266_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass266_0() { }

		internal bool <GetLayerButtonWithId>b__0(EditorLayerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass360_0
	{
		public HashSet<Int32> processedItemIndices; //Field offset: 0x10

		public <>c__DisplayClass360_0() { }

		internal bool <SortPropButtonList>b__3(StandardPropPurchaseButton _, int index) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass360_1
	{
		public StandardPropPurchaseButton currentItem; //Field offset: 0x10

		public <>c__DisplayClass360_1() { }

		internal bool <SortPropButtonList>b__4(StandardPropPurchaseButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass369_0
	{
		public MapEditorStampData data; //Field offset: 0x10

		public <>c__DisplayClass369_0() { }

		internal bool <RecreateStampLayerButtonList>b__0(StampLayerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass370_0
	{
		public MapEditorPropData data; //Field offset: 0x10

		public <>c__DisplayClass370_0() { }

		internal bool <RecreatePropGroupLayerButtonList>b__1(PropLayerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass371_0
	{
		public MapEditorPropData data; //Field offset: 0x10

		public <>c__DisplayClass371_0() { }

		internal bool <RecreateSpecialPropGroupLayerButtonList>b__0(SpecialPropLayerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass429_0
	{
		public PropModel propModel; //Field offset: 0x10

		public <>c__DisplayClass429_0() { }

		internal bool <GetPropButton>b__0(StandardPropPurchaseButton x) { }

		internal bool <GetPropButton>b__1(StandardPropPurchaseButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass432_0
	{
		public EditorMenuPopout <>4__this; //Field offset: 0x10
		public PropLayerButton button; //Field offset: 0x18

		public <>c__DisplayClass432_0() { }

		internal void <OnClickedDeletePropGroup>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass438_0
	{
		public EditorMenuPopout <>4__this; //Field offset: 0x10
		public SpecialPropLayerButton button; //Field offset: 0x18

		public <>c__DisplayClass438_0() { }

		internal void <OnClickedDeleteSpecialPropGroup>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass477_0
	{
		public StandardPropPurchaseButton <propButton>5__2; //Field offset: 0x10

		public <>c__DisplayClass477_0() { }

		internal void <OnToggleChildVarientGroupEventTriggered>b__0(StandardPropPurchaseButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass507_0
	{
		public Type buttonType; //Field offset: 0x0
		public Predicate<T> <>9__0; //Field offset: 0x0

		public <>c__DisplayClass507_0`1() { }

		internal bool <FindIndexForMainLayerInsert>b__0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass507_1
	{
		public Type layerType; //Field offset: 0x0

		public <>c__DisplayClass507_1`1() { }

		internal bool <FindIndexForMainLayerInsert>b__1(T x) { }

	}

	[CompilerGenerated]
	private struct <OnCreateAreaClicked>d__409 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EditorMenuPopout <>4__this; //Field offset: 0x28
		public StandardAreaTextureButton selectedButton; //Field offset: 0x30
		public Vector2 screenSpacePosition; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCreatePathClicked>d__395 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EditorMenuPopout <>4__this; //Field offset: 0x28
		public StandardTrackTextureButton trackTextureButton; //Field offset: 0x30
		public Vector2 screenSpacePosition; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class BlockItemPlacement : MulticastDelegate
	{

		public BlockItemPlacement(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool blockPlacement, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool blockPlacement) { }

	}

	internal sealed class OnAreaTextureChangedEvent : MulticastDelegate
	{

		public OnAreaTextureChangedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MapEditorArea editor, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MapEditorArea editor) { }

	}

	internal sealed class OnBindData : MulticastDelegate
	{

		public OnBindData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnCategoryTabSwitchedEvent : MulticastDelegate
	{

		public OnCategoryTabSwitchedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CategoryButton selectedCategory, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CategoryButton selectedCategory) { }

	}

	internal sealed class OnCloseRemoveableEditingPanel : MulticastDelegate
	{

		public OnCloseRemoveableEditingPanel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool saveChanges, RemovableAreaData data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool saveChanges, RemovableAreaData data) { }

	}

	internal sealed class OnDeletePropLayerEvent : MulticastDelegate
	{

		public OnDeletePropLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropLayerButton button) { }

	}

	internal sealed class OnDeleteSelectedAreaEvent : MulticastDelegate
	{

		public OnDeleteSelectedAreaEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnDeleteSelectedPathEvent : MulticastDelegate
	{

		public OnDeleteSelectedPathEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnDeleteSpecialPropLayerEvent : MulticastDelegate
	{

		public OnDeleteSpecialPropLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SpecialPropLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SpecialPropLayerButton button) { }

	}

	internal sealed class OnEndSpawnCustomItemPlacement : MulticastDelegate
	{

		public OnEndSpawnCustomItemPlacement(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomMapItemPurchaseButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomMapItemPurchaseButton button) { }

	}

	internal sealed class OnHighlightSelectedAreaTextureButtonEvent : MulticastDelegate
	{

		public OnHighlightSelectedAreaTextureButtonEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int textureId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int textureId) { }

	}

	internal sealed class OnHighlightSelectedPathTextureButtonEvent : MulticastDelegate
	{

		public OnHighlightSelectedPathTextureButtonEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int textureId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int textureId) { }

	}

	internal sealed class OnLayerRemovedEvent : MulticastDelegate
	{

		public OnLayerRemovedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnLoadingStampsCompletedEvent : MulticastDelegate
	{

		public OnLoadingStampsCompletedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnMapClearedEvent : MulticastDelegate
	{

		public OnMapClearedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnNewLayerAddedEvent : MulticastDelegate
	{

		public OnNewLayerAddedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnNodeCreatedEvent : MulticastDelegate
	{

		public OnNodeCreatedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnNodeRemovedEvent : MulticastDelegate
	{

		public OnNodeRemovedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnPathTextureChangedEvent : MulticastDelegate
	{

		public OnPathTextureChangedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MapEditorPath editor, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MapEditorPath editor) { }

	}

	internal sealed class OnPopupPositionChangedEvent : MulticastDelegate
	{

		public OnPopupPositionChangedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isExtended, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isExtended) { }

	}

	internal sealed class OnRebuildCustomUserPrefabsEvent : MulticastDelegate
	{

		public OnRebuildCustomUserPrefabsEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSetPropLayerVisibleEvent : MulticastDelegate
	{

		public OnSetPropLayerVisibleEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropLayerButton button, bool isOn, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropLayerButton button, bool isOn) { }

	}

	internal sealed class OnSetSelectedAreaLayerEvent : MulticastDelegate
	{

		public OnSetSelectedAreaLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AreaLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(AreaLayerButton button) { }

	}

	internal sealed class OnSetSelectedAreaTextureButtonEvent : MulticastDelegate
	{

		public OnSetSelectedAreaTextureButtonEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StandardAreaTextureButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(StandardAreaTextureButton button) { }

	}

	internal sealed class OnSetSelectedPathLayerEvent : MulticastDelegate
	{

		public OnSetSelectedPathLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PathLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PathLayerButton button) { }

	}

	internal sealed class OnSetSelectedPathTextureButtonEvent : MulticastDelegate
	{

		public OnSetSelectedPathTextureButtonEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StandardTrackTextureButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(StandardTrackTextureButton button) { }

	}

	internal sealed class OnSetSelectedPropLayerEvent : MulticastDelegate
	{

		public OnSetSelectedPropLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropLayerButton button) { }

	}

	internal sealed class OnSetSelectedSpecialPropLayerEvent : MulticastDelegate
	{

		public OnSetSelectedSpecialPropLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SpecialPropLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SpecialPropLayerButton button) { }

	}

	internal sealed class OnSetSelectedStampLayerEvent : MulticastDelegate
	{

		public OnSetSelectedStampLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StampLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(StampLayerButton button) { }

	}

	internal sealed class OnSetSelectedStampLayerVisibleEvent : MulticastDelegate
	{

		public OnSetSelectedStampLayerVisibleEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StampLayerButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(StampLayerButton button) { }

	}

	internal sealed class OnSetSpeicalPropLayerVisibleEvent : MulticastDelegate
	{

		public OnSetSpeicalPropLayerVisibleEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(SpecialPropLayerButton button, bool isOn, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(SpecialPropLayerButton button, bool isOn) { }

	}

	internal sealed class OnSpawnCustomItemPlacement : MulticastDelegate
	{

		public OnSpawnCustomItemPlacement(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomMapItemPurchaseButton button, Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomMapItemPurchaseButton button, Vector2 position) { }

	}

	internal sealed class OnStampErasedEvent : MulticastDelegate
	{

		public OnStampErasedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnStampLayerRemovedEvent : MulticastDelegate
	{

		public OnStampLayerRemovedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int layer, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int layer) { }

	}

	internal sealed class OnToggleAreaEditModeEvent : MulticastDelegate
	{

		public OnToggleAreaEditModeEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool enterEditMode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool enterEditMode) { }

	}

	internal sealed class OnToggleChildVarientGroupEvent : MulticastDelegate
	{

		public OnToggleChildVarientGroupEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomMapItemPurchaseButton button, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomMapItemPurchaseButton button) { }

	}

	internal sealed class OnToggleNodeMovingModeEvent : MulticastDelegate
	{

		public OnToggleNodeMovingModeEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool inMovingMode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool inMovingMode) { }

	}

	internal sealed class OnTogglePathEditModeEvent : MulticastDelegate
	{

		public OnTogglePathEditModeEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool enterEditMode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool enterEditMode) { }

	}

	internal sealed class OnToggleVisibliltyOfRemovableGroup : MulticastDelegate
	{

		public OnToggleVisibliltyOfRemovableGroup(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RemoveableAreaLayerButton removeableLayer, RemoveableTypeGroup group, bool isVisible, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RemoveableAreaLayerButton removeableLayer, RemoveableTypeGroup group, bool isVisible) { }

	}

	internal sealed class OnUpdateAreaButtonStatesEvent : MulticastDelegate
	{

		public OnUpdateAreaButtonStatesEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdateEditingPanelEvent : MulticastDelegate
	{

		public OnUpdateEditingPanelEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool showPanel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool showPanel) { }

	}

	internal sealed class OnUpdatePathButtonStatesEvent : MulticastDelegate
	{

		public OnUpdatePathButtonStatesEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdatePropGroupButtonStatesEvent : MulticastDelegate
	{

		public OnUpdatePropGroupButtonStatesEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdateSelectedLayerEvent : MulticastDelegate
	{

		public OnUpdateSelectedLayerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EditorLayerButton currSelectedButton, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(EditorLayerButton currSelectedButton) { }

	}

	internal sealed class OnUpdateSpecialPropGroupButtonStatesEvent : MulticastDelegate
	{

		public OnUpdateSpecialPropGroupButtonStatesEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdateStampLayerButtonStatesEvent : MulticastDelegate
	{

		public OnUpdateStampLayerButtonStatesEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class PrimeMapEditorProp : MulticastDelegate
	{

		public PrimeMapEditorProp(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StandardPropPurchaseButton selectedButton, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(StandardPropPurchaseButton selectedButton) { }

	}

	internal sealed class PropPackSelected : MulticastDelegate
	{

		public PropPackSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StoreItem item, PropPackPurchaseButton selectedButton, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(StoreItem item, PropPackPurchaseButton selectedButton) { }

	}

	public static EditorMenuPopout instance; //Field offset: 0x0
	public AudioClip clickSound; //Field offset: 0x20
	public AudioClip tabSound; //Field offset: 0x28
	public AudioClip closeSound; //Field offset: 0x30
	public AudioClip click3Sound; //Field offset: 0x38
	public AudioClip placeSound; //Field offset: 0x40
	public AudioClip undoSound; //Field offset: 0x48
	public AudioClip tickSound; //Field offset: 0x50
	[Header("=== Tab Panel Options ===")]
	public Button categoryBackgroundButton; //Field offset: 0x58
	public Button categoryStampsButton; //Field offset: 0x60
	public Button categoryPropsButton; //Field offset: 0x68
	public Button categoryPathsButton; //Field offset: 0x70
	public Button categoryAreasButton; //Field offset: 0x78
	public Button categoryPacksButton; //Field offset: 0x80
	public Button categorySpecialPropsButton; //Field offset: 0x88
	public Button categoryTowersButton; //Field offset: 0x90
	public Button categoryPowersButton; //Field offset: 0x98
	public TabToggle categoryBackgroundTab; //Field offset: 0xA0
	public TabToggle categoryPropsTab; //Field offset: 0xA8
	public TabToggle categoryPathTab; //Field offset: 0xB0
	public TabToggle categoryStampsTab; //Field offset: 0xB8
	public TabToggle categoryAreasTab; //Field offset: 0xC0
	public TabToggle categoryPacksTab; //Field offset: 0xC8
	public TabToggle categorySpecialPropsTab; //Field offset: 0xD0
	public TabToggle categoryTowersTab; //Field offset: 0xD8
	public TabToggle categoryPowersTab; //Field offset: 0xE0
	public GameObject categoryPacksPipObj; //Field offset: 0xE8
	public Animator editorTabGroupsAnimator; //Field offset: 0xF0
	public NK_TextMeshProUGUI categoryTitleText; //Field offset: 0xF8
	[Header("=== Main Panels ===")]
	public GameObject backgroundsPanel; //Field offset: 0x100
	public GameObject stampsPanel; //Field offset: 0x108
	public GameObject propsPanel; //Field offset: 0x110
	public GameObject areasPanel; //Field offset: 0x118
	public GameObject pathPanel; //Field offset: 0x120
	public GameObject specialPropsPanel; //Field offset: 0x128
	public GameObject packsPanel; //Field offset: 0x130
	public GameObject towersPanel; //Field offset: 0x138
	public GameObject powersPanel; //Field offset: 0x140
	[Header("=== Background Texture Panel ===")]
	public GameObject mapTextureListSorter; //Field offset: 0x148
	public GameObject mapTexturePrefab; //Field offset: 0x150
	public Toggle terrainTgl; //Field offset: 0x158
	public Toggle ambientFxTgl; //Field offset: 0x160
	public ScrollRectWithDragCancel textureScrollRect; //Field offset: 0x168
	[Header("=== Prop Panel ===")]
	public Button addPropLayerButton; //Field offset: 0x170
	public GameObject propListSorter; //Field offset: 0x178
	public GameObject propButtonPrefab; //Field offset: 0x180
	public GameObject propLayerButtonPrefab; //Field offset: 0x188
	public TMP_Dropdown propsFilterDropdown; //Field offset: 0x190
	public GameObject propsMaxPlaceableBlocker; //Field offset: 0x198
	public ScrollRectWithDragCancel propScrollRect; //Field offset: 0x1A0
	public Toggle randomizeRotationPropTgl; //Field offset: 0x1A8
	public Toggle showVarientsTgl; //Field offset: 0x1B0
	public MapEditorCategoryLayersViewer propLayersViewer; //Field offset: 0x1B8
	[Header("=== Path Panel ===")]
	public Button addPathLayerButton; //Field offset: 0x1C0
	public Button editPathButton; //Field offset: 0x1C8
	public GameObject pathWidthPanel; //Field offset: 0x1D0
	public Button pathWidthLeftButton; //Field offset: 0x1D8
	public Button pathWidthRightButton; //Field offset: 0x1E0
	public NK_TextMeshProUGUI pathWidthText; //Field offset: 0x1E8
	public GameObject pathLayerPrefab; //Field offset: 0x1F0
	public GameObject pathListSorter; //Field offset: 0x1F8
	public GameObject pathTexturePrefab; //Field offset: 0x200
	public GameObject pathEditorPanel; //Field offset: 0x208
	public Animator pathEditorPanelAnim; //Field offset: 0x210
	public ScrollRectWithDragCancel pathScrollRect; //Field offset: 0x218
	public MapEditorCategoryLayersViewer pathLayersViewer; //Field offset: 0x220
	public MapEditorPathSplitterPopup pathSettingsPopup; //Field offset: 0x228
	public PipEventChecker pathWarningPip; //Field offset: 0x230
	private PathEditingPanel pathEditingPanel; //Field offset: 0x238
	[Header("=== Path Editor HUD ===")]
	public GameObject pathTooltipPanel; //Field offset: 0x2E0
	public GameObject pathCheckerPanel; //Field offset: 0x2E8
	public GameObject pathStartTooltipActive; //Field offset: 0x2F0
	public GameObject pathStartTooltipComplete; //Field offset: 0x2F8
	public GameObject pathStartTooltipIncomplete; //Field offset: 0x300
	public GameObject pathStartTooltipInfo; //Field offset: 0x308
	public Button pathStartTooltipInfoBtn; //Field offset: 0x310
	public GameObject pathLengthTooltipActive; //Field offset: 0x318
	public GameObject pathLengthTooltipComplete; //Field offset: 0x320
	public GameObject pathLengthTooltipIncomplete; //Field offset: 0x328
	public GameObject pathLengthTooltipInfo; //Field offset: 0x330
	public Button pathLengthTooltipInfoBtn; //Field offset: 0x338
	public GameObject pathEndTooltipActive; //Field offset: 0x340
	public GameObject pathEndTooltipComplete; //Field offset: 0x348
	public GameObject pathEndTooltipIncomplete; //Field offset: 0x350
	public GameObject pathEndTooltipCompleteTextBox; //Field offset: 0x358
	public GameObject pathEndTooltipInfo; //Field offset: 0x360
	public Button pathEndTooltipInfoBtn; //Field offset: 0x368
	public Slider pathLengthSlider; //Field offset: 0x370
	public Button showHidePanelBtn; //Field offset: 0x378
	[Header("=== Stamp Panel ===")]
	public Button addStampLayerButton; //Field offset: 0x380
	public Button stampUndoButton; //Field offset: 0x388
	public Button stampEraserButton; //Field offset: 0x390
	public GameObject stampLayerPrefab; //Field offset: 0x398
	public GameObject stampListSorter; //Field offset: 0x3A0
	public GameObject stampButtonPrefab; //Field offset: 0x3A8
	public GameObject stampsMaxPlaceableBlocker; //Field offset: 0x3B0
	public Image eraserStampIcon; //Field offset: 0x3B8
	public Toggle randomizeRotationStampTgl; //Field offset: 0x3C0
	public StampDisplay stampPrefab; //Field offset: 0x3C8
	public ScrollRectWithDragCancel stampScrollRect; //Field offset: 0x3D0
	public MapEditorCategoryLayersViewer stampLayersViewer; //Field offset: 0x3D8
	[Header("=== Area Panel ===")]
	public Button addAreaLayerButton; //Field offset: 0x3E0
	public Button editAreaButton; //Field offset: 0x3E8
	public GameObject areaLayerPrefab; //Field offset: 0x3F0
	public GameObject removeableAreaLayerPrefab; //Field offset: 0x3F8
	public GameObject areaListSorter; //Field offset: 0x400
	public GameObject areaInteractableListSorter; //Field offset: 0x408
	public GameObject areaInteractablePropsListSorter; //Field offset: 0x410
	public GameObject areaTexturePrefab; //Field offset: 0x418
	public GameObject areaEditorPanel; //Field offset: 0x420
	public Animator areaEditorPanelAnim; //Field offset: 0x428
	public ScrollRectWithDragCancel areaScrollRect; //Field offset: 0x430
	public MapEditorCategoryLayersViewer areaLayersViewer; //Field offset: 0x438
	private AreaEditingPanel areaEditingPanel; //Field offset: 0x440
	[Header("=== Special Prop Panel ===")]
	public Button addSpecialPropLayerButton; //Field offset: 0x490
	public GameObject specialPropListSorter; //Field offset: 0x498
	public GameObject specialPropButtonPrefab; //Field offset: 0x4A0
	public GameObject specialPropLayerButtonPrefab; //Field offset: 0x4A8
	public TMP_Dropdown specialPropFilterDropdown; //Field offset: 0x4B0
	public GameObject specialPropMaxPlaceableBlocker; //Field offset: 0x4B8
	public ScrollRectWithDragCancel specialPropScrollRect; //Field offset: 0x4C0
	public Toggle randomizePropRotationSpecialPropTgl; //Field offset: 0x4C8
	public MapEditorCategoryLayersViewer interactableLayersViewer; //Field offset: 0x4D0
	[Header("=== Layer Panel ===")]
	public GameObject mainLayerListSorter; //Field offset: 0x4D8
	public GameObject unsortableLayerListSorter; //Field offset: 0x4E0
	public Button upSortButton; //Field offset: 0x4E8
	public Button downSortButton; //Field offset: 0x4F0
	public NK_TextMeshProUGUI layerCountTxt; //Field offset: 0x4F8
	[Header("=== Packs Panel ===")]
	public PropPackPurchaseButton propPackBtnPrefab; //Field offset: 0x500
	public ScrollRectWithDragCancel packsScrollRect; //Field offset: 0x508
	public PropPackPurchasePanel propPacksPopup; //Field offset: 0x510
	public GameObject propPacksListSorter; //Field offset: 0x518
	[Header("=== Common Panel ===")]
	public Button layerPanelButton; //Field offset: 0x520
	public Button expandButton; //Field offset: 0x528
	public Button infoButton; //Field offset: 0x530
	public Button pathSettingsButton; //Field offset: 0x538
	public GameObject layersPanel; //Field offset: 0x540
	public Animator layersPanelAnim; //Field offset: 0x548
	public GameObject infoPanel; //Field offset: 0x550
	public GameObject pathSettingsPanel; //Field offset: 0x558
	public Animator expandPanelAnimator; //Field offset: 0x560
	public GameObject expandPanelImage; //Field offset: 0x568
	public Animator newLayerAddedPanelAnim; //Field offset: 0x570
	public Transform buttonTabsTransform; //Field offset: 0x578
	public EditorMenu editorMenu; //Field offset: 0x580
	private PowerEditorPanel powerEditorPanel; //Field offset: 0x588
	private TowerEditorPanel towerEditorPanel; //Field offset: 0x590
	public ScrollRectWithDragCancel towersScrollRect; //Field offset: 0x598
	public ScrollRectWithDragCancel powersScrollRect; //Field offset: 0x5A0
	private PathLayerButton lastSelectedPathLayerButton; //Field offset: 0x5A8
	private StampLayerButton lastSelectedStampLayerButton; //Field offset: 0x5B0
	private AreaLayerButton lastSelectedAreaLayerButton; //Field offset: 0x5B8
	private PropLayerButton lastSelectedPropGroupLayerButton; //Field offset: 0x5C0
	private SpecialPropLayerButton lastSelectedSpecialPropGroupLayerButton; //Field offset: 0x5C8
	[Nullable(2)]
	private EditorLayerButton currSelectedLayerButton; //Field offset: 0x5D0
	private StandardTrackTextureButton selectedPathTextureButton; //Field offset: 0x5D8
	private StandardAreaTextureButton selectedAreaTextureButton; //Field offset: 0x5E0
	private StandardMapTextureButton selectedMapTextureButton; //Field offset: 0x5E8
	private StandardStampPurchaseButton selectedStampButton; //Field offset: 0x5F0
	private StandardPropPurchaseButton selectedPropButton; //Field offset: 0x5F8
	private StandardPropPurchaseButton selectedAmbientFxButton; //Field offset: 0x600
	private StandardPropPurchaseButton selectedSpecialEffectPropButton; //Field offset: 0x608
	private bool lockToProp; //Field offset: 0x610
	private bool initialised; //Field offset: 0x611
	private bool resetButtonPositions; //Field offset: 0x612
	private bool isPanelExtended; //Field offset: 0x613
	private bool isShowingVariants; //Field offset: 0x614
	private int previousPopupAnimatorState; //Field offset: 0x618
	private CategoryButton selectedCategory; //Field offset: 0x61C
	private MapEditorItemTag propFilter; //Field offset: 0x620
	private readonly List<StandardMapTextureButton> activeMapTextureButtons; //Field offset: 0x628
	private readonly List<StandardTrackTextureButton> activePathTextureButtons; //Field offset: 0x630
	private readonly List<StandardAreaTextureButton> activeAreaTextureButtons; //Field offset: 0x638
	private readonly List<StandardPropPurchaseButton> activePropButtons; //Field offset: 0x640
	private readonly List<StandardStampPurchaseButton> activeStampButtons; //Field offset: 0x648
	private readonly List<StandardPropPurchaseButton> activeSpeicalPropButtons; //Field offset: 0x650
	private readonly List<StandardPropPurchaseButton> activeAmbientPropsButtonsSubList; //Field offset: 0x658
	private readonly List<PropPackPurchaseButton> activePropPackButtons; //Field offset: 0x660
	[CompilerGenerated]
	private List<PathLayerButton> <activePathLayerButtons>k__BackingField; //Field offset: 0x668
	[CompilerGenerated]
	private List<AreaLayerButton> <activeAreaLayerButtons>k__BackingField; //Field offset: 0x670
	[CompilerGenerated]
	private List<StampLayerButton> <activeStampLayerButtons>k__BackingField; //Field offset: 0x678
	[CompilerGenerated]
	private List<PropLayerButton> <activePropGroupLayerButtons>k__BackingField; //Field offset: 0x680
	[CompilerGenerated]
	private List<SpecialPropLayerButton> <activeSpecialPropGroupLayerButtons>k__BackingField; //Field offset: 0x688
	private readonly List<EditorLayerButton> mainLayersButtons; //Field offset: 0x690
	private readonly List<EditorLayerButton> floatingMainLayerButtons; //Field offset: 0x698
	[CompilerGenerated]
	private MapEditorSceneController <MapEditorSceneController>k__BackingField; //Field offset: 0x6A0
	[CompilerGenerated]
	private CustomMapManagers <CustomMapManagers>k__BackingField; //Field offset: 0x6A8
	public Action<Boolean> OnToggleEditModeEvent; //Field offset: 0x6B0
	private readonly Dictionary<PropSetType, Int32> propSetTypeWeights; //Field offset: 0x6B8
	private readonly Dictionary<AreaType, Int32> areaSetTypeWeights; //Field offset: 0x6C0
	private CancellationTokenSource editorPopoutCts; //Field offset: 0x6C8
	private readonly Type[] layerOrder; //Field offset: 0x6D0

	public private List<AreaLayerButton> activeAreaLayerButtons
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private List<PathLayerButton> activePathLayerButtons
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private List<PropLayerButton> activePropGroupLayerButtons
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private List<SpecialPropLayerButton> activeSpecialPropGroupLayerButtons
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private List<StampLayerButton> activeStampLayerButtons
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private Button CancelMoveModeButton
	{
		private get { } //Length: 8
	}

	public int CurrentPathSizeWidth
	{
		 get { } //Length: 136
	}

	public ScrollRectWithDragCancel CurrentScrollRect
	{
		 get { } //Length: 180
	}

	public CustomAreasManager CustomAreasManager
	{
		 get { } //Length: 30
	}

	public private CustomMapManagers CustomMapManagers
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public CustomPathsManager CustomPathsManager
	{
		 get { } //Length: 30
	}

	private Button DeleteAreaButton
	{
		private get { } //Length: 8
	}

	private Button DeleteAreaNodeButton
	{
		private get { } //Length: 8
	}

	private Button DeletePathButton
	{
		private get { } //Length: 8
	}

	private Button DeletePathNodeButton
	{
		private get { } //Length: 8
	}

	public MapEditorSettings EditorSettings
	{
		 get { } //Length: 147
	}

	private Button ExitEditAreaButton
	{
		private get { } //Length: 8
	}

	private Button ExitEditPathButton
	{
		private get { } //Length: 8
	}

	public ScrollRectWithDragCancel FindCurrentlySelectedScrollRect
	{
		 get { } //Length: 180
	}

	public bool IsInPropMode
	{
		 get { } //Length: 150
	}

	public bool IsPanelExtended
	{
		 get { } //Length: 8
	}

	public bool IsShowingVariants
	{
		 get { } //Length: 8
	}

	public private MapEditorSceneController MapEditorSceneController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private Button MoveAreaButton
	{
		private get { } //Length: 8
	}

	private GameObject PathInvulnerableBloonsGroup
	{
		private get { } //Length: 8
	}

	private Toggle PathInvulnerableBloonsStartToggle
	{
		private get { } //Length: 8
	}

	private GameObject PathInvulnerableMoabsGroup
	{
		private get { } //Length: 8
	}

	private Toggle PathInvulnerableMoabsStartToggle
	{
		private get { } //Length: 8
	}

	private GameObject PathScaleBloonsGroup
	{
		private get { } //Length: 8
	}

	private Button PathScaleBloonsSliderLeft
	{
		private get { } //Length: 8
	}

	private Button PathScaleBloonsSliderRight
	{
		private get { } //Length: 8
	}

	private TextMeshProUGUI PathScaleBloonsSliderText
	{
		private get { } //Length: 8
	}

	private Button PathScaleBloonsSpeedSliderLeft
	{
		private get { } //Length: 8
	}

	private Button PathScaleBloonsSpeedSliderRight
	{
		private get { } //Length: 8
	}

	private TextMeshProUGUI PathScaleBloonsSpeedSliderText
	{
		private get { } //Length: 8
	}

	private GameObject PathScaleMoabsGroup
	{
		private get { } //Length: 8
	}

	private Button PathScaleMoabsSliderLeft
	{
		private get { } //Length: 8
	}

	private Button PathScaleMoabsSliderRight
	{
		private get { } //Length: 8
	}

	private TextMeshProUGUI PathScaleMoabsSliderText
	{
		private get { } //Length: 8
	}

	private GameObject PathScaleSpeedGroup
	{
		private get { } //Length: 8
	}

	private Button RemoveableCancelButton
	{
		private get { } //Length: 30
	}

	private Button RemoveableConfirmButton
	{
		private get { } //Length: 30
	}

	private Button RemoveableEditButton
	{
		private get { } //Length: 8
	}

	private EditorRemoveablesLayerSelectPanel RemoveableEditSettings
	{
		private get { } //Length: 8
	}

	private GameObject RemoveableEditSettingsPanel
	{
		private get { } //Length: 8
	}

	public StampLayerButton SelectedStampLayerButton
	{
		 get { } //Length: 8
	}

	private Button SharpAreaCornersButton
	{
		private get { } //Length: 8
	}

	private Button SmoothAreaCornersButton
	{
		private get { } //Length: 8
	}

	public EditorMenuPopout() { }

	[CompilerGenerated]
	private void <Initialise>b__339_0() { }

	[CompilerGenerated]
	private void <Initialise>b__339_1() { }

	[CompilerGenerated]
	private void <Initialise>b__339_10(bool _) { }

	[CompilerGenerated]
	private void <Initialise>b__339_11() { }

	[CompilerGenerated]
	private void <Initialise>b__339_12(bool _) { }

	[CompilerGenerated]
	private void <Initialise>b__339_13(bool _) { }

	[CompilerGenerated]
	private void <Initialise>b__339_14() { }

	[CompilerGenerated]
	private void <Initialise>b__339_15() { }

	[CompilerGenerated]
	private void <Initialise>b__339_16() { }

	[CompilerGenerated]
	private void <Initialise>b__339_17() { }

	[CompilerGenerated]
	private void <Initialise>b__339_18() { }

	[CompilerGenerated]
	private void <Initialise>b__339_19() { }

	[CompilerGenerated]
	private void <Initialise>b__339_2() { }

	[CompilerGenerated]
	private void <Initialise>b__339_20() { }

	[CompilerGenerated]
	private void <Initialise>b__339_21(bool value) { }

	[CompilerGenerated]
	private void <Initialise>b__339_22(bool value) { }

	[CompilerGenerated]
	private void <Initialise>b__339_23() { }

	[CompilerGenerated]
	private void <Initialise>b__339_24() { }

	[CompilerGenerated]
	private void <Initialise>b__339_25() { }

	[CompilerGenerated]
	private void <Initialise>b__339_26() { }

	[CompilerGenerated]
	private void <Initialise>b__339_27() { }

	[CompilerGenerated]
	private void <Initialise>b__339_28() { }

	[CompilerGenerated]
	private void <Initialise>b__339_29() { }

	[CompilerGenerated]
	private void <Initialise>b__339_3() { }

	[CompilerGenerated]
	private void <Initialise>b__339_30() { }

	[CompilerGenerated]
	private void <Initialise>b__339_31() { }

	[CompilerGenerated]
	private void <Initialise>b__339_32() { }

	[CompilerGenerated]
	private void <Initialise>b__339_33() { }

	[CompilerGenerated]
	private void <Initialise>b__339_34() { }

	[CompilerGenerated]
	private void <Initialise>b__339_35() { }

	[CompilerGenerated]
	private void <Initialise>b__339_36() { }

	[CompilerGenerated]
	private void <Initialise>b__339_37() { }

	[CompilerGenerated]
	private void <Initialise>b__339_38() { }

	[CompilerGenerated]
	private void <Initialise>b__339_39() { }

	[CompilerGenerated]
	private void <Initialise>b__339_4() { }

	[CompilerGenerated]
	private void <Initialise>b__339_40() { }

	[CompilerGenerated]
	private void <Initialise>b__339_41() { }

	[CompilerGenerated]
	private void <Initialise>b__339_42(bool _) { }

	[CompilerGenerated]
	private void <Initialise>b__339_43() { }

	[CompilerGenerated]
	private void <Initialise>b__339_44(bool _) { }

	[CompilerGenerated]
	private void <Initialise>b__339_45() { }

	[CompilerGenerated]
	private void <Initialise>b__339_46() { }

	[CompilerGenerated]
	private void <Initialise>b__339_47() { }

	[CompilerGenerated]
	private void <Initialise>b__339_48() { }

	[CompilerGenerated]
	private void <Initialise>b__339_49() { }

	[CompilerGenerated]
	private void <Initialise>b__339_5() { }

	[CompilerGenerated]
	private void <Initialise>b__339_50() { }

	[CompilerGenerated]
	private void <Initialise>b__339_51() { }

	[CompilerGenerated]
	private void <Initialise>b__339_52() { }

	[CompilerGenerated]
	private void <Initialise>b__339_6() { }

	[CompilerGenerated]
	private void <Initialise>b__339_7() { }

	[CompilerGenerated]
	private void <Initialise>b__339_8() { }

	[CompilerGenerated]
	private void <Initialise>b__339_9(bool _) { }

	[CompilerGenerated]
	private void <OnQuitToMenu>b__340_0() { }

	[CompilerGenerated]
	private void <OnQuitToMenu>b__340_1() { }

	[CompilerGenerated]
	private int <SortAreaButtonList>b__355_0(StandardAreaTextureButton a, StandardAreaTextureButton b) { }

	[CompilerGenerated]
	private int <SortPropButtonList>b__360_1(IGrouping<PropSetType, StandardPropPurchaseButton> g) { }

	public void Awake() { }

	public void BindData() { }

	private void BuildAreaSet() { }

	private void BuildBackgroundSet() { }

	private void BuildEditorButtonSets() { }

	private void BuildPathSet() { }

	private void BuildPropPacksSet() { }

	private void BuildPropSet() { }

	private void BuildQuestEditor() { }

	private void BuildSpecialEffectPropSet() { }

	private void BuildStampSet() { }

	private void CancelAndRenewCancellationTokenSource() { }

	private void CleanUpCanellationTokens() { }

	private void CleanUpDisplayLists() { }

	public void ClearAreaButtons() { }

	public void ClearLayerButtonLists(List<T> layerButtonList, GameObject sorter = null) { }

	private void ClearListSet(List<T> setList) { }

	public void ClearPathButtons() { }

	public T CreateAreaLayerButton(List<T> list, int index = -1, int worldSortingIndex = -1, object metaData = null) { }

	private StandardAreaTextureButton CreateAreaTextureButton(AreaTextureModel areaTextureModel) { }

	private StandardMapTextureButton CreateMapTextureButton(MapTextureModel mapTextureModel) { }

	public T CreatePathLayerButton(List<T> list, int index = -1, int worldSortingIndex = -1, object metaData = null) { }

	private StandardTrackTextureButton CreatePathTextureButton(TrackTextureModel pathTextureModel) { }

	private StandardPropPurchaseButton CreatePropButton(PropModel propModel) { }

	public T CreatePropLayerButton(List<T> list, GameObject buttonLayerPrefab, int index = -1, int worldSortingIndex = -1, object metaData = null) { }

	private StandardStampPurchaseButton CreateStampButton(StampTextureModel stampTextureModel) { }

	public T CreateStampLayerButton(List<T> list, int index = -1, int worldSortingIndex = -1, object metaData = null) { }

	private void FilterPropsBy(MapEditorItemTag filter) { }

	public EditorLayerButton FindCurrSelectedCategoryLayer() { }

	public int FindFirstUnusedIndex(List<T> layerList) { }

	public int FindIndexForMainLayerInsert(List<T> list, T button) { }

	[CompilerGenerated]
	public List<AreaLayerButton> get_activeAreaLayerButtons() { }

	[CompilerGenerated]
	public List<PathLayerButton> get_activePathLayerButtons() { }

	[CompilerGenerated]
	public List<PropLayerButton> get_activePropGroupLayerButtons() { }

	[CompilerGenerated]
	public List<SpecialPropLayerButton> get_activeSpecialPropGroupLayerButtons() { }

	[CompilerGenerated]
	public List<StampLayerButton> get_activeStampLayerButtons() { }

	private Button get_CancelMoveModeButton() { }

	public int get_CurrentPathSizeWidth() { }

	public ScrollRectWithDragCancel get_CurrentScrollRect() { }

	public CustomAreasManager get_CustomAreasManager() { }

	[CompilerGenerated]
	private CustomMapManagers get_CustomMapManagers() { }

	public CustomPathsManager get_CustomPathsManager() { }

	private Button get_DeleteAreaButton() { }

	private Button get_DeleteAreaNodeButton() { }

	private Button get_DeletePathButton() { }

	private Button get_DeletePathNodeButton() { }

	public MapEditorSettings get_EditorSettings() { }

	private Button get_ExitEditAreaButton() { }

	private Button get_ExitEditPathButton() { }

	public ScrollRectWithDragCancel get_FindCurrentlySelectedScrollRect() { }

	public bool get_IsInPropMode() { }

	public bool get_IsPanelExtended() { }

	public bool get_IsShowingVariants() { }

	[CompilerGenerated]
	public MapEditorSceneController get_MapEditorSceneController() { }

	private Button get_MoveAreaButton() { }

	private GameObject get_PathInvulnerableBloonsGroup() { }

	private Toggle get_PathInvulnerableBloonsStartToggle() { }

	private GameObject get_PathInvulnerableMoabsGroup() { }

	private Toggle get_PathInvulnerableMoabsStartToggle() { }

	private GameObject get_PathScaleBloonsGroup() { }

	private Button get_PathScaleBloonsSliderLeft() { }

	private Button get_PathScaleBloonsSliderRight() { }

	private TextMeshProUGUI get_PathScaleBloonsSliderText() { }

	private Button get_PathScaleBloonsSpeedSliderLeft() { }

	private Button get_PathScaleBloonsSpeedSliderRight() { }

	private TextMeshProUGUI get_PathScaleBloonsSpeedSliderText() { }

	private GameObject get_PathScaleMoabsGroup() { }

	private Button get_PathScaleMoabsSliderLeft() { }

	private Button get_PathScaleMoabsSliderRight() { }

	private TextMeshProUGUI get_PathScaleMoabsSliderText() { }

	private GameObject get_PathScaleSpeedGroup() { }

	private Button get_RemoveableCancelButton() { }

	private Button get_RemoveableConfirmButton() { }

	private Button get_RemoveableEditButton() { }

	private EditorRemoveablesLayerSelectPanel get_RemoveableEditSettings() { }

	private GameObject get_RemoveableEditSettingsPanel() { }

	public StampLayerButton get_SelectedStampLayerButton() { }

	private Button get_SharpAreaCornersButton() { }

	private Button get_SmoothAreaCornersButton() { }

	public EditorLayerButton GetLayerButtonWithId(string id) { }

	public StandardPropPurchaseButton GetPropButton(PropModel propModel) { }

	public EditorLayerButton GetPropLayerFromCategoryType(StandardPropPurchaseButton button) { }

	public static int GetWorldSortingOrderFromIndex(int index) { }

	public void Initialise(EditorMenu editorMenu) { }

	public bool InsideMenuRect(Vector2 pos) { }

	private void MenuScrolled() { }

	public void OnAreaSelectedTriggered(AreaLayerButton button) { }

	public void OnCategoryButtonClicked(CategoryButton categoryClicked) { }

	private void OnClearAllGroupedPropsTriggered(PropLayerButton buttonLayer) { }

	private void OnClearAllGroupedSpecialPropsTriggered(SpecialPropLayerButton buttonLayer) { }

	private void OnClearAllPropsTriggered() { }

	public void OnClickedDeletePropGroup(PropLayerButton button) { }

	public void OnClickedDeleteSpecialPropGroup(SpecialPropLayerButton button) { }

	public void OnCloseRemoveableEditingPanelTriggered(bool saveChanges, RemovableAreaData data) { }

	public void OnConfirmClearAllClicked() { }

	public void OnConfirmDeleteAreaClicked() { }

	public void OnConfirmDeleteGroupedPropLayerCallback(PropLayerButton button) { }

	public void OnConfirmDeleteGroupedSpecialPropLayerCallback(SpecialPropLayerButton button) { }

	public void OnConfirmDeletePathClicked() { }

	public void OnConfirmDeleteStampLayerClicked() { }

	[AsyncStateMachine(typeof(<OnCreateAreaClicked>d__409))]
	private void OnCreateAreaClicked(Vector2 screenSpacePosition, StandardAreaTextureButton selectedButton) { }

	public void OnCreateAreaLayerClicked() { }

	[AsyncStateMachine(typeof(<OnCreatePathClicked>d__395))]
	private void OnCreatePathClicked(Vector2 screenSpacePosition, StandardTrackTextureButton trackTextureButton) { }

	public void OnCreatePathLayerClicked() { }

	public void OnCreatePropGroupClicked() { }

	public void OnCreateSpecialPropGroupClicked() { }

	public void OnCreateStampLayerClicked() { }

	public void OnCursorDownHitScene(Vector2 pos) { }

	public void OnDeleteSelectedAreaClicked() { }

	public void OnDeleteSelectedPathClicked() { }

	public void OnDeleteSelectedStampLayerClicked() { }

	private void OnDestroy() { }

	public void OnEditorMenuToggleButtonClicked(bool showPanel, bool forceRefresh = false) { }

	public void OnEndSpawnCustomItemPlacementTriggered(CustomMapItemPurchaseButton button) { }

	private void OnEnterExitEditModeClicked(bool isEditing) { }

	public void OnEraseAudio() { }

	private void OnEscOrPauseMenuOpened() { }

	public void OnExitRemoveableMode(bool saveChanges) { }

	public void OnFinishedLoadingAreasEvent() { }

	public void OnFinishedLoadingPathsEvent() { }

	public void OnFirstUpdate() { }

	public void OnLayerRemovedEventTriggered() { }

	public void OnLoadComplete() { }

	public void OnLoadingStampsCompletedEventTriggered() { }

	public void OnNewLayerAddedEventTriggered() { }

	public void OnPathSelectedTriggered(PathLayerButton button) { }

	public void OnPathSettingChanged(PathSettingType settingType, bool isEnabled) { }

	public void OnPathWidthChangedClicked(bool leftClicked) { }

	public void OnPlaceablesPlacedOrRemoved() { }

	private void OnPlaceAudioTrigger() { }

	public void OnPrimeMapEditorPropTriggered(StandardPropPurchaseButton button) { }

	public void OnPropFilterDropdownChanged(int filterIndex) { }

	public void OnPropLayerSelectedTriggered(PropLayerButton button) { }

	public void OnPropPackPurchased() { }

	public void OnQuitToMenu() { }

	private void OnQuitViaPauseScreen() { }

	public void OnRandomizeRotationPropTglClicked() { }

	public void OnRandomizeRotationStampTglClicked() { }

	public void OnRebuildCustomUserPrefabs() { }

	public void OnRemoveableEditClicked() { }

	public void OnSaveClicked() { }

	public void OnSelectedAmbientFx(StandardPropPurchaseButton b) { }

	public void OnSelectedAreaTexture(StandardAreaTextureButton b) { }

	public void OnSelectedMapTexture(StandardMapTextureButton b) { }

	public void OnSelectedPathTexture(StandardTrackTextureButton b) { }

	public void OnSelectedStampTexture(StandardStampPurchaseButton b) { }

	public void OnSelectionChanged(Selectable s) { }

	public void OnSetPropLayerVisibleTriggered(PropLayerButton button, bool isVisible) { }

	public void OnSetSelectedAreaTextureButtonTriggered(StandardAreaTextureButton button) { }

	public void OnSetSelectedPathTextureButtonTriggered(StandardTrackTextureButton button) { }

	public void OnSetSpecialPropLayerVisibleTriggered(SpecialPropLayerButton button, bool isVisible) { }

	public void OnSharpAreaCornersClicked(bool sharpCornersMode) { }

	public void OnShowHidePathHudPanelClicked() { }

	public void OnShowVarientsTglClicked() { }

	public void OnSpawnCustomItemPlacementTriggered(CustomMapItemPurchaseButton button, Vector2 position) { }

	public void OnSpecialPropFilterDropdownChanged(int filterIndex) { }

	public void OnSpecialPropLayerSelectedTriggered(SpecialPropLayerButton button) { }

	public void OnStampErasedEventTriggered() { }

	public void OnStampEraserClicked() { }

	public void OnStampSelectedTriggered(StampLayerButton button) { }

	public void OnTerrainAmbientFxTglClicked() { }

	public void OnToggleAreaEditMode(bool inEditMode) { }

	private void OnToggleChildVarientGroupEventTriggered(CustomMapItemPurchaseButton button) { }

	private void OnToggleExpandButtonClicked() { }

	private void OnToggleInfoButtonClicked() { }

	private void OnToggleLayersButtonClicked() { }

	private void OnToggleLayersPanel(bool show) { }

	public void OnToggleMoveAreaMode() { }

	public void OnToggleNodeMovingModeCallbackTriggered(bool inMovingMode) { }

	public void OnTogglePathEditMode(bool enterEditMode) { }

	public void OnTogglePathSettingsButtonClicked() { }

	public void OnToggleUiWhenInPlacementMode(bool inPlacementMode) { }

	public void OnToggleVisibliltyOfRemovableGroupTriggered(RemoveableAreaLayerButton removeableLayer, RemoveableTypeGroup groupType, bool isVisible) { }

	public void OnUndoClicked() { }

	public void OnUpdateAreaLayerButtonStates() { }

	public void OnUpdateAreaPlacementHud() { }

	public void OnUpdateBackgroundTabButtons() { }

	private void OnUpdatedSelectedButtonState(T currentSelectedButton, ref T previouslySelectedButton) { }

	public void OnUpdateEditingPanel(bool hidePanel = false) { }

	public void OnUpdateIsDraggingChecks() { }

	public void OnUpdateLayerPanelUI() { }

	public void OnUpdateLinkedLayerIcons() { }

	public void OnUpdateMainLayerSelectedStateEventTriggered(EditorLayerButton button) { }

	private void OnUpdatePathHudUI() { }

	public void OnUpdatePathLayerButtonStates() { }

	private void OnUpdatePathNodeSettingsUI() { }

	public void OnUpdatePathPlacementHud() { }

	public void OnUpdatePathSettingsUI() { }

	public void OnUpdatePlaceablesBlockerPanels() { }

	public void OnUpdatePropGroupLayerButtonStates() { }

	public void OnUpdateSpecialPropGroupLayerButtonStates() { }

	public void OnUpdateStampLayerButtonStates() { }

	public void OnUpdateStampSettingsUI() { }

	public void OnUpdateVisiblePropLayersAfterLoad() { }

	public void OnUpdateVisibleRemovableAreasLayersAfterLoad() { }

	public bool OverrideOpenPauseMenu() { }

	public void PlayButtonSound() { }

	private void PropPackClicked(StoreItem item, PropPackPurchaseButton selectedButton) { }

	public void RecreateAreaLayerButtonList() { }

	public void RecreatePathLayerButtonList() { }

	public void RecreatePropGroupLayerButtonList() { }

	public void RecreateSpecialPropGroupLayerButtonList() { }

	public void RecreateStampLayerButtonList() { }

	private void RecreateTabLayerButtonLists() { }

	private void RemoveLayer(List<T> categoryLayerList, ref T button) { }

	private void ReorderWorldLayerSorting() { }

	public void ResetSelectedButtons() { }

	public void ScrollToItem(ScrollRectWithDragCancel scrollRect, GameObject sorter, CustomMapItemPurchaseButton item) { }

	public void Select(StandardPropPurchaseButton b) { }

	[CompilerGenerated]
	private void set_activeAreaLayerButtons(List<AreaLayerButton> value) { }

	[CompilerGenerated]
	private void set_activePathLayerButtons(List<PathLayerButton> value) { }

	[CompilerGenerated]
	private void set_activePropGroupLayerButtons(List<PropLayerButton> value) { }

	[CompilerGenerated]
	private void set_activeSpecialPropGroupLayerButtons(List<SpecialPropLayerButton> value) { }

	[CompilerGenerated]
	private void set_activeStampLayerButtons(List<StampLayerButton> value) { }

	[CompilerGenerated]
	public void set_CustomMapManagers(CustomMapManagers value) { }

	[CompilerGenerated]
	private void set_MapEditorSceneController(MapEditorSceneController value) { }

	private void SetDefaultAreaEditorUiState() { }

	private void SetDefaultPathEditorUiState() { }

	private void SetDefaultUiStates() { }

	private void SortAreaButtonList() { }

	public void SortLayer(bool sortUp) { }

	private void SortMainLayersDefaultElementsToTop() { }

	private void SortPropButtonList(List<StandardPropPurchaseButton> buttonListToSort) { }

	public bool TryFindLayingWithMatchingLayerData(LayerData layerDataToFind, out EditorLayerButton layer) { }

	public void Unselect(StandardPropPurchaseButton b) { }

	private void Update() { }

	private void UpdateEditAreaUiState(bool inEditMode) { }

	private void UpdatePanelAnimationState(Animator panelAnim, int newState) { }

}

