namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class OdysseyPanel : ContentBrowserPanel
{
	public Image hardImg; //Field offset: 0xE0
	public Image mediumImg; //Field offset: 0xE8
	public Image easyImg; //Field offset: 0xF0
	public GameObject extremeModeObj; //Field offset: 0xF8

	public OdysseyPanel() { }

	public virtual void Init(PlayerContent playerContent, BrowserBase browser) { }

	public virtual void OpenPlayScene(IContentBrowserData data) { }

	private void SetDifficultyIcon() { }

}

