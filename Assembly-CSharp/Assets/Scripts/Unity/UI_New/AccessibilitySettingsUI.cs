namespace Assets.Scripts.Unity.UI_New;

public class AccessibilitySettingsUI : GameMenu
{
	[SerializeField]
	private Toggle towerPlacementSnappingToggle; //Field offset: 0x48
	[SerializeField]
	private Animator towerPlacementSnappingAnimator; //Field offset: 0x50

	public AccessibilitySettingsUI() { }

	protected virtual void Awake() { }

	public void OkClicked() { }

	private void OnPlacementSnappingToggled(bool enabled) { }

}

