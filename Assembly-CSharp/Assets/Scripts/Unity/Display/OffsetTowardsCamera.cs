namespace Assets.Scripts.Unity.Display;

public class OffsetTowardsCamera : MonoBehaviour
{
	private static Quaternion cameraFace; //Field offset: 0x0
	public float offset; //Field offset: 0x20
	private Vector3 offsetRotation; //Field offset: 0x24

	private static OffsetTowardsCamera() { }

	public OffsetTowardsCamera() { }

	public void LateUpdate() { }

	public void Start() { }

}

