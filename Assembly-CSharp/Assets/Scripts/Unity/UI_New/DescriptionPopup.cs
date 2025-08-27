namespace Assets.Scripts.Unity.UI_New;

public class DescriptionPopup : MonoBehaviour
{
	internal sealed class HideDescriptionPopup : MulticastDelegate
	{

		public HideDescriptionPopup(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string title, string description, Vector3 position, bool hideAll, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string title, string description, Vector3 position, bool hideAll = false) { }

	}

	internal sealed class ShowDescriptionPopup : MulticastDelegate
	{

		public ShowDescriptionPopup(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string title, string description, Vector3 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string title, string description, Vector3 position) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI descriptionTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x28
	[SerializeField]
	private bool worldSpace; //Field offset: 0x30
	[SerializeField]
	private string restrictToScene; //Field offset: 0x38
	private string description; //Field offset: 0x40
	private Vector3 position; //Field offset: 0x48

	public DescriptionPopup() { }

	private void Awake() { }

	private void HidePopup(string title, string description, Vector3 position, bool hideAll) { }

	private void ShowPopup(string title, string description, Vector3 position) { }

}

