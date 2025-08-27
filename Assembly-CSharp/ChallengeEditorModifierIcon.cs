//Type is in global namespace

public class ChallengeEditorModifierIcon : MonoBehaviour
{
	[SerializeField]
	private Button button; //Field offset: 0x20
	private ChallengeEditorModifierSettings modifierSettings; //Field offset: 0x28
	[HideInInspector]
	public string locsText; //Field offset: 0x30

	public ChallengeEditorModifierIcon() { }

	public void Bind(ChallengeEditorModifierSettings modifierSettings, string locsText) { }

	private void HidePopup(BaseEventData eventData) { }

	private void ShowPopup(BaseEventData eventData) { }

}

