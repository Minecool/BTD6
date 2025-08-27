namespace Assets.Scripts.Unity.UI_New.Knowledge;

public class KnowledgeMain : GameMenu
{
	private static bool disabledToggleValue; //Field offset: 0x0
	public NK_TextMeshProUGUI primaryCompletedTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI militaryCompletedTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI magicCompletedTxt; //Field offset: 0x58
	public NK_TextMeshProUGUI supportCompletedTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI heroesCompletedTxt; //Field offset: 0x68
	public NK_TextMeshProUGUI powersCompletedTxt; //Field offset: 0x70
	public NK_TextMeshProUGUI enableMonkeyKnowledge; //Field offset: 0x78
	public NK_TextMeshProUGUI startEarningHint; //Field offset: 0x80
	public GameObject levelBanner; //Field offset: 0x88
	public GameObject storeBanner; //Field offset: 0x90
	public GameObject disableMKGameObject; //Field offset: 0x98
	public Animator disableToggleAnim; //Field offset: 0xA0
	public Toggle disableToggle; //Field offset: 0xA8
	public NK_TextMeshProUGUI disableTxt; //Field offset: 0xB0
	public GameObject respecGameObject; //Field offset: 0xB8
	public Button respecBtn; //Field offset: 0xC0
	public NK_TextMeshProUGUI respecCostTxt; //Field offset: 0xC8

	public KnowledgeMain() { }

	public void AutoLevelUpPurchased() { }

	public virtual void Close() { }

	private void ConfirmRespec() { }

	public void DisableToggleValueChanged() { }

	private void DisplayClassCounts() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	public virtual void Open(object data) { }

	public void OpenPage(int number) { }

	private void PurchaseComplete() { }

	private void RespecClicked() { }

}

