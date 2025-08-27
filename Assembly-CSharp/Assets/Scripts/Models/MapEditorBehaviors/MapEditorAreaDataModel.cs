namespace Assets.Scripts.Models.MapEditorBehaviors;

public class MapEditorAreaDataModel : Model
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PointInfo, Vector2> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector2 <GetAreaModel>b__13_0(PointInfo x) { }

	}

	public const float EVENLY_SPACED_POINT_SPACING = 2; //Field offset: 0x0
	public const float EVENLY_SPACED_POINT_RESOLUTION = 0.5; //Field offset: 0x0
	public AreaData areaData; //Field offset: 0x30
	public PathNode[] nodes; //Field offset: 0x58
	public int layerInWorldIndex; //Field offset: 0x60
	public int categoryLayerId; //Field offset: 0x64

	public string AreaName
	{
		 get { } //Length: 85
	}

	public List<ValueTuple`2<Int32, Vector3>> EvenlySpacedPonts
	{
		 get { } //Length: 45
	}

	public bool IsSightBlockingArea
	{
		 get { } //Length: 17
	}

	public MapEditorAreaDataModel(string name, AreaData areaData, PathNode[] nodes, int layerInWorldIndex, int categoryLayerId) { }

	public virtual Model Clone() { }

	public string get_AreaName() { }

	public List<ValueTuple`2<Int32, Vector3>> get_EvenlySpacedPonts() { }

	public bool get_IsSightBlockingArea() { }

	public AreaModel GetAreaModel() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

