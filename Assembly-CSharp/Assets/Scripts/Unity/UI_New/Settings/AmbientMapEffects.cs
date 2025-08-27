namespace Assets.Scripts.Unity.UI_New.Settings;

public class AmbientMapEffects : MonoBehaviour
{
	public Toggle toggle; //Field offset: 0x20
	public Animator animator; //Field offset: 0x28

	private AccessibilitySettings PlayerAccessibilitySettings
	{
		private get { } //Length: 81
	}

	public AmbientMapEffects() { }

	private void AmbientMapEffectsToggled(bool isOn) { }

	public void Awake() { }

	private AccessibilitySettings get_PlayerAccessibilitySettings() { }

	public void OnDestroy() { }

}

