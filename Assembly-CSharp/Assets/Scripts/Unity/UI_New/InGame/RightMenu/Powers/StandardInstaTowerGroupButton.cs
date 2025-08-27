namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

internal class StandardInstaTowerGroupButton : MonoBehaviour
{
	protected TowerModel baseTowerModel; //Field offset: 0x20
	public Image icon; //Field offset: 0x28
	public Color lockedColor; //Field offset: 0x30
	public Color lockedTextColor; //Field offset: 0x40
	public NK_TextMeshProUGUI powerCountText; //Field offset: 0x50
	private Image bg; //Field offset: 0x58

	public StandardInstaTowerGroupButton() { }

	public void CheckInventory() { }

	public TowerModel GetBaseTower() { }

	public void SetAvailable() { }

	public void SetBaseTower(TowerModel baseTowerModel) { }

	public void SetUnavailable() { }

	public void UpdateIcon() { }

	public void UpdateQuantity() { }

}

