namespace UnityEngine.U2D;

[BurstCompile]
internal struct SpriteShapeGenerator : IJob
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, UInt16> <>9__147_0; //Field offset: 0x8
		public static Func<ContourVertex, Vector2> <>9__147_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal ushort <TessellateContourMainThread>b__147_0(int i) { }

		internal Vector2 <TessellateContourMainThread>b__147_1(ContourVertex v) { }

	}

	private struct JobAngleRange
	{
		public float4 spriteAngles; //Field offset: 0x0
		public int4 spriteData; //Field offset: 0x10

	}

	private struct JobContourPoint
	{
		public float2 position; //Field offset: 0x0
		public float2 ptData; //Field offset: 0x8

	}

	private struct JobControlPoint
	{
		public int4 cpData; //Field offset: 0x0
		public int4 exData; //Field offset: 0x10
		public float2 cpInfo; //Field offset: 0x20
		public float2 position; //Field offset: 0x28
		public float2 tangentLt; //Field offset: 0x30
		public float2 tangentRt; //Field offset: 0x38

	}

	private struct JobCornerInfo
	{
		public float2 bottom; //Field offset: 0x0
		public float2 top; //Field offset: 0x8
		public float2 left; //Field offset: 0x10
		public float2 right; //Field offset: 0x18
		public int2 cornerData; //Field offset: 0x20

	}

	private struct JobIntersectPoint
	{
		public float2 top; //Field offset: 0x0
		public float2 bottom; //Field offset: 0x8

	}

	private struct JobParameters
	{
		public int4 shapeData; //Field offset: 0x0
		public int4 splineData; //Field offset: 0x10
		public float4 curveData; //Field offset: 0x20
		public float4 fillData; //Field offset: 0x30

	}

	private struct JobSegmentInfo
	{
		public int4 sgInfo; //Field offset: 0x0
		public float4 spriteInfo; //Field offset: 0x10

	}

	private struct JobShapeVertex
	{
		public float2 pos; //Field offset: 0x0
		public float2 uv; //Field offset: 0x8
		public float4 tan; //Field offset: 0x10
		public float2 meta; //Field offset: 0x20
		public int4 sprite; //Field offset: 0x28

	}

	private struct JobSpriteInfo
	{
		public float4 texRect; //Field offset: 0x0
		public float4 texData; //Field offset: 0x10
		public float4 uvInfo; //Field offset: 0x20
		public float4 metaInfo; //Field offset: 0x30
		public float4 border; //Field offset: 0x40

	}

	public static class UTessellator_0000016D$BurstDirectCall
	{
		private static IntPtr Pointer; //Field offset: 0x0
		private static IntPtr DeferredCompilation; //Field offset: 0x8

		private static UTessellator_0000016D$BurstDirectCall() { }

		public static void Constructor() { }

		private static IntPtr GetFunctionPointer() { }

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr unnamed_param_0) { }

		public static void Initialize() { }

		public static void Invoke(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, UInt16* indices, ref int iCount, Byte* vertices, int stride, ref int vCount, Allocator label) { }

	}

	internal sealed class UTessellator_0000016D$PostfixBurstDelegate : MulticastDelegate
	{

		public UTessellator_0000016D$PostfixBurstDelegate(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override void Invoke(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, UInt16* indices, ref int iCount, Byte* vertices, int stride, ref int vCount, Allocator label) { }

	}

	public ProfilerMarker generateGeometry; //Field offset: 0x0
	public ProfilerMarker generateCollider; //Field offset: 0x8
	[ReadOnly]
	private JobParameters m_ShapeParams; //Field offset: 0x10
	[DeallocateOnJobCompletion]
	[ReadOnly]
	private NativeArray<JobSpriteInfo> m_SpriteInfos; //Field offset: 0x50
	[DeallocateOnJobCompletion]
	[ReadOnly]
	private NativeArray<JobSpriteInfo> m_CornerSpriteInfos; //Field offset: 0x60
	[DeallocateOnJobCompletion]
	[ReadOnly]
	private NativeArray<JobAngleRange> m_AngleRanges; //Field offset: 0x70
	[DeallocateOnJobCompletion]
	private NativeArray<JobSegmentInfo> m_Segments; //Field offset: 0x80
	private int m_SegmentCount; //Field offset: 0x90
	[DeallocateOnJobCompletion]
	private NativeArray<JobContourPoint> m_ContourPoints; //Field offset: 0x98
	private int m_ContourPointCount; //Field offset: 0xA8
	[DeallocateOnJobCompletion]
	private NativeArray<JobCornerInfo> m_Corners; //Field offset: 0xB0
	private int m_CornerCount; //Field offset: 0xC0
	[DeallocateOnJobCompletion]
	private NativeArray<float2> m_TessPoints; //Field offset: 0xC8
	private int m_TessPointCount; //Field offset: 0xD8
	[DeallocateOnJobCompletion]
	private NativeArray<JobControlPoint> m_ControlPoints; //Field offset: 0xE0
	private int m_ControlPointCount; //Field offset: 0xF0
	[DeallocateOnJobCompletion]
	private NativeArray<float2> m_CornerCoordinates; //Field offset: 0xF8
	[DeallocateOnJobCompletion]
	private NativeArray<JobControlPoint> m_GeneratedControlPoints; //Field offset: 0x108
	[DeallocateOnJobCompletion]
	private NativeArray<int2> m_SpriteIndices; //Field offset: 0x118
	[DeallocateOnJobCompletion]
	private NativeArray<JobIntersectPoint> m_Intersectors; //Field offset: 0x128
	private int m_IndexArrayCount; //Field offset: 0x138
	public NativeArray<UInt16> m_IndexArray; //Field offset: 0x140
	private int m_VertexArrayCount; //Field offset: 0x150
	public NativeSlice<Vector3> m_PosArray; //Field offset: 0x158
	public NativeSlice<Vector2> m_Uv0Array; //Field offset: 0x168
	public NativeSlice<Vector4> m_TanArray; //Field offset: 0x178
	private int m_GeomArrayCount; //Field offset: 0x188
	public NativeArray<SpriteShapeSegment> m_GeomArray; //Field offset: 0x190
	private int m_ColliderPointCount; //Field offset: 0x1A0
	public NativeArray<float2> m_ColliderPoints; //Field offset: 0x1A8
	public NativeArray<Bounds> m_Bounds; //Field offset: 0x1B8
	public NativeArray<SpriteShapeGeneratorStats> m_Stats; //Field offset: 0x1C8
	private int m_IndexDataCount; //Field offset: 0x1D8
	private int m_VertexDataCount; //Field offset: 0x1DC
	private int m_ColliderDataCount; //Field offset: 0x1E0
	private int m_ActiveIndexCount; //Field offset: 0x1E4
	private int m_ActiveVertexCount; //Field offset: 0x1E8
	private float2 m_FirstLT; //Field offset: 0x1EC
	private float2 m_FirstLB; //Field offset: 0x1F4
	private float4x4 m_Transform; //Field offset: 0x1FC
	private int kModeLinear; //Field offset: 0x23C
	private int kModeContinous; //Field offset: 0x240
	private int kModeBroken; //Field offset: 0x244
	private int kModeUTess; //Field offset: 0x248
	private int kCornerTypeOuterTopLeft; //Field offset: 0x24C
	private int kCornerTypeOuterTopRight; //Field offset: 0x250
	private int kCornerTypeOuterBottomLeft; //Field offset: 0x254
	private int kCornerTypeOuterBottomRight; //Field offset: 0x258
	private int kCornerTypeInnerTopLeft; //Field offset: 0x25C
	private int kCornerTypeInnerTopRight; //Field offset: 0x260
	private int kCornerTypeInnerBottomLeft; //Field offset: 0x264
	private int kCornerTypeInnerBottomRight; //Field offset: 0x268
	private int kControlPointCount; //Field offset: 0x26C
	private int kMaxArrayCount; //Field offset: 0x270
	private float kEpsilon; //Field offset: 0x274
	private float kEpsilonOrder; //Field offset: 0x278
	private float kEpsilonRelaxed; //Field offset: 0x27C
	private float kExtendSegment; //Field offset: 0x280
	private float kRenderQuality; //Field offset: 0x284
	private float kOptimizeRender; //Field offset: 0x288
	private float kColliderQuality; //Field offset: 0x28C
	private float kOptimizeCollider; //Field offset: 0x290
	private float kLowestQualityTolerance; //Field offset: 0x294
	private float kHighestQualityTolerance; //Field offset: 0x298

	private float borderPivot
	{
		private get { } //Length: 6
	}

	private float colliderPivot
	{
		private get { } //Length: 6
	}

	private int contourPointCount
	{
		private get { } //Length: 7
	}

	private int controlPointCount
	{
		private get { } //Length: 7
	}

	private bool hasCollider
	{
		private get { } //Length: 8
	}

	private bool hasSpriteBorder
	{
		private get { } //Length: 8
	}

	private bool isAdaptive
	{
		private get { } //Length: 8
	}

	private bool isCarpet
	{
		private get { } //Length: 8
	}

	private int segmentCount
	{
		private get { } //Length: 7
	}

	private int splineDetail
	{
		private get { } //Length: 4
	}

	private int spriteCount
	{
		private get { } //Length: 4
	}

	private int vertexArrayCount
	{
		private get { } //Length: 7
	}

	private bool AddVertex(ref Array<JobShapeVertex>& array, ref int indexCount, JobShapeVertex vertex) { }

	private static float AngleBetweenVector(float2 a, float2 b) { }

	private bool AngleWithinRange(float t, float a, float b) { }

	private void AppendCornerCoordinates(ref NativeArray<float2>& corners, ref int cornerCount, float2 a, float2 b, float2 c, float2 d) { }

	private bool AreCollinear(float2 a, float2 b, float2 c, float t) { }

	private bool AttachCorner(int cp, int ct, JobSpriteInfo ispr, ref NativeArray<JobControlPoint>& newPoints, ref int activePoint) { }

	private void AttachCornerToCollider(JobSegmentInfo isi, float pivot, ref NativeArray<float2>& colliderPoints, ref int colliderPointCount) { }

	private static float2 BezierPoint(float2 st, float2 sp, float2 ep, float2 et, float t) { }

	private void CalculateBoundingBox() { }

	private int CalculateCorner(int index, float angle, float2 lt, float2 rt) { }

	private void CalculateTexCoords() { }

	private static bool Colinear(float2 p, float2 q, float2 r) { }

	private int CopySegmentRenderData(JobSpriteInfo ispr, ref NativeSlice<Vector3>& outPos, ref NativeSlice<Vector2>& outUV0, ref NativeSlice<Vector4>& outTan, ref int outCount, ref NativeArray<UInt16>& indexData, ref int indexCount, ref Array<JobShapeVertex>& inVertices, int inCount, float sOrder) { }

	private void CopyVertexData(ref NativeSlice<Vector3>& outPos, ref NativeSlice<Vector2>& outUV0, ref NativeSlice<Vector4>& outTan, int outIndex, ref Array<JobShapeVertex>& inVertices, int inIndex, float sOrder) { }

	private float2 CornerTextureCoordinate(int cornerType, int index) { }

	private static int Det(float epsilon, float2 p, float2 q, float2 r) { }

	public override void Execute() { }

	private void ExtendSegment(ref float2 l0, ref float2 r0) { }

	private bool FetchStretcher(int segmentIndex, JobSpriteInfo sprInfo, JobSegmentInfo segment, float2 whsize, bool validHead, bool validTail, ref float4 stretcher) { }

	private static bool GenerateColumnsBi(float2 a, float2 b, float2 whsize, bool flip, ref float2 rt, ref float2 rb, float cph, float pivot) { }

	private static bool GenerateColumnsTri(float2 a, float2 b, float2 c, float2 whsize, bool flip, ref float2 rt, ref float2 rb, float cph, float pivot) { }

	private void GenerateContour() { }

	private void GenerateControlPoints() { }

	private void GenerateSegments() { }

	private float get_borderPivot() { }

	private float get_colliderPivot() { }

	private int get_contourPointCount() { }

	private int get_controlPointCount() { }

	private bool get_hasCollider() { }

	private bool get_hasSpriteBorder() { }

	private bool get_isAdaptive() { }

	private bool get_isCarpet() { }

	private int get_segmentCount() { }

	private int get_splineDetail() { }

	private int get_spriteCount() { }

	private int get_vertexArrayCount() { }

	private int GetContourIndex(int index) { }

	private JobContourPoint GetContourPoint(int index) { }

	private JobControlPoint GetControlPoint(int index) { }

	private JobSpriteInfo GetCornerSpriteInfo(int index) { }

	private int GetEndContourIndexOfSegment(JobSegmentInfo isi) { }

	private bool GetIntersection(int cp, int ct, JobSpriteInfo ispr, ref float2 lt0, ref float2 lb0, ref float2 rt0, ref float2 rb0, ref float2 lt1, ref float2 lb1, ref float2 rt1, ref float2 rb1, ref float2 tp, ref float2 bt) { }

	private void GetLineSegments(JobSpriteInfo sprInfo, JobSegmentInfo segment, float2 whsize, ref float2 vlt, ref float2 vlb, ref float2 vrt, ref float2 vrb) { }

	private bool GetSegmentBoundaryColumn(JobSegmentInfo segment, JobSpriteInfo sprInfo, float2 whsize, float2 startPos, float2 endPos, bool end, ref float2 top, ref float2 bottom) { }

	private JobSegmentInfo GetSegmentInfo(int index) { }

	private int GetSpriteIndex(int index, int previousIndex, ref int resolved) { }

	private JobSpriteInfo GetSpriteInfo(int index) { }

	private bool InsertCorner(int index, ref NativeArray<int2>& cpSpriteIndices, ref NativeArray<JobControlPoint>& newPoints, ref int activePoint, ref bool cornerConsidered) { }

	private float InterpolateLinear(float a, float b, float t) { }

	private float InterpolateSmooth(float a, float b, float t) { }

	private static bool IsPointOnLine(float epsilon, float2 a, float2 b, float2 c) { }

	private static bool IsPointOnLines(float epsilon, float2 p1, float2 p2, float2 p3, float2 p4, float2 r) { }

	private static bool LineIntersection(float epsilon, float2 p1, float2 p2, float2 p3, float2 p4, ref float2 result) { }

	private static bool LineIntersectionTest(float epsilon, float2 p1, float2 q1, float2 p2, float2 q2) { }

	private void OptimizeCollider() { }

	private void OptimizePoints(float tolerance, bool tess, ref NativeArray<float2>& pointSet, ref int pointCount) { }

	internal void Prepare(SpriteShapeController controller, SpriteShapeParameters shapeParams, int maxArrayCount, NativeArray<ShapeControlPoint> shapePoints, NativeArray<SplinePointMetaData> metaData, AngleRangeInfo[] angleRanges, Sprite[] segmentSprites, Sprite[] cornerSprites, bool UseUTess) { }

	private void PrepareAngleRanges(AngleRangeInfo[] angleRanges) { }

	private bool PrepareContour() { }

	private void PrepareControlPoints(NativeArray<ShapeControlPoint> shapePoints, NativeArray<SplinePointMetaData> metaData) { }

	private void PrepareInput(SpriteShapeParameters shapeParams, int maxArrayCount, NativeArray<ShapeControlPoint> shapePoints, bool optimizeGeometry, bool updateCollider, bool optimizeCollider, float colliderOffset, float colliderDetail) { }

	private void PrepareSprites(Sprite[] edgeSprites, Sprite[] cornerSprites) { }

	private bool ResolveAngle(float angle, int activeIndex, ref float renderOrder, ref int spriteIndex, ref int firstSpriteIndex) { }

	private float SegmentDistance(JobSegmentInfo isi) { }

	private void SetResult(SpriteShapeGeneratorResult result) { }

	private bool SkipSegment(JobSegmentInfo isi) { }

	private static float SlopeAngle(float2 dirNormalized) { }

	private static float SlopeAngle(float2 start, float2 end) { }

	private void StretchCorners(JobSegmentInfo segment, ref Array<JobShapeVertex>& vertices, int vertexCount, bool validHead, bool validTail, float4 stretcher) { }

	private bool TessellateContour(Allocator label) { }

	private void TessellateContourMainThread() { }

	private void TessellateCorners() { }

	private void TessellateSegment(int segmentIndex, JobSpriteInfo sprInfo, JobSegmentInfo segment, float2 whsize, float4 border, float pxlWidth, ref Array<JobShapeVertex>& vertices, int vertexCount, bool useClosure, bool validHead, bool validTail, bool firstSegment, bool finalSegment, ref Array<JobShapeVertex>& outputVertices, ref int outputCount) { }

	private void TessellateSegments() { }

	private void TransferSprites(ref NativeArray<JobSpriteInfo>& spriteInfos, Sprite[] sprites, int maxCount) { }

	private void TrimOverlaps(int cpCount) { }

	private float2 UpdateCollider(JobSegmentInfo isi, JobSpriteInfo ispr, ref Array<JobShapeVertex>& vertices, int count, ref NativeArray<float2>& colliderPoints, ref int colliderPointCount) { }

	private void UpdateSegments() { }

	[BurstCompile]
	private static void UTessellator(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, UInt16* indices, ref int iCount, Byte* vertices, int stride, ref int vCount, Allocator label) { }

	[BurstCompile]
	public static void UTessellator$BurstManaged(ref SpriteShapeSegment geom, int maxCount, float2* tessPoints, int tessPointCount, UInt16* indices, ref int iCount, Byte* vertices, int stride, ref int vCount, Allocator label) { }

	private bool WithinRange(JobAngleRange angleRange, float inputAngle) { }

}

