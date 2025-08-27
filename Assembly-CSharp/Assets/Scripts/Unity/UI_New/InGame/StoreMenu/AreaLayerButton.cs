namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class AreaLayerButton : EditorLayerButton
{
	[CompilerGenerated]
	private MapEditorArea <AreaEditor>k__BackingField; //Field offset: 0x80

	public private MapEditorArea AreaEditor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public AreaLayerButton() { }

	public virtual void Awake() { }

	[CompilerGenerated]
	public MapEditorArea get_AreaEditor() { }

	public virtual string GetId() { }

	public virtual LayerType GetLayerType() { }

	public virtual string GetLocalisedTitle() { }

	public virtual void Initialise(int categoryLayerIndex, int worldSortingIndex, object metaData) { }

	public void OnAreaChangedEventTriggered(MapEditorSpriteShapeController spline) { }

	public void OnAreaTextureChangedTriggered(MapEditorArea selectedMapEditorArea) { }

	public virtual void OnButtonClicked() { }

	public void OnCategoryTabSwitchedEventTriggered(CategoryButton selectedCategory) { }

	public virtual void OnDeleteLayerButtonClicked() { }

	protected virtual void OnSetSelectedTriggered(EditorLayerButton buttonSelected) { }

	public virtual void OnUpdateLayerIcon() { }

	public virtual void OnVisibleToggleClicked(bool isOn) { }

	public virtual void ReorderWorldSortingOrder(int newWorldSortingOrderIndex) { }

	[CompilerGenerated]
	private void set_AreaEditor(MapEditorArea value) { }

}

