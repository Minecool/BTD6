namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushRelicDisplay : MonoBehaviour
{
	internal sealed class OnRelicSelected : MulticastDelegate
	{

		public OnRelicSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ContestedTerritoryRelicType relicType, bool exit, float position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ContestedTerritoryRelicType relicType, bool exit, float position) { }

	}

	[SerializeField]
	private GameObject selectedObj; //Field offset: 0x20
	[SerializeField]
	private Image iconImage; //Field offset: 0x28
	private Button button; //Field offset: 0x30
	private ContestedTerritoryRelicType relicType; //Field offset: 0x38

	public BossRushRelicDisplay() { }

	private void Awake() { }

	public void Bind(ContestedTerritoryRelicType relicType) { }

	private void OnExitHover(BaseEventData eventData) { }

	private void OnHover(BaseEventData eventData) { }

}

