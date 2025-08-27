namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCPowerDisplay : MonoBehaviour
{
	public PowerImageLoader imgLoader; //Field offset: 0x20
	public GameObject powerCountGO; //Field offset: 0x28
	public TMP_Text powerCountTxt; //Field offset: 0x30
	public GameObject excludedGO; //Field offset: 0x38

	public DCPowerDisplay() { }

}

