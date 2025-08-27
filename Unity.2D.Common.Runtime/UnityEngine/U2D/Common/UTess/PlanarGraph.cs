namespace UnityEngine.U2D.Common.UTess;

internal struct PlanarGraph
{
	private static readonly double kEpsilon; //Field offset: 0x0
	private static readonly int kMaxIntersectionTolerance; //Field offset: 0x8

	private static PlanarGraph() { }

	internal static bool CalculateEdgeIntersections(Array<int2> edges, int edgeCount, Array<double2> points, int pointCount, ref Array<int2>& results, ref Array<double2>& intersects, ref int resultCount) { }

	internal static bool CalculateTJunctions(Array<int2> edges, int edgeCount, Array<double2> points, int pointCount, Array<int2> results, ref int resultCount) { }

	internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1) { }

	internal static bool CutEdges(ref Array<double2>& points, ref int pointCount, ref Array<int2>& edges, ref int edgeCount, ref Array<int2>& tJunctions, ref int tJunctionCount, Array<int2> intersections, Array<double2> intersects, int intersectionCount) { }

	internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1) { }

	internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result) { }

	internal static void RemoveDuplicateEdges(ref Array<int2>& edges, ref int edgeCount, Array<Int32> duplicates, int duplicateCount) { }

	internal static void RemoveDuplicatePoints(ref Array<double2>& points, ref int pointCount, ref Array<Int32>& duplicates, ref int duplicateCount, Allocator allocator) { }

	internal static bool Validate(Allocator allocator, in NativeArray<float2>& inputPoints, int pointCount, in NativeArray<int2>& inputEdges, int edgeCount, ref NativeArray<float2>& outputPoints, out int outputPointCount, ref NativeArray<int2>& outputEdges, out int outputEdgeCount) { }

}

