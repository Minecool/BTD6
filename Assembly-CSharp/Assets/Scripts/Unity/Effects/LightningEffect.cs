namespace Assets.Scripts.Unity.Effects;

public class LightningEffect : MonoBehaviour
{
	public LineRenderer lineRenderer; //Field offset: 0x20
	public Transform startPos; //Field offset: 0x28
	public Transform endPos; //Field offset: 0x30
	public int pointsInLine; //Field offset: 0x38
	public float arcResetTime; //Field offset: 0x3C
	public float arcResetTimeRandom; //Field offset: 0x40
	public float arcStrengh; //Field offset: 0x44
	public float sinWaveLength; //Field offset: 0x48
	public float sinWaveStrength; //Field offset: 0x4C
	public float sinSwitchTime; //Field offset: 0x50
	public float sinSwitchTimeRandom; //Field offset: 0x54
	public float randomnessStrength; //Field offset: 0x58
	[Range(0.01, 0.5)]
	public float edgeDampningPerc; //Field offset: 0x5C
	private Vector3[] linePoss; //Field offset: 0x60
	private Vector2[] randomness; //Field offset: 0x68
	private float arcTimer; //Field offset: 0x70
	private float sinOffset; //Field offset: 0x74
	private float sinOffsetTimer; //Field offset: 0x78

	public LightningEffect() { }

	public static Vector2 BezierCurve(Vector2 p0, Vector2 p1, Vector2 p2, float t) { }

	private void Start() { }

	private void Update() { }

}

