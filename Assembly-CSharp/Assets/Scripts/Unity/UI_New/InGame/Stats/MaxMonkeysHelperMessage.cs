namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class MaxMonkeysHelperMessage : MessagerObject
{
	protected readonly string triggerLabel; //Field offset: 0x28
	public Animator animator; //Field offset: 0x30
	public NK_TextMeshProUGUI message; //Field offset: 0x38
	public float clearAt; //Field offset: 0x40
	private bool showingMessageText; //Field offset: 0x44

	public MaxMonkeysHelperMessage() { }

	private void CloseMessage() { }

	public void OnCloseHelperMessage(string strMessage, float timeUntilClear = -1) { }

	public void OnShowHelperMessage(string strMessage, float timeUntilClear = -1) { }

	public void Update() { }

}

