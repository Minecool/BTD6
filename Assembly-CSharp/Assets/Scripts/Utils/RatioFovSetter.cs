namespace Assets.Scripts.Utils;

public class RatioFovSetter : MonoBehaviour
{
	[SerializeField]
	private float ratio4_3; //Field offset: 0x20
	[SerializeField]
	private float ratio16_9; //Field offset: 0x24

	public RatioFovSetter() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnScreenSizeChanged(int w, int h) { }

	private void UpdateCamFOV() { }

}

