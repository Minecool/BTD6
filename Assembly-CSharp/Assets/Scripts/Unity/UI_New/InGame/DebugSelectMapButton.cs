namespace Assets.Scripts.Unity.UI_New.InGame;

public class DebugSelectMapButton : MonoBehaviour
{
	private static readonly Regex pascalToSpaceRegex; //Field offset: 0x0
	private MapDetails mapDetails; //Field offset: 0x20
	private Action<MapDetails> onButtonClicked; //Field offset: 0x28
	public Button button; //Field offset: 0x30
	public NK_TextMeshProUGUI buttonText; //Field offset: 0x38
	public Image buttonBackground; //Field offset: 0x40

	private static DebugSelectMapButton() { }

	public DebugSelectMapButton() { }

	private void ButtonClicked() { }

	public void Setup(MapDetails mapDetails, Action<MapDetails> onButtonClicked, Color beginner, Color intermediate, Color advanced, Color expert) { }

}

