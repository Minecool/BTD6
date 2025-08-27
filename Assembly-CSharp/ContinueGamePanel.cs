//Type is in global namespace

public class ContinueGamePanel : MonoBehaviour
{
	[SerializeField]
	private TMP_Text lblDetails; //Field offset: 0x20
	[SerializeField]
	private GameObject replayBtn; //Field offset: 0x28
	private MapSaveDataModel saveData; //Field offset: 0x30

	public ContinueGamePanel() { }

	public void ContinueClicked() { }

	public void Initialise() { }

	public void ReplayClicked() { }

}

