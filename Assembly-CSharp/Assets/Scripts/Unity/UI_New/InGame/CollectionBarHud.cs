namespace Assets.Scripts.Unity.UI_New.InGame;

public class CollectionBarHud : MonoBehaviour
{
	public Image icon; //Field offset: 0x20
	public TextMeshProUGUI currentAmountText; //Field offset: 0x28
	public Image fillBar; //Field offset: 0x30

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	public CollectionBarHud() { }

	private LocalizationManager get_Locs() { }

	public void Initialise(SpriteReference iconRef) { }

	private void OnCountChanged(int currAmount, int totalAmount) { }

	public void OnGameStart() { }

}

