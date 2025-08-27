namespace Assets.Scripts.Simulation.Behaviors;

public class GlobalRangeMesh : MeshBehavior
{
	private struct BlockerEdge
	{
		public float2 s; //Field offset: 0x0
		public float2 e; //Field offset: 0x8

	}

	[BurstCompile(FloatPrecision::Low (3), FloatMode::Fast (3))]
	private struct CalculateVisibilityPolygonPointsJob : IJob
	{
		private struct PexComparer : IComparer<Pex>
		{

			public override int Compare(Pex a, Pex b) { }

		}

		private NativeList<BlockerEdge> edges; //Field offset: 0x0
		private NativeList<float2> polyPoints; //Field offset: 0x8
		private NativeList<Pex> polyPointsToExterior; //Field offset: 0x10
		private readonly float ox; //Field offset: 0x18
		private readonly float oy; //Field offset: 0x1C
		private readonly float radius; //Field offset: 0x20

		public CalculateVisibilityPolygonPointsJob(NativeList<BlockerEdge> edges, NativeList<float2> polyPoints, NativeList<Pex> polyPointsToExterior, float ox, float oy, float radius) { }

		public override void Execute() { }

	}

	private struct Pex
	{
		public float angle; //Field offset: 0x0
		public float2 p; //Field offset: 0x4
		public float2 extP; //Field offset: 0xC

	}

	private static List<Mesh> meshPool; //Field offset: 0x0
	private static NativeList<BlockerEdge> _edges; //Field offset: 0x8
	private static NativeList<float2> _polyPoints; //Field offset: 0x10
	private static NativeList<Pex> _polyPointsToExterior; //Field offset: 0x18

	private static GlobalRangeMesh() { }

	public GlobalRangeMesh() { }

	public static Mesh CalculateVisibilityPolygon(Simulation sim, Vector3 position, float radius) { }

	private static void GetBlockerEdges(Map map, float height, NativeList<BlockerEdge> edges) { }

	private static void MeshReleased(Mesh mesh) { }

}

