namespace Assets.Scripts.Unity.Map;

public class Area : PolygonArea
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Polygon, Boolean> <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <get_Def>b__13_0(Polygon p) { }

	}

	public AreaType type; //Field offset: 0x38
	public float renderHeightOffset; //Field offset: 0x3C
	public string filterInTowerSizes; //Field offset: 0x40
	public string filterInTowerSets; //Field offset: 0x48
	public string filterOutSpecificTowers; //Field offset: 0x50
	public bool isBlocker; //Field offset: 0x58
	public bool isDisabled; //Field offset: 0x59
	public bool isInputBlocking; //Field offset: 0x5A
	public Transform pivotPoint; //Field offset: 0x60
	public AreaBuff[] buffs; //Field offset: 0x68
	[HideInInspector]
	public Circle[] blockerCircles; //Field offset: 0x70
	private AreaModel def; //Field offset: 0x78

	public AreaModel Def
	{
		 get { } //Length: 1475
	}

	public Area() { }

	public AreaModel get_Def() { }

}

