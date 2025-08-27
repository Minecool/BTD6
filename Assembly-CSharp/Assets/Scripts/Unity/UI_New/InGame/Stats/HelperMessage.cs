namespace Assets.Scripts.Unity.UI_New.InGame.Stats;

public class HelperMessage : MessagerObject
{
	protected readonly string triggerLabel; //Field offset: 0x28
	public Animator animator; //Field offset: 0x30
	public NK_TextMeshProUGUI message; //Field offset: 0x38
	public float clearAt; //Field offset: 0x40

	public HelperMessage() { }

	public override void CloseMessage() { }

	public override void OnCloseHelperMessage(string strMessage, float timeUntilClear = -1) { }

	public override void OnShowHelperMessage(string strMessage, float timeUntilClear = -1) { }

	public override void Update() { }

}

