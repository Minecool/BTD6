namespace Assets.Scripts.Simulation.Behaviors;

public class RangeMesh
{
	private static List<Mesh> meshPool; //Field offset: 0x0
	private static readonly List<BlockerWall> walls; //Field offset: 0x8
	private static Vector3 sortwallsPosition; //Field offset: 0x10

	private static RangeMesh() { }

	public RangeMesh() { }

	private static void AddPoints(Mesh mesh, ref int triangleIndex, int indexStart, Vector3 a, Vector3 b, Vector3 c, Vector3 d, bool valid) { }

	private static int CheckLine(Mesh mesh, ref int triangleIndex, float rotation, float range, Vector3 position, List<BlockerWall> openWalls, bool ignoreBlockers, int indexStart) { }

	public static Mesh GetMeshStatically(Simulation sim, Vector3 position, float range, bool ignoreBlockers = false) { }

	private static void MeshReleased(Mesh mesh) { }

	private static int sortwalls(BlockerWall a, BlockerWall b) { }

}

