namespace Assets.Scripts.Unity.UI_New.Settings;

public class AccessibleRangeCircles : MonoBehaviour
{
	public AccessibleRangeCircle defaultCircle; //Field offset: 0x20
	public AccessibleRangeCircle[] availableCircles; //Field offset: 0x28

	private AccessibilitySettings PlayerAccessibilitySettings
	{
		private get { } //Length: 81
	}

	public AccessibleRangeCircles() { }

	public void Awake() { }

	private AccessibilitySettings get_PlayerAccessibilitySettings() { }

	private void OnAccessibleRangeCircleSelected(TextureReference selectedRangeCircle, TextureReference selectedRangeOutline) { }

}

