namespace Assets.Scripts.Unity.UI_New.InGame;

public class PropPackPurchaseButton : MonoBehaviour
{
	public Button button; //Field offset: 0x20
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x28
	public Image display; //Field offset: 0x30
	public GameObject purchasedObj; //Field offset: 0x38
	public GameObject selectedObj; //Field offset: 0x40
	private PropPackSelected clickedCallback; //Field offset: 0x48
	private StoreItem storeItem; //Field offset: 0x50
	[HideInInspector]
	public string packName; //Field offset: 0x58
	public Animator animator; //Field offset: 0x60
	private bool unlocked; //Field offset: 0x68
	public GameObject isNewObj; //Field offset: 0x70
	public GameObject pipObj; //Field offset: 0x78

	public PropPackPurchaseButton() { }

	public void Awake() { }

	public void Bind(StoreItem attachedStoreItem, PropPackSelected callback) { }

	private void Clicked() { }

	public bool HasNotSeen() { }

	private void OnDestroy() { }

	public void SetSelected(bool value) { }

	public void Unlock() { }

}

