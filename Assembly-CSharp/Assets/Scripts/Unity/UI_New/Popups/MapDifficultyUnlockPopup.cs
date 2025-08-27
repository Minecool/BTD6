namespace Assets.Scripts.Unity.UI_New.Popups;

public class MapDifficultyUnlockPopup : Popup
{
	internal sealed class OnDismiss : MulticastDelegate
	{

		public OnDismiss(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI count; //Field offset: 0x128
	[SerializeField]
	private GameObject[] difficultyObjs; //Field offset: 0x130
	[SerializeField]
	private Image difficultyIcon; //Field offset: 0x138
	[SerializeField]
	private Sprite[] difficultyIcons; //Field offset: 0x140

	public MapDifficultyUnlockPopup() { }

	public void SetCompletion(MapDifficulty difficulty, int completed, int required) { }

}

