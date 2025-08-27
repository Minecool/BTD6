namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossSelectPanel : MonoBehaviour
{
	internal sealed class GetBossCallback : MulticastDelegate
	{

		public GetBossCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BossType boss, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BossType boss) { }

	}

	internal sealed class GoToEventCallback : MulticastDelegate
	{

		public GoToEventCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public Transform buttonsContainer; //Field offset: 0x20
	public BossSelectButton buttonPrefab; //Field offset: 0x28
	private List<BossSelectButton> buttons; //Field offset: 0x30
	public NK_TextMeshProUGUI bossSelectTitleTxt; //Field offset: 0x38
	public NK_TextMeshProUGUI bossSelectDescTxt; //Field offset: 0x40
	private BossType selectedBoss; //Field offset: 0x48
	public Button okButton; //Field offset: 0x50
	public Lightbox closeButton; //Field offset: 0x58
	public Button goToEventBtn; //Field offset: 0x60
	private bool isInitialized; //Field offset: 0x68
	private GoToEventCallback goToEventCallback; //Field offset: 0x70
	private Nullable<BossType> currentEventBoss; //Field offset: 0x78
	private BossType currentSelectedBoss; //Field offset: 0x80
	private GetBossCallback selectBossCallback; //Field offset: 0x88
	private bool eventBossSelected; //Field offset: 0x90

	public BossSelectPanel() { }

	private void Awake() { }

	public void Close() { }

	public void ForceClose() { }

	private void OnDestroy() { }

	public void Open(GetBossCallback selectBossCallback, GoToEventCallback goToEventCallback, BossType currentSelectedBoss, Nullable<BossType> currentEventBoss) { }

	public void SelectBoss(BossType bossType) { }

	public void ShowInternetPopup() { }

}

