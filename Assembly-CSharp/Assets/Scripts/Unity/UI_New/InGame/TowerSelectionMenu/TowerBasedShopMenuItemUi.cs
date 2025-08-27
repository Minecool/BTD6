namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class TowerBasedShopMenuItemUi : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler, IPointerClickHandler
{
	public Image shopItemIcon; //Field offset: 0x20
	public Image dragItemIcon; //Field offset: 0x28
	public GameObject selected; //Field offset: 0x30
	public Animator animator; //Field offset: 0x38

	protected UnityToSimulation Bridge
	{
		 get { } //Length: 7
	}

	public TowerBasedShopMenuItemUi() { }

	protected UnityToSimulation get_Bridge() { }

	public override void Highlight() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnPrime() { }

	public override void StartDragging() { }

	public override void StopDragging() { }

	public override void StopHighlight() { }

}

