namespace Assets.Scripts.Unity.Utils;

public class CanvasTextFps : MonoBehaviour
{
	private const int DeltaListSize = 100; //Field offset: 0x0
	public Text targetTextField; //Field offset: 0x20
	private float updateFrequency; //Field offset: 0x28
	private float timeSinceLastUpdate; //Field offset: 0x2C
	private int deltaIndex; //Field offset: 0x30
	private Single[] deltas; //Field offset: 0x38

	public CanvasTextFps() { }

	private float CalculateAverageDelta() { }

	private void Update() { }

}

