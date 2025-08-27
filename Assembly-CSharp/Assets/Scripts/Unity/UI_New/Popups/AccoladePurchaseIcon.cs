namespace Assets.Scripts.Unity.UI_New.Popups;

public class AccoladePurchaseIcon : MonoBehaviour
{
	public Animator anim; //Field offset: 0x20
	public AccoladeType accoladeType; //Field offset: 0x28
	public GameObject selectedObj; //Field offset: 0x30
	public Button button; //Field offset: 0x38
	private AccoladesStorePopup accoladesStorePopup; //Field offset: 0x40

	public AccoladePurchaseIcon() { }

	public void Deselect() { }

	public void Initialize(AccoladesStorePopup accoladesStorePopup) { }

	public void OnClicked() { }

	public void Select() { }

}

