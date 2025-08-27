namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyMapPanel : MonoBehaviour
{
	[HideInInspector]
	internal sealed class ReturnCallback : MulticastDelegate
	{

		public ReturnCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(OdysseyMapPanel panel, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(OdysseyMapPanel panel) { }

	}

	public Toggle tglMapToggle; //Field offset: 0x20
	public Image imgMapImage; //Field offset: 0x28
	public GameObject objCompletedStar; //Field offset: 0x30
	public Animator completeStarAnimator; //Field offset: 0x38
	private bool valueSet; //Field offset: 0x40
	private bool currentSelectedMap; //Field offset: 0x41
	private ReturnCallback callback; //Field offset: 0x48

	public OdysseyMapPanel() { }

	public void Initialize(string mapName, bool completed, bool currentSelectedMap, ReturnCallback callback = null) { }

	public void OnToggleClicked(bool isOn) { }

	public void ToggleActive(bool active) { }

}

