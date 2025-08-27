//Type is in global namespace

[AddComponentMenu(null)]
internal class SpriteShapeGeometryCache : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private int m_MaxArrayCount; //Field offset: 0x20
	[HideInInspector]
	[SerializeField]
	private Vector3[] m_PosArray; //Field offset: 0x28
	[HideInInspector]
	[SerializeField]
	private Vector2[] m_Uv0Array; //Field offset: 0x30
	[HideInInspector]
	[SerializeField]
	private Vector4[] m_TanArray; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	private UInt16[] m_IndexArray; //Field offset: 0x40
	[HideInInspector]
	[SerializeField]
	private SpriteShapeGeometryInfo[] m_GeomArray; //Field offset: 0x48
	private bool m_RequiresUpdate; //Field offset: 0x50
	private bool m_RequiresUpload; //Field offset: 0x51
	private NativeSlice<Vector3> m_PosArrayCache; //Field offset: 0x58
	private NativeSlice<Vector2> m_Uv0ArrayCache; //Field offset: 0x68
	private NativeSlice<Vector4> m_TanArrayCache; //Field offset: 0x78
	private NativeArray<UInt16> m_IndexArrayCache; //Field offset: 0x88
	private NativeArray<SpriteShapeSegment> m_GeomArrayCache; //Field offset: 0x98

	internal UInt16[] indexArray
	{
		internal get { } //Length: 5
	}

	internal int maxArrayCount
	{
		internal get { } //Length: 4
	}

	internal Vector3[] posArray
	{
		internal get { } //Length: 5
	}

	internal bool requiresUpdate
	{
		internal get { } //Length: 5
	}

	internal bool requiresUpload
	{
		internal get { } //Length: 5
	}

	public Vector4[] tanArray
	{
		 get { } //Length: 5
	}

	public SpriteShapeGeometryCache() { }

	internal UInt16[] get_indexArray() { }

	internal int get_maxArrayCount() { }

	internal Vector3[] get_posArray() { }

	internal bool get_requiresUpdate() { }

	internal bool get_requiresUpload() { }

	public Vector4[] get_tanArray() { }

	private void OnEnable() { }

	internal void SetGeometryCache(int _maxArrayCount, NativeSlice<Vector3> _posArray, NativeSlice<Vector2> _uv0Array, NativeSlice<Vector4> _tanArray, NativeArray<UInt16> _indexArray, NativeArray<SpriteShapeSegment> _geomArray) { }

	internal void UpdateGeometryCache() { }

	internal JobHandle Upload(SpriteShapeRenderer sr, SpriteShapeController sc) { }

}

