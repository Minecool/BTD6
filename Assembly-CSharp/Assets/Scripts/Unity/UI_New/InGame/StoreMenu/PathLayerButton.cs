namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class PathLayerButton : EditorLayerButton
{
	[CompilerGenerated]
	private MapEditorPath <PathEditor>k__BackingField; //Field offset: 0x80

	public private MapEditorPath PathEditor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public int PathWidth
	{
		 get { } //Length: 142
	}

	public PathLayerButton() { }

	public virtual void Awake() { }

	[CompilerGenerated]
	public MapEditorPath get_PathEditor() { }

	public int get_PathWidth() { }

	public virtual string GetId() { }

	public virtual LayerType GetLayerType() { }

	public virtual string GetLocalisedTitle() { }

	public virtual bool HasButtonWarnings() { }

	public virtual void Initialise(int categoryLayerIndex, int worldSortingIndex, object metaData) { }

	public virtual void OnButtonClicked() { }

	public void OnCategoryTabSwitchedEventTriggered(CategoryButton selectedCategory) { }

	public virtual void OnDeleteLayerButtonClicked() { }

	public void OnPathChangedEventTriggered(MapEditorSpriteShapeController spline) { }

	public void OnPathTextureChangedTriggered(MapEditorPath selectedMapEditorPath) { }

	protected virtual void OnSetSelectedTriggered(EditorLayerButton buttonSelected) { }

	public virtual void OnUpdateLayerIcon() { }

	public virtual void OnVisibleToggleClicked(bool isOn) { }

	public virtual void ReorderWorldSortingOrder(int newWorldSortingOrderIndex) { }

	[CompilerGenerated]
	private void set_PathEditor(MapEditorPath value) { }

}

