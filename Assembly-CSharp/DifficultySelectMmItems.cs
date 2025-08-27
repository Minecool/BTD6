//Type is in global namespace

public class DifficultySelectMmItems : MonoBehaviour
{
	private static Dictionary<String, String> modeUnlocks; //Field offset: 0x0
	public GameObject monkeyMoneyIconLarge; //Field offset: 0x20
	public NK_TextMeshProUGUI largeTxt; //Field offset: 0x28
	public GameObject monkeyMoneyIconSmall; //Field offset: 0x30
	public NK_TextMeshProUGUI smallTxt; //Field offset: 0x38
	public string difficulty; //Field offset: 0x40

	public DifficultySelectMmItems() { }

	private List<String> GetModes(string difficulty) { }

	private string GetModeUnlock(string mode) { }

	public void Initialise() { }

}

