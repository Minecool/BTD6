namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ExtraSettingsPanel : MonoBehaviour
{
	public GameObject panel; //Field offset: 0x20
	public Toggle toggle; //Field offset: 0x28
	public Animator animator; //Field offset: 0x30

	public ExtraSettingsPanel() { }

	private void Awake() { }

	public void SetAnimator(bool isOn) { }

}

