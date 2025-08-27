namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class GameCurationPanel : MapPanel
{
	[SerializeField]
	private Button validateButton; //Field offset: 0x110
	[SerializeField]
	private Button rejectButton; //Field offset: 0x118
	[SerializeField]
	private Button inspectButton; //Field offset: 0x120
	[SerializeField]
	private Image reportedImage; //Field offset: 0x128
	[SerializeField]
	private GameObject adminValidatedBackground; //Field offset: 0x130
	[SerializeField]
	private GameObject contentDeletedBackground; //Field offset: 0x138

	private CurationBrowser CurationBrowser
	{
		private get { } //Length: 129
	}

	private static int RequiredReports
	{
		private get { } //Length: 249
	}

	public GameCurationPanel() { }

	protected virtual void Awake() { }

	private CurationBrowser get_CurationBrowser() { }

	private static int get_RequiredReports() { }

	public virtual void Init(PlayerContent playerContent, BrowserBase browser) { }

	private void OnFavoriteToggled(ContentType contentType, string contentId, bool isFavorite) { }

	private void OnRejectClicked() { }

	private void OnValidateClicked() { }

	private void OpenCurationInfoPanel() { }

	public virtual void OpenPlayScene(IContentBrowserData _) { }

}

