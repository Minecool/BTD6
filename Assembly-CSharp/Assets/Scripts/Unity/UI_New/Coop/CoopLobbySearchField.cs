namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopLobbySearchField : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string inputString; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <OnSearchStrChanged>b__0(string deepLinkUrl) { }

		internal bool <OnSearchStrChanged>b__1(string shareString) { }

	}

	[SerializeField]
	private TMP_InputField inputField; //Field offset: 0x20
	private readonly DeepLinkType[] coopDeepLinkTypes; //Field offset: 0x28
	private String[] _shareStrings; //Field offset: 0x30
	private readonly String[] deepLinkUrls; //Field offset: 0x38

	private String[] ShareStrings
	{
		private get { } //Length: 230
	}

	public CoopLobbySearchField() { }

	private void Awake() { }

	private String[] get_ShareStrings() { }

	private static bool IsValidLobbyId(string text) { }

	private void OnSearchStrChanged(string inputString) { }

	private static bool TryGetLobbyIdFromShareString(string shareString, DeepLinkType deepLinkType, out string contentId) { }

}

