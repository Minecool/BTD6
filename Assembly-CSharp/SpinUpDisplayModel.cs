//Type is in global namespace

public class SpinUpDisplayModel : MonoBehaviour
{
	public Vector3 axisStartingSpeeds; //Field offset: 0x20
	public Vector3 axisMinSpeeds; //Field offset: 0x2C
	public Vector3 axisMaxSpeeds; //Field offset: 0x38
	public Vector3 axisAccelerations; //Field offset: 0x44
	private Vector3 axisSpeeds; //Field offset: 0x50
	private Vector3 axisPositions; //Field offset: 0x5C
	private bool spinningUp; //Field offset: 0x68
	public bool autoSpinDown; //Field offset: 0x69
	public float autoSpinDownTime; //Field offset: 0x6C
	private float autoSpinDownTimer; //Field offset: 0x70

	public SpinUpDisplayModel() { }

	private void CheckSpeedBounds() { }

	public void SpinDown() { }

	public void SpinUp() { }

	private void Start() { }

	private void Update() { }

}

