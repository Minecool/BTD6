namespace Assets.Scripts.Unity.UI_New.Settings;

public class LanguageSelectButton : MonoBehaviour
{
	[CompilerGenerated]
	private struct <SwitchLanuage>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Language languageCode; //Field offset: 0x20
		public Language prevLanguage; //Field offset: 0x24
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Language languageCode; //Field offset: 0x20
	public Image textImage; //Field offset: 0x28
	public Button btn; //Field offset: 0x30
	public Image selectedImage; //Field offset: 0x38
	public SpriteReference selectedSprite; //Field offset: 0x40
	public SpriteReference deselectedSprite; //Field offset: 0x48

	public LanguageSelectButton() { }

	public void Bind(Language languageCode, SpriteReference textSprite) { }

	public void Clicked() { }

	public void RefreshButtonState() { }

	[AsyncStateMachine(typeof(<SwitchLanuage>d__9))]
	private static Task SwitchLanuage(Language languageCode, Language prevLanguage) { }

}

