namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class GameEditorLibraryView : MonoBehaviour
{
	public Button createBtn; //Field offset: 0x20
	public Button backBtn; //Field offset: 0x28
	public GameObject panel; //Field offset: 0x30
	public GameObject libraryList; //Field offset: 0x38
	public GameObject libraryGrid; //Field offset: 0x40
	public Transform libraryListTransform; //Field offset: 0x48
	public Transform libraryGridTransform; //Field offset: 0x50
	public LibraryListItemView libraryListItemViewPrefab; //Field offset: 0x58
	public LibraryGridItemView libraryGridItemViewPrefab; //Field offset: 0x60
	private GameEditorLibraryViewModel ViewModel; //Field offset: 0x68
	private Transform SelectedTransform; //Field offset: 0x70

	public GameEditorLibraryView() { }

	[CompilerGenerated]
	private void <Initialise>b__11_0() { }

	[CompilerGenerated]
	private void <Initialise>b__11_1() { }

	private void CreateLibraryItem(CustomPrefabModelData data) { }

	public void Initialise(GameEditorPrefabType prefabType) { }

	public void OnDestroy() { }

	public void OnItemsListChangedTriggered() { }

}

