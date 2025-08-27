namespace Assets.Scripts.Models.Map;

[Implementation(typeof(Area), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AreaModel : Model
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Polygon, Polygon> <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Polygon <Clone>b__18_0(Polygon p) { }

	}

	public ObjectId id; //Field offset: 0x30
	public Polygon polygon; //Field offset: 0x38
	public Polygon[] holes; //Field offset: 0x40
	public float height; //Field offset: 0x48
	public AreaType type; //Field offset: 0x4C
	public float renderHeightOffset; //Field offset: 0x50
	public String[] filterInTowerSizes; //Field offset: 0x58
	public TowerSet[] filterInTowerSets; //Field offset: 0x60
	public String[] filterOutSpecificTowers; //Field offset: 0x68
	public bool isBlocker; //Field offset: 0x70
	public bool isDisabled; //Field offset: 0x71
	public bool isInputBlocking; //Field offset: 0x72
	public bool ignoreZAxisTowerCollision; //Field offset: 0x73
	public Vector2 pivotPoint; //Field offset: 0x74
	public AreaBuffModel[] buffs; //Field offset: 0x80
	public Circle[] blockerCircles; //Field offset: 0x88
	public int customAreaCategoryLayerId; //Field offset: 0x90

	public AreaModel(string areaName, Polygon polygon, Polygon[] holes, float height, AreaType type, float renderHeightOffset = 0, String[] filterInTowerSizes = null, TowerSet[] filterInTowerSets = null, String[] filterOutSpecificTowers = null, bool isBlocker = false, bool isDisabled = false, bool isInputBlocking = false, Vector2 pivotPoint = null, AreaBuffModel[] buffs = null, Circle[] blockerCircles = null, int customAreaCategoryLayerId = -1) { }

	public virtual Model Clone() { }

	public Vector3 GetCenterPoint() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public bool IsPointInside(Vector2 p) { }

}

