namespace GestureSystem;

[RequireComponent(typeof(CustomButton))]
public class HoverClick : MonoBehaviour, IHoverClick
{
	[SerializeField]
	private float hoverTriggerTime; //Field offset: 0x20
	private float hoverTriggerTimeLeft; //Field offset: 0x24
	private CustomButton button; //Field offset: 0x28

	public override float NormalizedProgress
	{
		 get { } //Length: 23
	}

	public HoverClick() { }

	private void Awake() { }

	private void CancelHoverClick() { }

	public override float get_NormalizedProgress() { }

	private void StartHoverClick() { }

	public void Update() { }

}

