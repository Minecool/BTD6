namespace Assets.Scripts.Unity.UI_New.Main.PowersSelect;

public class PowerSelectButton : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public PowerSelectButton <>4__this; //Field offset: 0x10
		public PowersSelectScreen powersSelectScreen; //Field offset: 0x18
		public PowerModel powerModel; //Field offset: 0x20

		public <>c__DisplayClass24_0() { }

		internal void <SetPower>b__0(AsyncOperationHandle<GameObject> handle) { }

	}

	internal sealed class SelectHander : MulticastDelegate
	{

		public SelectHander(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PowerSelectButton powerButton, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PowerSelectButton powerButton) { }

	}

	[CompilerGenerated]
	private SelectHander OnSelect; //Field offset: 0x20
	[HideInInspector]
	public PowerModel powerModel; //Field offset: 0x28
	public Image icon; //Field offset: 0x30
	public GameObject powerCountIcon; //Field offset: 0x38
	public NK_TextMeshProUGUI powerCountText; //Field offset: 0x40
	public NK_TextMeshProUGUI powerNameText; //Field offset: 0x48
	public Image selectedImage; //Field offset: 0x50
	public RuntimeAnimatorController hasInventoryAC; //Field offset: 0x58
	public RuntimeAnimatorController noInventoryAC; //Field offset: 0x60
	public Toggle toggle; //Field offset: 0x68
	public Animator animator; //Field offset: 0x70
	public GameObject newNotify; //Field offset: 0x78
	public GameObject defaultBackground; //Field offset: 0x80
	public GameObject iapBackground; //Field offset: 0x88
	public GameObject animatedIcon; //Field offset: 0x90
	public GameObject newRibbon; //Field offset: 0x98
	[Header("Icon background")]
	public GameObject bgPower; //Field offset: 0xA0
	public GameObject bgPowerPro; //Field offset: 0xA8
	public GameObject bgIAP; //Field offset: 0xB0
	private int loadIconFrame; //Field offset: 0xB8

	public event SelectHander OnSelect
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public PowerSelectButton() { }

	[CompilerGenerated]
	private void <Init>b__22_0(bool selected) { }

	[CompilerGenerated]
	public void add_OnSelect(SelectHander value) { }

	public void Init() { }

	[CompilerGenerated]
	public void remove_OnSelect(SelectHander value) { }

	public void SetPower(PowersSelectScreen powersSelectScreen, PowerModel powerModel, int loadIconFrame, Transform animatedIconParent) { }

	private void SetSelected(bool selected) { }

	public void ToggleChanged(bool isOn) { }

	private void Update() { }

	public void UpdateIcon() { }

	public void UpdatePowerDisplay(bool afterPurchase = false) { }

}

