namespace Assets.Scripts.Unity.Display.Animation;

public class EyesBlink : MonoBehaviour
{
	private const int blinkFrequencyFramesMin = 300; //Field offset: 0x0
	private const int blinkFrequencyFramesMax = 700; //Field offset: 0x0
	private const int framesPerBlink = 6; //Field offset: 0x0
	public MeshRenderer eyeMeshRenderer; //Field offset: 0x20
	private int framesPassed; //Field offset: 0x28
	private int nextBlinkFrame; //Field offset: 0x2C

	public EyesBlink() { }

	private void Awake() { }

	private void Blink() { }

	private void EndBlink() { }

	private void Update() { }

}

