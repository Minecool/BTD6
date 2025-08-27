namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCParagonRestrictionDisplay : MonoBehaviour
{
	public Image img; //Field offset: 0x20
	public GameObject restrictedIconObj; //Field offset: 0x28
	public GameObject abilityObj; //Field offset: 0x30
	public NK_TextMeshProUGUI paragonName; //Field offset: 0x38
	public GameObject abilityIcon; //Field offset: 0x40
	public Button button; //Field offset: 0x48
	public Action<Boolean> OnParagonRestrictionChanged; //Field offset: 0x50

	public DCParagonRestrictionDisplay() { }

	public void ButtonClicked() { }

	public void Initialise(string towerId) { }

	public void SetRestricted(bool isRestricted) { }

}

