namespace Assets.Scripts.Unity.Gamepad.Jewel;

[RequireComponent(typeof(Image))]
public class ToggleJewel : MonoBehaviour, IBindActiveTarget
{
	public GamepadInputType buttonCode; //Field offset: 0x20
	public Toggle toggle; //Field offset: 0x28
	public bool isPopup; //Field offset: 0x30
	private bool popupEventsAttached; //Field offset: 0x31
	private bool observedObjectActive; //Field offset: 0x32
	private GamepadContext context; //Field offset: 0x38

	public ToggleJewel() { }

	[CompilerGenerated]
	private void <Start>b__6_0(InputSystemMode _) { }

	private void HasActivePopupHandleChanged(bool hasPopup) { }

	private void OnButtonClicked(GamepadInputType buttonCode, int userIndex) { }

	public override void OnSetActive(bool active) { }

	private void Start() { }

	private void UpdateActive() { }

}

