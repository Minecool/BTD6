namespace Assets.Scripts.Unity.Gamepad;

public class GamepadContext : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Func<GameObject> getFirstGameObjectCallback; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <SubscribeToSelectFirstGameObject>b__0() { }

	}

	private static Dictionary<String, String> contextDefaultSelections; //Field offset: 0x0
	public GameObject firstSelected; //Field offset: 0x20
	public bool hasFocus; //Field offset: 0x28
	public bool autoNav; //Field offset: 0x29
	private CommonPanel commonPanel; //Field offset: 0x30
	[CompilerGenerated]
	private Action<BaseJewelBarControl> ControlAdded; //Field offset: 0x38
	[CompilerGenerated]
	private Action<BaseJewelBarControl> ControlRemoved; //Field offset: 0x40
	public Action getFirstGameObjectCallback; //Field offset: 0x48
	public List<BaseJewelBarControl> jewelBarControls; //Field offset: 0x50
	public List<Jewel> jewels; //Field offset: 0x58
	private bool registeredCommonPanel; //Field offset: 0x60
	private Transform jewelContainer; //Field offset: 0x68
	private ExplictNavGrid explictNavGrid; //Field offset: 0x70
	private bool isPopup; //Field offset: 0x78
	private GameObject selectedGameObject; //Field offset: 0x80
	private float updateCountdown; //Field offset: 0x88
	private bool transitioning; //Field offset: 0x8C
	private bool queueSelectFirstGameObject; //Field offset: 0x8D

	public event Action<BaseJewelBarControl> ControlAdded
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<BaseJewelBarControl> ControlRemoved
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	private static GamepadContext() { }

	public GamepadContext() { }

	[CompilerGenerated]
	public void add_ControlAdded(Action<BaseJewelBarControl> value) { }

	[CompilerGenerated]
	public void add_ControlRemoved(Action<BaseJewelBarControl> value) { }

	private void AutoSelectFirstGameObject() { }

	private void Awake() { }

	public void BackButtonClicked() { }

	private void Instance_OnTransitioningChanged(bool transitioning) { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void ProcessSelectFirstGameObject() { }

	private void RecordSelection() { }

	public void Register(Jewel btn) { }

	public void Register(BaseJewelBarControl btn) { }

	[CompilerGenerated]
	public void remove_ControlAdded(Action<BaseJewelBarControl> value) { }

	[CompilerGenerated]
	public void remove_ControlRemoved(Action<BaseJewelBarControl> value) { }

	public bool SelectFirstEnabled() { }

	public override void SelectFirstGameObject() { }

	public ExplictNavGrid SetNavGrid(NavCell cell) { }

	public ExplictNavGrid SetNavGrid(NavCell[2] grid) { }

	public static void SubscribeToSelectFirstGameObject(Component gameObject, Action getFirstGameObjectCallback) { }

	public static void SubscribeToSelectFirstGameObject(Component gameObject, Func<GameObject> getFirstGameObjectCallback) { }

	public static bool TryRestorePrevSelection(GameObject gameObject) { }

	public void Unregister(BaseJewelBarControl btn) { }

	public void Unregister(Jewel btn) { }

	private void UpdateCommonPanel() { }

}

