//Type is in global namespace

public static class Poly2Mesh
{
	internal class Polygon
	{
		public List<Vector3> outside; //Field offset: 0x10
		public List<List`1<Vector3>> holes; //Field offset: 0x18
		public List<Vector2> outsideUVs; //Field offset: 0x20
		public List<List`1<Vector2>> holesUVs; //Field offset: 0x28
		public Vector3 planeNormal; //Field offset: 0x30
		public Quaternion rotation; //Field offset: 0x3C

		public Polygon() { }

		public void CalcPlaneNormal() { }

		public void CalcPlaneNormal(Vector3 hint) { }

		public void CalcRotation() { }

		public Vector2 ClosestUV(Vector3 pos) { }

	}

	public static bool fullDebug; //Field offset: 0x0

	private static List<PolygonPoint> ConvertPoints(List<Vector3> points, Quaternion rotation, Dictionary<UInt32, Vector3> codeToPosition) { }

	public static GameObject CreateGameObject(Polygon polygon, string name = "Polygon") { }

	public static Mesh CreateMesh(Polygon polygon) { }

	public static Mesh CreateTriangle(Polygon polygon) { }

}

