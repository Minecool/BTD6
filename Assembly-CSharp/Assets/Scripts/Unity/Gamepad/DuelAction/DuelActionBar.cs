namespace Assets.Scripts.Unity.Gamepad.DuelAction;

public class DuelActionBar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public Toggle toggle; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal void <ToggleToButton>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public Toggle toggle; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <ToggleToButton>b__0() { }

	}

	public static DuelActionBar instance; //Field offset: 0x0
	public FixedActionButton fixedY; //Field offset: 0x20
	public FixedActionButton fixedA; //Field offset: 0x28
	public FixedActionButton fixedB; //Field offset: 0x30
	public FixedActionButton fixedX; //Field offset: 0x38
	public FixedActionButton fixedLeftShoulder; //Field offset: 0x40
	public FixedActionButton fixedRightShoulder; //Field offset: 0x48
	public FixedActionButton fixedLeftTrigger; //Field offset: 0x50
	public FixedActionButton fixedRightTrigger; //Field offset: 0x58
	private FixedActionButton[] fixedButtons; //Field offset: 0x60
	public Sprite moneyIcon; //Field offset: 0x68
	public Sprite knowledgeIcon; //Field offset: 0x70
	public Sprite purchaseXP; //Field offset: 0x78
	public Sprite unklockTower; //Field offset: 0x80
	public TMP_Text infoPrefab; //Field offset: 0x88
	public ActionButton actionButtonPrefab; //Field offset: 0x90
	private bool _backButtonActive; //Field offset: 0x98

	public bool backButtonActive
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public DuelActionBar() { }

	public static Button AddFakeBGBlocker(GameObject src) { }

	private void Awake() { }

	public static ActionButton BindRampClicks(Button btn, bool canNav = false, GamepadInputType inputType = 1) { }

	public static Button CreateFakeButton(Transform owner, string name, UnityAction onClick, AnchorPresets align, Vector2 anchoredPosition) { }

	public static void DisableRaycasts(GameObject obj) { }

	public bool get_backButtonActive() { }

	public FixedActionButton GetFixed(GamepadInputType type) { }

	public Sprite GetSprite(GamepadInputType inputType) { }

	public static void HideAll() { }

	public static void HideButtonGrahics(GameObject obj) { }

	public static void HideFixed(GamepadInputType inputType) { }

	public static void HideFixedShoulders() { }

	public static void HideGraphics(GameObject obj) { }

	public void set_backButtonActive(bool value) { }

	public static void SetActive(GamepadInputType inputType, bool active) { }

	public static FixedActionButton SetFixedCaption(GamepadInputType inputType, string caption) { }

	public static ActionButton Show(Button btn, bool canNav = false, GamepadInputType inputType = 1) { }

	private static ActionButton ShowCommon(Button btn, GamepadInputType inputType) { }

	public static FixedActionButton ShowFixed(Button btn, GamepadInputType inputType, string caption, Sprite icon = null, bool autoHideGraphics = true) { }

	private static FixedActionButton ShowFixedCommon(Button btn, GamepadInputType inputType, string caption, Sprite icon = null) { }

	public static FixedActionButton ShowFixedHold(Button btn, GamepadInputType inputType, string caption, Sprite icon = null) { }

	public static void ShowFixedShoulders(Button left, Button right, string caption, Sprite iconSprite = null) { }

	public static void ShowFixedTriggers(Button left, Button right, string caption, Sprite iconSprite = null) { }

	public static ActionButton ShowHold(Button btn, bool canNav = false, GamepadInputType inputType = 1) { }

	public static Button ToggleToButton(Toggle toggle, Image targetImage) { }

	public static Button ToggleToButton(Toggle toggle) { }

	private void Update() { }

}

