namespace Assets.Scripts.Unity.UI_New.Utils;

[RequireComponent(typeof(Camera))]
public class StereoscopeOverrides : MonoBehaviour
{
	public bool overridePupillaryDistance; //Field offset: 0x20
	public float pupillaryDistance; //Field offset: 0x24
	public bool overrideFieldOfView; //Field offset: 0x28
	public float fieldOfView; //Field offset: 0x2C
	public bool overridePosition; //Field offset: 0x30
	public Vector3 position; //Field offset: 0x34
	public bool overrideLookAt; //Field offset: 0x40
	public Transform lookAt; //Field offset: 0x48

	public StereoscopeOverrides() { }

}

