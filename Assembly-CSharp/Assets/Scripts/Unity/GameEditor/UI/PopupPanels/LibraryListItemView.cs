namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class LibraryListItemView : LibraryItemView<LibraryListItemViewModel>
{
	public TextMeshProUGUI description; //Field offset: 0x40

	public LibraryListItemView() { }

	public virtual void Initialise(CustomPrefabModelData data) { }

}

