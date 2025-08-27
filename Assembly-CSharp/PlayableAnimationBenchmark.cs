//Type is in global namespace

public class PlayableAnimationBenchmark : MonoBehaviour
{
	public GameObject duplicateTarget; //Field offset: 0x20
	public Text itemCountField; //Field offset: 0x28
	private int initialStress; //Field offset: 0x30
	private int perAdd; //Field offset: 0x34
	private int totalStress; //Field offset: 0x38
	private int monkeysPerRow; //Field offset: 0x3C
	private int spacing; //Field offset: 0x40

	public PlayableAnimationBenchmark() { }

	public void AddMoreStress() { }

	private void AddStress(int stress) { }

	private void Awake() { }

	private void Start() { }

}

