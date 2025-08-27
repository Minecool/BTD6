namespace Assets.Scripts.Models.MapEditorBehaviors;

public static class SplineUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public int index; //Field offset: 0x10
		public Func<ValueTuple`2<Int32, Vector3>, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal bool <GetPointInfo>b__0(ValueTuple<Int32, Vector3> p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public ValueTuple<Int32, Vector3> currentPoint; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <FindIndexWithinSegment>b__0(ValueTuple<Int32, Vector3> point) { }

	}


	public static List<ValueTuple`2<Int32, Vector3>> CalculateEvenlySpacedPoints(IReadOnlyList<ISplineNode> splineNodes, bool isOpenEnded, float resolution, float spacing) { }

	public static float EstimatePathLength(IReadOnlyList<ISplineNode> splineNodes) { }

	private static Vector3 EvaluateCubic(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t) { }

	private static Vector3 EvaluateQuadratic(Vector3 a, Vector3 b, Vector3 c, float t) { }

	public static int FindIndexWithinSegment(List<ValueTuple`2<Int32, Vector3>> points, ValueTuple<Int32, Vector3> currentPoint) { }

	private static void GatherPointsAlongSpline(List<ValueTuple`2<Int32, Vector3>> points, Vector3[] splineSegment, int i, float dstSinceLastEvenPoint, float resolution, float spacing, ref Vector3 prevPos) { }

	private static PointInfo GetInterpolatedPointInfo(PointInfo pointInfo, List<ValueTuple`2<Int32, Vector3>> points, ValueTuple<Int32, Vector3> currentPoint, PathNode[] pathNodes = null, Dictionary<Int32, Int32> pointsPerNode = null) { }

	public static PointInfo[] GetPointInfo(List<ValueTuple`2<Int32, Vector3>> points, PathNode[] pathNodes = null) { }

	private static Vector3[] GetSplineSegment(ISplineNode node1, ISplineNode node2) { }

}

