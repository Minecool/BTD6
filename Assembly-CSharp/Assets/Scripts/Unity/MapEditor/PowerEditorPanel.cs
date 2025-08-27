namespace Assets.Scripts.Unity.MapEditor;

public class PowerEditorPanel : MonoBehaviour
{
	public GameObject powerButtonPrefab; //Field offset: 0x20
	public Transform container; //Field offset: 0x28

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	public PowerEditorPanel() { }

	public void Awake() { }

	public void BindData() { }

	private void ClearContainer() { }

	protected void CreateButton(PowerModel model) { }

	private UnityToSimulation get_Bridge() { }

}

