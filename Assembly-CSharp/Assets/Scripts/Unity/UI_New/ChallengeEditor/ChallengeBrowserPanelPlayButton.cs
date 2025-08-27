namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeBrowserPanelPlayButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__10_0() { }

	}

	public Button playBtn; //Field offset: 0x20
	public Button replayBtn; //Field offset: 0x28
	public Button continueBtn; //Field offset: 0x30
	public Image loadingImg; //Field offset: 0x38
	[CompilerGenerated]
	private UnityAction OnClick; //Field offset: 0x40

	public event UnityAction OnClick
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public ChallengeBrowserPanelPlayButton() { }

	[CompilerGenerated]
	public void add_OnClick(UnityAction value) { }

	[CompilerGenerated]
	public void remove_OnClick(UnityAction value) { }

	public void SetInteractable(bool isInteractable) { }

	public void SetState(PlayButtonState playButtonState) { }

	private void Start() { }

}

