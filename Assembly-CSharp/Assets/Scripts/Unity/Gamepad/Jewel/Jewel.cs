namespace Assets.Scripts.Unity.Gamepad.Jewel;

[RequireComponent(typeof(Image))]
public class Jewel : MonoBehaviour, IBindActiveTarget
{
	public GamepadInputType buttonCode; //Field offset: 0x20
	public Button button; //Field offset: 0x28
	public Transform activeContainer; //Field offset: 0x30
	private Image jewelImage; //Field offset: 0x38
	private bool observedObjectActive; //Field offset: 0x40
	private bool isActive; //Field offset: 0x41
	private GamepadContext _context; //Field offset: 0x48

	private GamepadContext context
	{
		private get { } //Length: 272
	}

	public Jewel() { }

	[CompilerGenerated]
	private void <Start>b__10_0(InputSystemMode _) { }

	private void ApplyActive(bool active) { }

	private void Awake() { }

	private GamepadContext get_context() { }

	private void OnButtonClicked(GamepadInputType buttonCode, int userIndex) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public override void OnSetActive(bool active) { }

	private void Start() { }

	private void Update() { }

	public void UpdateActive() { }

}

