namespace Assets.Scripts.Unity.UI_New.InGame.BloonMenu;

public class SpawnBloonButton : MonoBehaviour
{
	private static int emissionIndexOffset; //Field offset: 0x0
	private BloonModel model; //Field offset: 0x20
	private TMP_InputField count; //Field offset: 0x28
	private TMP_InputField rate; //Field offset: 0x30
	private TMP_InputField round; //Field offset: 0x38
	private bool iconSet; //Field offset: 0x40
	public Image bloonIcon; //Field offset: 0x48
	private Button button; //Field offset: 0x50

	public Button Button
	{
		 get { } //Length: 129
	}

	public BloonModel Model
	{
		 get { } //Length: 5
	}

	public SpawnBloonButton() { }

	public Button get_Button() { }

	public BloonModel get_Model() { }

	public BloonEmissionModel[] GetEmissions(int count, int spacing) { }

	public void SetBloon(BloonModel model, TMP_InputField count, TMP_InputField rate, TMP_InputField round) { }

	public void SpawnBloon() { }

	public void Update() { }

	private void UpdateIcon() { }

}

