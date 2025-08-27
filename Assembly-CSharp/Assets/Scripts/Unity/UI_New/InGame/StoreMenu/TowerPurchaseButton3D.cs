namespace Assets.Scripts.Unity.UI_New.InGame.StoreMenu;

public class TowerPurchaseButton3D : TowerPurchaseButton
{
	private static readonly int saturationProp; //Field offset: 0x0
	[SerializeField]
	private GameObject monkeyTeamsTopImg; //Field offset: 0xE0
	[SerializeField]
	private PrefabReference primaryBase; //Field offset: 0xE8
	[SerializeField]
	private PrefabReference militaryBase; //Field offset: 0xF0
	[SerializeField]
	private PrefabReference magicBase; //Field offset: 0xF8
	[SerializeField]
	private PrefabReference supportBase; //Field offset: 0x100
	[SerializeField]
	private PrefabReference heroBase; //Field offset: 0x108
	[SerializeField]
	private PrefabReference monkeyteamsBase; //Field offset: 0x110
	[SerializeField]
	private Transform baseContainer; //Field offset: 0x118
	[SerializeField]
	private Transform iconContainer; //Field offset: 0x120
	private GameObject iconObj; //Field offset: 0x128
	private GameObject baseObj; //Field offset: 0x130
	private Scrollable3DElement scrollable; //Field offset: 0x138
	private bool isGrayscale; //Field offset: 0x140

	private bool IsGrayscale
	{
		private get { } //Length: 8
		private set { } //Length: 112
	}

	private static TowerPurchaseButton3D() { }

	public TowerPurchaseButton3D() { }

	[CompilerGenerated]
	private void <Bind>b__16_0(AsyncOperationHandle<GameObject> h) { }

	[CompilerGenerated]
	private void <UpdateDisplay>b__19_0(AsyncOperationHandle<GameObject> h) { }

	[CompilerGenerated]
	private void <UpdateDisplay>b__19_1(AsyncOperationHandle<GameObject> h) { }

	public virtual void Awake() { }

	public void Bind(RatioObject menu, Model model, PrefabReference icon, bool showCount, int buttonIndex) { }

	public virtual void ButtonDeactivated() { }

	private PrefabReference DetermineBaseObject() { }

	private bool get_IsGrayscale() { }

	protected virtual void OnItemClickedEvent() { }

	private void set_IsGrayscale(bool value) { }

	protected virtual void SetAvailable() { }

	protected virtual void SetCountIconGrayscale(bool grayScale) { }

	public virtual void SetLocked() { }

	protected virtual void SetNotEnoughCash() { }

	private void SetSaturationForAllRenderers(GameObject obj, float saturation) { }

	protected virtual void SetUnavailable() { }

	public virtual void SetUnlocked() { }

	public virtual void StartDragging() { }

	public virtual void StopDragging() { }

	protected virtual void Update() { }

	public virtual void UpdateDisplay(bool canPlayMonkeyTeamBrokenAnim = false) { }

}

