//Type is in global namespace

public class TowerUnlockSelectionPanel : MonoBehaviour
{
	public TowerImageLoader towerImageLoader; //Field offset: 0x20
	public string towerId; //Field offset: 0x28
	public Button button; //Field offset: 0x30
	public GameObject fillBarContainerObject; //Field offset: 0x38
	public Image fillBarImage; //Field offset: 0x40
	public TMP_Text goalText; //Field offset: 0x48
	public GameObject isSelectedObject; //Field offset: 0x50
	public GameObject isNewObject; //Field offset: 0x58
	public GameObject isLockedObject; //Field offset: 0x60
	public TMP_Text lockedText; //Field offset: 0x68
	public GameObject isHighlightedObject; //Field offset: 0x70
	private TowerGiftBoxScreen towerGiftBoxScreen; //Field offset: 0x78

	public TowerUnlockSelectionPanel() { }

	public void Bind(TowerGiftBoxScreen towerGiftBoxScreen, string towerId, int goal, int currentProgress, bool isNew, bool isLocked, int unlockedAt, bool useLevel1Portrait) { }

	private void OnClicked() { }

	public void SetIsHighlighted(bool isHighlighted) { }

	public void SetIsSelelected(bool isSelected) { }

}

