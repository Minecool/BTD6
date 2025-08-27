namespace Assets.Scripts.Unity.UI_New.InGame.RightMenu.Powers;

public class PowerButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler, IPointerClickHandler
{
	protected PowerModel powerModel; //Field offset: 0x20
	private float selectionTimer; //Field offset: 0x28
	private float selectionTimerMax; //Field offset: 0x2C
	private bool isInsta; //Field offset: 0x30
	private bool doubleClick; //Field offset: 0x31
	private float doubleClickTimer; //Field offset: 0x34

	public PowerButton() { }

	public void ButtonActivated() { }

	private void CheckPointer() { }

	public override void CheckUpgrades() { }

	protected override void DoubleClickedPowerButton() { }

	public override Image GetIcon() { }

	public PowerModel GetPower() { }

	protected override PowersMenu GetPowersMenu() { }

	public override void Highlight() { }

	public override bool IsAvailable() { }

	protected override bool ModeDisabled() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected override void PowerButtonDown() { }

	protected override bool RoundDisabled() { }

	public override void SetPower(PowerModel powerModel, bool isInsta) { }

	public override void StartDragging() { }

	public override void StopDragging() { }

	public override void StopHighlight() { }

	private void Update() { }

	public override void UpdateIcon() { }

	public override void UpdatePowerDisplay() { }

}

