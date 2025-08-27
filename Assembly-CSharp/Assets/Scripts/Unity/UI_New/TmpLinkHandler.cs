namespace Assets.Scripts.Unity.UI_New;

[RequireComponent(typeof(TMP_Text))]
public class TmpLinkHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private TMP_Text text; //Field offset: 0x20
	private Canvas canvas; //Field offset: 0x28

	public TmpLinkHandler() { }

	private void Awake() { }

	public override void OnPointerClick(PointerEventData eventData) { }

}

