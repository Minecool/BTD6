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
		public static Comparison<AngleRange> <>9__158_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <UpdateSpriteData>b__158_0(AngleRange a, AngleRange b) { }

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
	private NativeArray<float2> m_ShadowData; //Field offset: 0x78
	private NativeArray<Vector4> m_TangentData; //Field offset: 0x88
	private NativeArray<SpriteShapeGeneratorStats> m_Statistics; //Field offset: 0x98
	private bool m_DynamicOcclusionLocal; //Field offset: 0xA8
	private bool m_DynamicOcclusionOverriden; //Field offset: 0xA9
	private bool m_TessellationNeedsFallback; //Field offset: 0xAA
	private int m_ActiveSplineHash; //Field offset: 0xAC
	private int m_ActiveSpriteShapeHash; //Field offset: 0xB0
	private int m_MaxArrayCount; //Field offset: 0xB4
	private JobHandle m_JobHandle; //Field offset: 0xB8
	private SpriteShapeParameters m_ActiveShapeParameters; //Field offset: 0xC8
	[SerializeField]
	private Spline m_Spline; //Field offset: 0x130
	[SerializeField]
	private SpriteShape m_SpriteShape; //Field offset: 0x138
	[SerializeField]
	private float m_FillPixelPerUnit; //Field offset: 0x140
	[SerializeField]
	private float m_StretchTiling; //Field offset: 0x144
	[SerializeField]
	private int m_SplineDetail; //Field offset: 0x148
	[SerializeField]
	private bool m_AdaptiveUV; //Field offset: 0x14C
	[SerializeField]
	private bool m_StretchUV; //Field offset: 0x14D
	[SerializeField]
	private bool m_WorldSpaceUV; //Field offset: 0x14E
	[SerializeField]
	private float m_CornerAngleThreshold; //Field offset: 0x150
	[SerializeField]
	private int m_ColliderDetail; //Field offset: 0x154
	[Range(-0.5, 0.5)]
	[SerializeField]
	private float m_ColliderOffset; //Field offset: 0x158
	[SerializeField]
	private bool m_UpdateCollider; //Field offset: 0x15C
	[SerializeField]
	private bool m_EnableTangents; //Field offset: 0x15D
	[HideInInspector]
	[SerializeField]
	private bool m_GeometryCached; //Field offset: 0x15E
	[SerializeField]
	private bool m_UTess2D; //Field offset: 0x15F
	[SerializeField]
	private bool m_UpdateShadow; //Field offset: 0x160
	[SerializeField]
	private int m_ShadowDetail; //Field offset: 0x164
	[Range(-0.5, 0.5)]
	[SerializeField]
	private float m_ShadowOffset; //Field offset: 0x168
	[SerializeField]
	private float m_BoundsScale; //Field offset: 0x16C
	[SerializeField]
	private SpriteShapeGeometryCreator m_Creator; //Field offset: 0x170
	[SerializeField]
	private List<SpriteShapeGeometryModifier> m_Modifiers; //Field offset: 0x178
	[SerializeField]
	private List<Vector2> m_ColliderSegment; //Field offset: 0x180
	[SerializeField]
	private List<Vector2> m_ShadowSegment; //Field offset: 0x188

	public AngleRangeInfo[] angleRangeInfoArray
	{
		 get { } //Length: 5
	}

	public bool autoUpdateCollider
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public float boundsScale
	{
		 get { } //Length: 9
		 set { } //Length: 33
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
		 get { } //Length: 242
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
		 get { } //Length: 242
	}

	internal NativeArray<float2> shadowData
	{
		internal get { } //Length: 11
	}

	internal int shadowDetail
	{
		internal get { } //Length: 7
		internal set { } //Length: 7
	}

	internal float shadowOffset
	{
		internal get { } //Length: 9
		internal set { } //Length: 9
	}

	internal List<Vector2> shadowSegment
	{
		internal get { } //Length: 8
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
		 get { } //Length: 307
		 set { } //Length: 100
	}

	internal SpriteShapeGeometryCache spriteShapeGeometryCache
	{
		internal get { } //Length: 311
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
		internal get { } //Length: 144
	}

	public float stretchTiling
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	internal bool updateShadow
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
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

	internal void BakeShadow() { }

	internal int CalculateMaxArrayCount(NativeArray<ShapeControlPoint> shapePoints) { }

	private void DisposeInternal() { }

	internal void ForceShadowShapeUpdate(bool forceUpdate) { }

	public AngleRangeInfo[] get_angleRangeInfoArray() { }

	public bool get_autoUpdateCollider() { }

	public float get_boundsScale() { }

	public int get_colliderDetail() { }

	public float get_colliderOffset() { }

	public float get_cornerAngleThreshold() { }

	internal Sprite[] get_cornerSpriteArray() { }

	public EdgeCollider2D get_edgeCollider() { }

	internal Sprite[] get_edgeSpriteArray() { }

	public bool get_enableTangents() { }

	public float get_fillPixelsPerUnit() { }

	internal bool get_geometryCached() { }

	public bool get_hasCollider() { }

	internal int get_maxArrayCount() { }

	public List<SpriteShapeGeometryModifier> get_modifiers() { }

	public bool get_optimizeCollider() { }

	public bool get_optimizeGeometry() { }

	public PolygonCollider2D get_polygonCollider() { }

	internal NativeArray<float2> get_shadowData() { }

	internal int get_shadowDetail() { }

	internal float get_shadowOffset() { }

	internal List<Vector2> get_shadowSegment() { }

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

	internal bool get_updateShadow() { }

	public bool get_worldSpaceUVs() { }

	private int GetCustomScriptHashCode() { }

	internal NativeArray<float2> GetShadowShapeData() { }

	internal NativeArray<ShapeControlPoint> GetShapeControlPoints() { }

	internal NativeArray<SplinePointMetaData> GetSplinePointMetaData() { }

	private bool HasSplineDataChanged() { }

	private bool HasSpriteShapeChanged() { }

	private bool HasSpriteShapeDataChanged() { }

	internal Bounds InitBounds() { }

	private void LateUpdate() { }

	private void OnApplicationQuit() { }

	private void OnBecameInvisible() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnWillRenderObject() { }

	public void RefreshSpriteShape() { }

	private void Reset() { }

	private JobHandle ScheduleBake() { }

	public void set_autoUpdateCollider(bool value) { }

	public void set_boundsScale(float value) { }

	public void set_colliderDetail(int value) { }

	public void set_colliderOffset(float value) { }

	public void set_cornerAngleThreshold(float value) { }

	public void set_enableTangents(bool value) { }

	public void set_fillPixelsPerUnit(float value) { }

	internal void set_geometryCached(bool value) { }

	internal void set_maxArrayCount(int value) { }

	internal void set_shadowDetail(int value) { }

	internal void set_shadowOffset(float value) { }

	public void set_splineDetail(int value) { }

	public void set_spriteShape(SpriteShape value) { }

	public void set_spriteShapeCreator(SpriteShapeGeometryCreator value) { }

	public void set_stretchTiling(float value) { }

	internal void set_updateShadow(bool value) { }

	public void set_worldSpaceUVs(bool value) { }

	private static void SmartDestroy(object o) { }

	internal void UpdateGeometryCache() { }

	private void UpdateSpriteData() { }

	public bool UpdateSpriteShapeParameters() { }

	private bool ValidateSpline() { }

	private bool ValidateSpriteShapeTexture() { }

	internal bool ValidateUTess2D() { }

}

