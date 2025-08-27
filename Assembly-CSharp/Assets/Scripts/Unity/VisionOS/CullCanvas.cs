namespace Assets.Scripts.Unity.VisionOS;

[RequireComponent(typeof(Canvas))]
public class CullCanvas : MonoBehaviour
{
	[SerializeField]
	private GameObject targetObj; //Field offset: 0x20
	private Canvas canvas; //Field offset: 0x28
	private int hidden; //Field offset: 0x30
	private int hiddenForReview; //Field offset: 0x34

	private int Hidden
	{
		private get { } //Length: 4
		private set { } //Length: 51
	}

	public CullCanvas() { }

	private void Awake() { }

	private int get_Hidden() { }

	private bool HideForCanvas(Canvas otherCanvas) { }

	private bool IsCanvasLoadingUI(Canvas otherCanvas) { }

	private bool IsCanvasReviewMap(Canvas otherCanvas) { }

	private void OnCanvasEnabled(Canvas otherCanvas, bool isEnabled) { }

	private void set_Hidden(int value) { }

}

