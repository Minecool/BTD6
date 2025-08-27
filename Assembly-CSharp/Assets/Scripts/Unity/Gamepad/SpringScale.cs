namespace Assets.Scripts.Unity.Gamepad;

[AddComponentMenu("UI/Effects/SpringScale", 14)]
public class SpringScale : MonoBehaviour
{
	public float targetScale; //Field offset: 0x20
	public Transform target; //Field offset: 0x28
	private Spring scaleSpring; //Field offset: 0x30

	public SpringScale() { }

	private void LateUpdate() { }

	private void Start() { }

}

