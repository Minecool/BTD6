namespace Assets.Scripts.Unity.UI_New.Utils;

public class InputFieldPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public InputFieldPopup <>4__this; //Field offset: 0x10
		public Action<String> okCallback; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal void <Init>b__0() { }

	}

	public TMP_InputField input; //Field offset: 0x128

	public InputFieldPopup() { }

	public void Init(Action<String> okCallback, string defaultValue, BackGround background, TransitionAnim transition) { }

	public void OnConfirm(Action<String> okCallback) { }

}

