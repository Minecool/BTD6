//Type is in global namespace

public class ClockTimeAnimator : MonoBehaviour
{
	public GameObject hourHand; //Field offset: 0x20
	public GameObject minuteHand; //Field offset: 0x28
	public GameObject secondHand; //Field offset: 0x30
	public float timeLastUpdated; //Field offset: 0x38
	public float updateInterval; //Field offset: 0x3C

	public ClockTimeAnimator() { }

	private void Start() { }

	private void Update() { }

}

