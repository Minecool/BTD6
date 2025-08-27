//Type is in global namespace

public class CustomRotationSimple : MonoBehaviour
{
	public GameObject target; //Field offset: 0x20
	public Vector3 rotationAxis; //Field offset: 0x28
	public bool useLocalCoordinates; //Field offset: 0x34
	public float speed; //Field offset: 0x38
	public float minStartingOffset; //Field offset: 0x3C
	public float maxStartingOffset; //Field offset: 0x40
	private float angle; //Field offset: 0x44
	private float startingAngle; //Field offset: 0x48
	public bool isEnabled; //Field offset: 0x4C

	public CustomRotationSimple() { }

	private void Start() { }

	private void Update() { }

}

