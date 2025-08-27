namespace Assets.Scripts.Unity.UI_New.Settings;

public class AccessibleRangeCircle : MonoBehaviour
{
	public TextureReference texture; //Field offset: 0x20
	public TextureReference outline; //Field offset: 0x28
	public Button button; //Field offset: 0x30
	public Image selectedImage; //Field offset: 0x38
	public Action<TextureReference, TextureReference> OnAccessibleRangeCircleSelected; //Field offset: 0x40

	public AccessibleRangeCircle() { }

	private void ButtonClicked() { }

	public void Initialise(bool isSelected) { }

	public void OnDestroy() { }

	public void RemoveSelectedIcon() { }

}

