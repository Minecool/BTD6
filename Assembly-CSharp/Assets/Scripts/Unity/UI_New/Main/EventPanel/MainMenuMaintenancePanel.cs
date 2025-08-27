namespace Assets.Scripts.Unity.UI_New.Main.EventPanel;

public class MainMenuMaintenancePanel : MonoBehaviour
{
	[SerializeField]
	private NK_TextMeshProUGUI timerText; //Field offset: 0x20
	[SerializeField]
	private Button button; //Field offset: 0x28
	private ServerMaintenanceEvent serverMaintenanceEvent; //Field offset: 0x30
	private float updateSecondTimer; //Field offset: 0x38

	private static DateTime Now
	{
		private get { } //Length: 7
	}

	public MainMenuMaintenancePanel() { }

	private void Awake() { }

	public void Bind(ServerMaintenanceEvent serverMaintenanceEvent) { }

	private static DateTime get_Now() { }

	private void Update() { }

	private void UpdateTimer() { }

}

