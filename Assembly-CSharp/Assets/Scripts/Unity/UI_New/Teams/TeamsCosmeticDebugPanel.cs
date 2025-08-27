namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsCosmeticDebugPanel : MonoBehaviour
{
	public Button showBtn; //Field offset: 0x20
	public Button backBtn; //Field offset: 0x28
	public Button applyBtn; //Field offset: 0x30
	public Button cancelBtn; //Field offset: 0x38
	public Button setDefaultBtn; //Field offset: 0x40
	public TMP_Dropdown buildingSlot; //Field offset: 0x48
	public TMP_Dropdown flyingSlot; //Field offset: 0x50
	public TMP_Dropdown waterSlot; //Field offset: 0x58
	public TMP_Dropdown flagSlot; //Field offset: 0x60
	public TMP_Dropdown base1Slot; //Field offset: 0x68
	public TMP_Dropdown base2Slot; //Field offset: 0x70
	public TMP_Dropdown base3Slot; //Field offset: 0x78
	public TMP_Dropdown base4Slot; //Field offset: 0x80
	public GameObject debugPanel; //Field offset: 0x88
	private CTBaseIsland scriptCTBaseIsland; //Field offset: 0x90
	private bool showingPanel; //Field offset: 0x98

	public TeamsCosmeticDebugPanel() { }

}

