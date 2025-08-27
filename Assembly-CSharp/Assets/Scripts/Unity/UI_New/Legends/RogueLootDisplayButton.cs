namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueLootDisplayButton : MonoBehaviour
{
	internal sealed class RogueInstaIconSelected : MulticastDelegate
	{

		public RogueInstaIconSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueLootDisplayButton insta, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueLootDisplayButton insta) { }

	}

	[SerializeField]
	private Button selectBtn; //Field offset: 0x20
	[SerializeField]
	private Image lootImage; //Field offset: 0x28
	[SerializeField]
	private Image lootRarityImage; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI pathTxt; //Field offset: 0x38
	[HideInInspector]
	public RogueInstaMonkey insta; //Field offset: 0x40
	public GameObject selectionObj; //Field offset: 0x48
	private RogueInstaIconSelected instaCallback; //Field offset: 0x50

	public RogueLootDisplayButton() { }

	private void Awake() { }

	public void Bind(RogueInstaMonkey insta, RogueInstaIconSelected instaCallback) { }

	private void Selected() { }

}

