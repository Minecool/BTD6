namespace Assets.Scripts.Unity.Gamepad.Jewel;

public class JewelBar : MonoBehaviour
{
	public static JewelBar instance; //Field offset: 0x0
	[SerializeField]
	private JewelBarItem prefab; //Field offset: 0x20
	[SerializeField]
	private RectTransform container; //Field offset: 0x28
	[SerializeField]
	private Image bgContainer; //Field offset: 0x30
	private Dictionary<GamepadInputType, JewelBarItem> items; //Field offset: 0x38
	[CompilerGenerated]
	private Action<Boolean> ActiveChanged; //Field offset: 0x40
	private List<GamepadContext> contextStack; //Field offset: 0x48
	private List<Jewel> tempJewels; //Field offset: 0x50
	private bool hasActiveJewelBars; //Field offset: 0x58
	private bool overideDisabled; //Field offset: 0x59

	public event Action<Boolean> ActiveChanged
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public JewelBar() { }

	[CompilerGenerated]
	private void <Start>b__29_0(InputSystemMode _) { }

	private void Add(GamepadInputType buttonCode) { }

	[CompilerGenerated]
	public void add_ActiveChanged(Action<Boolean> value) { }

	private void Awake() { }

	private void Clear() { }

	private void ClearContext(GamepadContext c) { }

	public bool HasContext() { }

	private void LateUpdate() { }

	private void OnButtonClicked(GamepadInputType buttonCode, int userIndex) { }

	private void OnControlAdded(BaseJewelBarControl btn) { }

	private void OnControlRemoved(BaseJewelBarControl btn) { }

	private void OnDestroy() { }

	public void OverrideDisable(bool overideDisabled) { }

	private GamepadContext Peek() { }

	private GamepadContext Pop(GamepadContext context) { }

	public void PopContext(GamepadContext context) { }

	public void PushContext(GamepadContext context) { }

	public void RefreshControls() { }

	[CompilerGenerated]
	public void remove_ActiveChanged(Action<Boolean> value) { }

	private void Start() { }

	private void Update() { }

	private void UpdateActive() { }

	private void UpdateContext(GamepadContext c) { }

}

