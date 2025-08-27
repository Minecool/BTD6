namespace Assets.Scripts.Unity.UI_New.Utils;

public class ParagonConfirmationPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public ParagonConfirmationPopup <>4__this; //Field offset: 0x10
		public Action<Double> okCallback; //Field offset: 0x18
		public Action cancelCallback; //Field offset: 0x20

		public <>c__DisplayClass8_0() { }

		internal void <Init>b__0() { }

		internal void <Init>b__1() { }

	}

	public Button leftArrow; //Field offset: 0x128
	public Button rightArrow; //Field offset: 0x130
	public Button resetButton; //Field offset: 0x138
	public Slider currentSlider; //Field offset: 0x140
	public NK_TextMeshProUGUI currentInvestmentText; //Field offset: 0x148
	public NK_TextMeshProUGUI totalInvestmentText; //Field offset: 0x150
	private int upgradeCost; //Field offset: 0x158
	private int tweakAmount; //Field offset: 0x15C

	public ParagonConfirmationPopup() { }

	public void Init(Action<Double> okCallback, Action cancelCallback, int currentCash, int maxCash, int upgradeCost, BackGround background, TransitionAnim transition) { }

	private void Init(int currentCash, int maxCash, int upgradeCost) { }

	public void OnCancel(Action cancelCallback) { }

	public void OnConfirm(Action<Double> okCallback) { }

	private void ResetInvestment() { }

	private void TweakInvestmentLeft() { }

	private void TweakInvestmentRight() { }

	private void UpdateCurrentInvestment(float current) { }

}

