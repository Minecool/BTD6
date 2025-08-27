namespace Assets.Scripts.Unity.Display;

public class EffectAreaLimiter
{
	private struct EffectCounter
	{
		public int count; //Field offset: 0x0
		public float lastCreated; //Field offset: 0x4

	}

	private const float limitTime = 0.33333334; //Field offset: 0x0
	private const float bucketSizeInv = 0.2; //Field offset: 0x0
	private static readonly int bucketsW; //Field offset: 0x0
	private Dictionary<PrefabReference, Dictionary`2<Int32, EffectCounter>> grid; //Field offset: 0x10

	private float Now
	{
		private get { } //Length: 7
	}

	private static EffectAreaLimiter() { }

	public EffectAreaLimiter() { }

	public void AddPosition(PrefabReference assetId, Vector3 pos) { }

	private static int ConvertPosToInt(Vector3 pos) { }

	private float get_Now() { }

	public bool IsPositionValid(PrefabReference assetId, Vector3 pos) { }

	public void RemovePosition(PrefabReference assetId, Vector3 pos) { }

}

