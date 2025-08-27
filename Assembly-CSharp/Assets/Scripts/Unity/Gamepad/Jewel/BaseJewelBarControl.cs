namespace Assets.Scripts.Unity.Gamepad.Jewel;

public abstract class BaseJewelBarControl : MonoBehaviour
{
	public GamepadInputType buttonCode; //Field offset: 0x20
	public GameObject activeTarget; //Field offset: 0x28
	public TMP_Text text; //Field offset: 0x30
	public string jewelBarLocalizationKey; //Field offset: 0x38
	public Image pointerImage; //Field offset: 0x40
	private GamepadContext context; //Field offset: 0x48

	protected BaseJewelBarControl() { }

	[CompilerGenerated]
	private void <Start>b__13_0(InputSystemMode _) { }

	public abstract Selectable GetSelectable() { }

	public string GetText() { }

	public bool HasText() { }

	public bool IsInteractable() { }

	public void OnButtonClicked() { }

	private void OnDestroy() { }

	protected abstract void OnSubmitSelectable() { }

	protected void RefreshDisplay() { }

	protected override void Start() { }

	protected override void Tick() { }

	private void Update() { }

}

