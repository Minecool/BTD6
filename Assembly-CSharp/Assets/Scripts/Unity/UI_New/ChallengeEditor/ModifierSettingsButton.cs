namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ModifierSettingsButton : MonoBehaviour
{
	public Button selectButton; //Field offset: 0x20
	public Toggle includeToggle; //Field offset: 0x28
	public Image icon; //Field offset: 0x30
	private ChallengeEditorModifierSettings parentPanel; //Field offset: 0x38
	public string titleLocKey; //Field offset: 0x40
	public string descriptionLocKey; //Field offset: 0x48
	public SpriteReference includeSprite; //Field offset: 0x50
	public SpriteReference excludeSprite; //Field offset: 0x58
	public Image toggleIcon; //Field offset: 0x60

	public ModifierSettingsButton() { }

	public void Awake() { }

	public void Select() { }

	public void SetValue(bool isOn) { }

	public void ValueChanged(bool isOn) { }

}

