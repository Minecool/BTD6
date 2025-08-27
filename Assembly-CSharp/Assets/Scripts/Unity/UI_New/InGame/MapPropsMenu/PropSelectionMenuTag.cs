namespace Assets.Scripts.Unity.UI_New.InGame.MapPropsMenu;

public class PropSelectionMenuTag : MonoBehaviour
{
	[HideInInspector]
	public string tagName; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI textDisplay; //Field offset: 0x28

	public PropSelectionMenuTag() { }

	public void SetTag(string name) { }

}

