namespace Assets.Scripts.Unity.UI_New.Tutorial;

public class TutorialScreen : GameMenu
{
	public AudioClip tutorialBGA; //Field offset: 0x48
	public Button startTutorialBtn; //Field offset: 0x50
	public Lightbox startTutorialBackgroundBtn; //Field offset: 0x58

	public TutorialScreen() { }

	private void ClickStartTutorial() { }

	public virtual void Close() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public virtual void Open(object menuData) { }

	private void PlayTutorialBGA() { }

	public void StopTutorialBGA() { }

}

