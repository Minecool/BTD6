namespace Assets.Scripts.Unity.Map.Effects;

public class InteractableClick : MonoBehaviour
{
	public OnClickHandler onClickHandler; //Field offset: 0x20
	public Action onClick; //Field offset: 0x28

	public InteractableClick() { }

	private void OnClick(GameObject gameObject) { }

	private void Start() { }

}

