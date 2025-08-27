namespace Assets.Scripts.Unity.UI_New.Utils;

[RequireComponent(typeof(Camera))]
public class RegisterCameraWithStereoscope : MonoBehaviour
{
	[SerializeField]
	private bool trackTransformChanges; //Field offset: 0x20

	public RegisterCameraWithStereoscope() { }

	private void OnEnable() { }

}

