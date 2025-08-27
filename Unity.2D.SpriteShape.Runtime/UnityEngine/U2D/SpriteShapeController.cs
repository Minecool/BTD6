namespace UnityEngine.U2D;

[DisallowMultipleComponent]
[ExecuteInEditMode]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.spriteshape@latest/index.html?subfolder=/manual/SSController.html")]
[RequireComponent(typeof(SpriteShapeRenderer))]
public class SpriteShapeController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<AngleRange> <>9__137_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <UpdateSpriteData>b__137_0(AngleRange a, AngleRange b) { }

	}

	private const float s_DistanceTolerance = 0.001; //Field offset: 0x0
	internal static readonly ProfilerMarker generateGeometry; //Field offset: 0x0
	internal static readonly ProfilerMarker generateCollider; //Field offset: 0x8
	private SpriteShape m_ActiveSpriteShape; //Field offset: 0x20
	private EdgeCollider2D m_EdgeCollider2D; //Field offset: 0x28
	private PolygonCollider2D m_PolygonCollider2D; //Field offset: 0x30
	private SpriteShapeRenderer m_SpriteShapeRenderer; //Field offset: 0x38
	private SpriteShapeGeometryCache m_SpriteShapeGeometryCache; //Field offset: 0x40
	private Sprite[] m_SpriteArray; //Field offset: 0x48
	private Sprite[] m_EdgeSpriteArray; //Field offset: 0x50
	private Sprite[] m_CornerSpriteArray; //Field offset: 0x58
	private AngleRangeInfo[] m_AngleRangeInfoArray; //Field offset: 0x60
	private NativeArray<float2> m_ColliderData; //Field offset: 0x68
	private NativeArray<Vector4> m_TangentData; //Field offset: 0x78
	private NativeArray<SpriteShapeGeneratorStats> m_Statistics; //Field offset: 0x88
	private bool m_DynamicOcclusionLocal; //Field offset: 0x98
	private bool m_DynamicOcclusionOverriden; //Field offset: 0x99
	private bool m_ForceColliderShapeUpdate; //Field offset: 0x9A
	private int m_ActiveSplineHash; //Field offset: 0x9C
	private int m_ActiveSpriteShapeHash; //Field offset: 0xA0
	private int m_MaxArrayCount; //Field offset: 0xA4
	private JobHandle m_JobHandle; //Field offset: 0xA8
	private SpriteShapeParameters m_ActiveShapeParameters; //Field offset: 0xB8
	[SerializeField]
	private Spline m_Spline; //Field offset: 0x120
	[SerializeField]
	private SpriteShape m_SpriteShape; //Field offset: 0x128
	[SerializeField]
	private float m_FillPixelPerUnit; //Field offset: 0x130
	[SerializeField]
	private float m_StretchTiling; //Field offset: 0x134
	[SerializeField]
	private int m_SplineDetail; //Field offset: 0x138
	[SerializeField]
	private bool m_AdaptiveUV; //Field offset: 0x13C
	[SerializeField]
	private bool m_StretchUV; //Field offset: 0x13D
	[SerializeField]
	private bool m_WorldSpaceUV; //Field offset: 0x13E
	[SerializeField]
	private float m_CornerAngleThreshold; //Field offset: 0x140
	[SerializeField]
	private int m_ColliderDetail; //Field offset: 0x144
	[Range(-0.5, 0.5)]
	[SerializeField]
	private float m_ColliderOffset; //Field offset: 0x148
	[SerializeField]
	private bool m_UpdateCollider; //Field offset: 0x14C
	[SerializeField]
	private bool m_EnableTangents; //Field offset: 0x14D
	[HideInInspector]
	[SerializeField]
	private bool m_GeometryCached; //Field offset: 0x14E
	[SerializeField]
	private bool m_UTess2D; //Field offset: 0x14F
	[SerializeField]
	private SpriteShapeGeometryCreator m_Creator; //Field offset: 0x150
	[SerializeField]
	private List<SpriteShapeGeometryModifier> m_Modifiers; //Field offset: 0x158
	[SerializeField]
	private List<Vector2> m_ColliderSegment; //Field offset: 0x160

	public AngleRangeInfo[] angleRangeInfoArray
	{
		 get { } //Length: 5
	}

	public bool autoUpdateCollider
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public int colliderDetail
	{
		 get { } //Length: 7
		 set { } //Length: 16
	}

	public float colliderOffset
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float cornerAngleThreshold
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	internal Sprite[] cornerSpriteArray
	{
		internal get { } //Length: 5
	}

	public EdgeCollider2D edgeCollider
	{
		 get { } //Length: 254
	}

	internal Sprite[] edgeSpriteArray
	{
		internal get { } //Length: 5
	}

	public bool enableTangents
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public float fillPixelsPerUnit
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	internal bool forceColliderShapeUpdate
	{
		internal get { } //Length: 8
	}

	internal bool geometryCached
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	public bool hasCollider
	{
		 get { } //Length: 162
	}

	internal int maxArrayCount
	{
		internal get { } //Length: 7
		internal set { } //Length: 7
	}

	public List<SpriteShapeGeometryModifier> modifiers
	{
		 get { } //Length: 8
	}

	public bool optimizeCollider
	{
		 get { } //Length: 3
	}

	public bool optimizeGeometry
	{
		 get { } //Length: 3
	}

	public PolygonCollider2D polygonCollider
	{
		 get { } //Length: 254
	}

	public Spline spline
	{
		 get { } //Length: 8
	}

	public int splineDetail
	{
		 get { } //Length: 7
		 set { } //Length: 16
	}

	internal int splineHashCode
	{
		internal get { } //Length: 7
	}

	internal Sprite[] spriteArray
	{
		internal get { } //Length: 5
	}

	public SpriteShape spriteShape
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public SpriteShapeGeometryCreator spriteShapeCreator
	{
		 get { } //Length: 308
		 set { } //Length: 100
	}

	internal SpriteShapeGeometryCache spriteShapeGeometryCache
	{
		internal get { } //Length: 327
	}

	public int spriteShapeHashCode
	{
		 get { } //Length: 7
	}

	internal SpriteShapeParameters spriteShapeParameters
	{
		internal get { } //Length: 82
	}

	public SpriteShapeRenderer spriteShapeRenderer
	{
		 get { } //Length: 126
	}

	internal NativeArray<SpriteShapeGeneratorStats> stats
	{
		internal get { } //Length: 146
	}

	public float stretchTiling
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public bool worldSpaceUVs
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	private static SpriteShapeController() { }

	public SpriteShapeController() { }

	public void BakeCollider() { }

	public JobHandle BakeMesh() { }

	internal void BakeMeshForced() { }

	internal int CalculateMaxArrayCount(NativeArray<ShapeControlPoint> shapePoints) { }

	private void DisposeInternal() { }

	internal void ForceColliderShapeUpdate(bool forceUpdate) { }

	public AngleRangeInfo[] get_angleRangeInfoArray() { }

	public bool get_autoUpdateCollider() { }

	public int get_colliderDetail() { }

	public float get_colliderOffset() { }

	public float get_cornerAngleThreshold() { }

	internal Sprite[] get_cornerSpriteArray() { }

	public EdgeCollider2D get_edgeCollider() { }

	internal Sprite[] get_edgeSpriteArray() { }

	public bool get_enableTangents() { }

	public float get_fillPixelsPerUnit() { }

	internal bool get_forceColliderShapeUpdate() { }

	internal bool get_geometryCached() { }

	public bool get_hasCollider() { }

	internal int get_maxArrayCount() { }

	public List<SpriteShapeGeometryModifier> get_modifiers() { }

	public bool get_optimizeCollider() { }

	public bool get_optimizeGeometry() { }

	public PolygonCollider2D get_polygonCollider() { }

	public Spline get_spline() { }

	public int get_splineDetail() { }

	internal int get_splineHashCode() { }

	internal Sprite[] get_spriteArray() { }

	public SpriteShape get_spriteShape() { }

	public SpriteShapeGeometryCreator get_spriteShapeCreator() { }

	internal SpriteShapeGeometryCache get_spriteShapeGeometryCache() { }

	public int get_spriteShapeHashCode() { }

	internal SpriteShapeParameters get_spriteShapeParameters() { }

	public SpriteShapeRenderer get_spriteShapeRenderer() { }

	internal NativeArray<SpriteShapeGeneratorStats> get_stats() { }

	public float get_stretchTiling() { }

	public bool get_worldSpaceUVs() { }

	internal NativeArray<float2> GetColliderShapeData() { }

	private int GetCustomScriptHashCode() { }

	internal NativeArray<ShapeControlPoint> GetShapeControlPoints() { }

	internal NativeArray<SplinePointMetaData> GetSplinePointMetaData() { }

	private bool HasSplineDataChanged() { }

	private bool HasSpriteShapeChanged() { }

	private bool HasSpriteShapeDataChanged() { }

	internal Bounds InitBounds() { }

	private void LateUpdate() { }

	private void OnApplicationQuit() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnWillRenderObject() { }

	public void RefreshSpriteShape() { }

	private void Reset() { }

	private JobHandle ScheduleBake() { }

	public void set_autoUpdateCollider(bool value) { }

	public void set_colliderDetail(int value) { }

	public void set_colliderOffset(float value) { }

	public void set_cornerAngleThreshold(float value) { }

	public void set_enableTangents(bool value) { }

	public void set_fillPixelsPerUnit(float value) { }

	internal void set_geometryCached(bool value) { }

	internal void set_maxArrayCount(int value) { }

	public void set_splineDetail(int value) { }

	public void set_spriteShape(SpriteShape value) { }

	public void set_spriteShapeCreator(SpriteShapeGeometryCreator value) { }

	public void set_stretchTiling(float value) { }

	public void set_worldSpaceUVs(bool value) { }

	private static void SmartDestroy(object o) { }

	internal void UpdateGeometryCache() { }

	private void UpdateSpriteData() { }

	public bool UpdateSpriteShapeParameters() { }

	private bool ValidateSpline() { }

	private bool ValidateSpriteShapeTexture() { }

	internal bool ValidateUTess2D() { }

}

