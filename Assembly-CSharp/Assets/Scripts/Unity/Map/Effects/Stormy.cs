namespace Assets.Scripts.Unity.Map.Effects;

public class Stormy : MonoBehaviour
{
	internal struct ObjectTime
	{
		public GameObject obj; //Field offset: 0x0
		public float livinTimer; //Field offset: 0x8
		public int objId; //Field offset: 0xC

	}

	public GameObject[] objectsToCreate; //Field offset: 0x20
	public float minTime; //Field offset: 0x28
	public float maxTime; //Field offset: 0x2C
	public float objectDuration; //Field offset: 0x30
	public Vector2 minMaxX; //Field offset: 0x34
	public Vector2 minMaxZ; //Field offset: 0x3C
	private float timer; //Field offset: 0x44
	private float nextCreationTime; //Field offset: 0x48
	private Dictionary<Int32, List`1<GameObject>> objPool; //Field offset: 0x50
	private List<ObjectTime> livinObjects; //Field offset: 0x58

	public Stormy() { }

	public void OnEnable() { }

	public void Update() { }

}

