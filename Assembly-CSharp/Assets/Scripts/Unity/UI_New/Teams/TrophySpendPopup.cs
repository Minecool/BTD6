namespace Assets.Scripts.Unity.UI_New.Teams;

public class TrophySpendPopup : MonoBehaviour
{
	public TMP_Text currentContributionText; //Field offset: 0x20
	public TMP_Text spendText; //Field offset: 0x28
	public Button addOneButton; //Field offset: 0x30
	public Button addTenButton; //Field offset: 0x38
	public Button addHundredButton; //Field offset: 0x40
	public Button maxButton; //Field offset: 0x48
	public Button defaultButton; //Field offset: 0x50
	public Button okButton; //Field offset: 0x58
	public Button cancelButton; //Field offset: 0x60
	public Lightbox backgroundButton; //Field offset: 0x68
	public Action<Int32, String> OnSpendTrophies; //Field offset: 0x70
	private string itemId; //Field offset: 0x78
	private int currentContribution; //Field offset: 0x80
	private int maxTrophies; //Field offset: 0x84
	private int spendAmount; //Field offset: 0x88
	private int initialSpendAmount; //Field offset: 0x8C

	public TrophySpendPopup() { }

	[CompilerGenerated]
	private void <Start>b__16_0() { }

	[CompilerGenerated]
	private void <Start>b__16_1() { }

	[CompilerGenerated]
	private void <Start>b__16_2() { }

	public void Hide() { }

	private void OnAddButton(int amount) { }

	private void OnCancelButton() { }

	private void OnDefaultButtonClicked() { }

	private void OnMaxButton() { }

	private void OnOkayButton() { }

	public void Show(string itemId, int currentContribution, int maxTrophies) { }

	public void Start() { }

	private void UpdateUI() { }

}

