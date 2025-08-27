namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopDifficuiltyMedalPanel : MonoBehaviour
{
	public NK_TextMeshProUGUI difficuiltyTxt; //Field offset: 0x20
	public Image difficuiltyIcon; //Field offset: 0x28
	public Sprite[] difficuiltySprites; //Field offset: 0x30

	public CoopDifficuiltyMedalPanel() { }

	public void Initialise(int difficuiltyIndex, int amount, string textOverride = "") { }

}

