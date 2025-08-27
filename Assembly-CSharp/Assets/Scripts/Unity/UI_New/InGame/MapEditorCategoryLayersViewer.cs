namespace Assets.Scripts.Unity.UI_New.InGame;

public class MapEditorCategoryLayersViewer : MonoBehaviour
{
	public Button expandViewBtn; //Field offset: 0x20
	public GameObject expandPanelImage; //Field offset: 0x28
	public GameObject panelToExpand; //Field offset: 0x30
	public GameObject layersSorter; //Field offset: 0x38
	public PipEventChecker pathWarningDropdownPip; //Field offset: 0x40
	public LayerButtonProxy layerButtonProxyPrefab; //Field offset: 0x48
	public bool showWarningPip; //Field offset: 0x50
	[CompilerGenerated]
	private List<LayerButtonProxy> <layerButtonProxys>k__BackingField; //Field offset: 0x58

	public private List<LayerButtonProxy> layerButtonProxys
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public MapEditorCategoryLayersViewer() { }

	public void Awake() { }

	public void Bind(LayerType layerType, List<EditorLayerButton> layers) { }

	private void CleanUp() { }

	[CompilerGenerated]
	public List<LayerButtonProxy> get_layerButtonProxys() { }

	private void OnClickedExpandButton() { }

	public void OnDestroy() { }

	[CompilerGenerated]
	private void set_layerButtonProxys(List<LayerButtonProxy> value) { }

}

