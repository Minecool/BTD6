namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeStatView : MonoBehaviour
{
	public NK_TextMeshProUGUI title; //Field offset: 0x20
	public NK_TextMeshProUGUI value; //Field offset: 0x28

	public bool IsLoading
	{
		 set { } //Length: 57
	}

	public ChallengeStatView() { }

	public void Load(string titleKey, int qty) { }

	public void set_IsLoading(bool value) { }

}

