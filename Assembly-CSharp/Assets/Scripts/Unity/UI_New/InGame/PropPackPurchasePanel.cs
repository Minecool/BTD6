namespace Assets.Scripts.Unity.UI_New.InGame;

public class PropPackPurchasePanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string propPackName; //Field offset: 0x10
		public Func<String, Boolean> <>9__0; //Field offset: 0x18
		public Func<String, Boolean> <>9__1; //Field offset: 0x20
		public Func<String, Boolean> <>9__2; //Field offset: 0x28
		public Func<String, Boolean> <>9__3; //Field offset: 0x30

		public <>c__DisplayClass21_0() { }

		internal bool <GatherPropPackItems>b__0(string collection) { }

		internal bool <GatherPropPackItems>b__1(string collection) { }

		internal bool <GatherPropPackItems>b__2(string collection) { }

		internal bool <GatherPropPackItems>b__3(string collection) { }

	}

	public NK_TextMeshProUGUI title; //Field offset: 0x20
	public NK_TextMeshProUGUI description; //Field offset: 0x28
	public NK_TextMeshProUGUI costTxtIAP; //Field offset: 0x30
	public NK_TextMeshProUGUI costTxtMM; //Field offset: 0x38
	public Button purchaseBtnIAP; //Field offset: 0x40
	public Button purchaseBtnMM; //Field offset: 0x48
	public Button[] closeBtns; //Field offset: 0x50
	public GameObject purchasedObj; //Field offset: 0x58
	public Transform lootContainer; //Field offset: 0x60
	public PropPackItemDisplay lootIconPrefab; //Field offset: 0x68
	private StoreItem storeItem; //Field offset: 0x70
	private bool canClose; //Field offset: 0x78

	public PropPackPurchasePanel() { }

	private void Awake() { }

	private void Close() { }

	private void GatherPropPackItems(string propPackName) { }

	public void OnDestroy() { }

	public void Open(StoreItem item) { }

	private void PurchaseClickedIAP() { }

	private void PurchaseClickedMM() { }

	private void PurchaseComplete() { }

	private void PurchaseFailed() { }

	public void TryClose() { }

}

