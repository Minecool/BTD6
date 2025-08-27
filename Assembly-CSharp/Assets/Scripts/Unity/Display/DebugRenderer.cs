namespace Assets.Scripts.Unity.Display;

public class DebugRenderer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<DebugCircle> <>9__26_0; //Field offset: 0x8
		public static Predicate<DebugLine> <>9__28_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <RegenerateCircleMeshes>b__26_0(DebugCircle circle) { }

		internal bool <RegenerateLineMeshes>b__28_0(DebugLine line) { }

	}

	private class ColouredMesh
	{
		public Mesh mesh; //Field offset: 0x10
		public Vector3[] verts; //Field offset: 0x18
		public Color[] colors; //Field offset: 0x20
		public Int32[] indices; //Field offset: 0x28

		public ColouredMesh() { }

		public void Clear() { }

		public void RequiresIndices(int requiredIndices) { }

	}

	internal struct DebugCircle
	{
		public Vector3 pos; //Field offset: 0x0
		public float radius; //Field offset: 0xC
		public Color color; //Field offset: 0x10
		public float time; //Field offset: 0x20
		public float alphaStep; //Field offset: 0x24

		public DebugCircle(Vector3 _pos, float _radius, Color _color, float _time) { }

	}

	internal struct DebugLine
	{
		public Vector3 start; //Field offset: 0x0
		public Vector3 end; //Field offset: 0xC
		public float width; //Field offset: 0x18
		public Color color; //Field offset: 0x1C
		public float time; //Field offset: 0x2C
		public float alphaStep; //Field offset: 0x30

		public DebugLine(Vector3 _start, Vector3 _end, float _width, Color _color, float _time) { }

	}

	private const int nMaxMeshVerts = 2000; //Field offset: 0x0
	private const int nLinesMeshVerts = 4; //Field offset: 0x0
	private const int nLinesMeshIndices = 6; //Field offset: 0x0
	private const int nCircleSubDivs = 16; //Field offset: 0x0
	private const int nCircleMeshVerts = 17; //Field offset: 0x0
	private static DebugRenderer m_Instance; //Field offset: 0x0
	private List<ColouredMesh> m_Meshes; //Field offset: 0x20
	private List<DebugLine> m_Lines; //Field offset: 0x28
	private List<DebugCircle> m_Circles; //Field offset: 0x30
	private int m_Reserved; //Field offset: 0x38
	private Material m_DebugMaterial; //Field offset: 0x40

	public DebugRenderer() { }

	public static bool DoesExist() { }

	public static void DrawCircle(Vector3 pos, float radius, Color color, float time = 0) { }

	public static void DrawCircle(Vector3 pos, float radius, Color color, float time = 0) { }

	public void DrawCircleInternal(Vector3 pos, float radius, Color color, float time) { }

	public static void DrawLine(Vector3 start, Vector3 end, float width, Color color, float time = 0) { }

	public static void DrawLine(Vector3 start, Vector3 end, float width, Color color, float time = 0) { }

	public void DrawLineIntenral(Vector3 start, Vector3 end, float width, Color color, float time) { }

	private void GenerateCircleMeshRange(ColouredMesh mesh, int nBaseObj, int count) { }

	private void GenerateLineMeshRange(ColouredMesh mesh, int nBaseObj, int count) { }

	public static DebugRenderer Instance() { }

	public static bool IsEnabled() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void RegenerateCircleMeshes() { }

	private void RegenerateLineMeshes() { }

	private void RegenerateMeshes() { }

	private int ReserveMeshes(int objs, int objVertCount) { }

	private void Start() { }

}

