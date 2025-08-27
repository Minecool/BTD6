namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossSelectButton : MonoBehaviour
{
	public GameObject selectedObj; //Field offset: 0x20
	public BossType boss; //Field offset: 0x28
	public Button button; //Field offset: 0x30
	public Image icon; //Field offset: 0x38
	public GameObject inEventObj; //Field offset: 0x40
	public NK_TextMeshProUGUI timer; //Field offset: 0x48
	private GetBossCallback getBossCallback; //Field offset: 0x50
	private BossEvent bossEvent; //Field offset: 0x58

	public BossSelectButton() { }

	public void Awake() { }

	public void Bind(BossType bossType, GetBossCallback callback) { }

	private void GetBoss() { }

	private void OnDestroy() { }

	public void SetUnavailable() { }

	private void Update() { }

}

