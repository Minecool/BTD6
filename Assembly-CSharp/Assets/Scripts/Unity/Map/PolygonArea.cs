namespace Assets.Scripts.Unity.Map;

public class PolygonArea : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Vector3, Vector2> <>9__4_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Vector2 <OnValidate>b__4_0(Vector3 v) { }

	}

	[DefaultMember("Item")]
	internal class PointArray
	{
		public Vector3[] points; //Field offset: 0x10

		public Vector3 Item
		{
			 get { } //Length: 69
			 set { } //Length: 63
		}

		public int Length
		{
			 get { } //Length: 26
		}

		public PointArray(Vector3[] points) { }

		private int FindCornerVertex() { }

		public Vector3 get_Item(int idx) { }

		public int get_Length() { }

		public bool IsCCW() { }

		public void set_Item(int idx, Vector3 value) { }

		private static int WrapAt(int i, int n) { }

	}

	public List<PointArray> polygons; //Field offset: 0x20
	public Color editorColor; //Field offset: 0x28

	public PolygonArea() { }

	[CompilerGenerated]
	private Vector2 <BuildPolygons>b__3_0(Vector3 x) { }

	public Polygon[] BuildPolygons() { }

	private void OnValidate() { }

	private void Reset() { }

}

