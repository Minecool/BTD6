namespace Assets.Scripts.Unity.MapEditor;

public class TowerEditorPanel : MonoBehaviour
{
	public GameObject towerButtonPrefab; //Field offset: 0x20
	public Transform container; //Field offset: 0x28

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	public TowerEditorPanel() { }

	public void Awake() { }

	public void BindData() { }

	private void ClearContainer() { }

	private ITowerPurchaseButton CreateButton(TowerModel model, int buttonIndex) { }

	private UnityToSimulation get_Bridge() { }

}

