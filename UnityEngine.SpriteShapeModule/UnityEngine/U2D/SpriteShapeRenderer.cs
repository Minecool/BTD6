namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeType(Header = "Modules/SpriteShape/Public/SpriteShapeRenderer.h")]
public class SpriteShapeRenderer : Renderer
{

	public Color color
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public SpriteShapeRenderer() { }

	public Color get_color() { }

	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	public SpriteMaskInteraction get_maskInteraction() { }

	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	public NativeArray<Bounds> GetBounds() { }

	private NativeSlice<T> GetChannelDataArray(SpriteShapeDataType dataType, VertexAttribute channel) { }

	private SpriteChannelInfo GetChannelInfo(VertexAttribute channel) { }

	private static void GetChannelInfo_Injected(IntPtr _unity_self, VertexAttribute channel, out SpriteChannelInfo ret) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Color32>& colors, out NativeSlice<Vector4>& tangents, out NativeSlice<Vector3>& normals) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Vector4>& tangents, out NativeSlice<Vector3>& normals) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Color32>& colors, out NativeSlice<Vector4>& tangents) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Vector4>& tangents) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Color32>& colors) { }

	private SpriteChannelInfo GetDataInfo(SpriteShapeDataType arrayType) { }

	private static void GetDataInfo_Injected(IntPtr _unity_self, SpriteShapeDataType arrayType, out SpriteChannelInfo ret) { }

	private NativeArray<T> GetNativeDataArray(SpriteShapeDataType dataType) { }

	public NativeArray<SpriteShapeSegment> GetSegments(int dataSize) { }

	public int GetSplineMeshCount() { }

	private static int GetSplineMeshCount_Injected(IntPtr _unity_self) { }

	public void Prepare(JobHandle handle, SpriteShapeParameters shapeParams, Sprite[] sprites) { }

	private static void Prepare_Injected(IntPtr _unity_self, in JobHandle handle, in SpriteShapeParameters shapeParams, Sprite[] sprites) { }

	public void set_color(Color value) { }

	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	public void SetLocalAABB(Bounds bounds) { }

	private static void SetLocalAABB_Injected(IntPtr _unity_self, in Bounds bounds) { }

	private void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask) { }

	private static void SetMeshChannelInfo_Injected(IntPtr _unity_self, int vertexCount, int indexCount, int hotChannelMask) { }

	private void SetMeshDataCount(int vertexCount, int indexCount) { }

	private static void SetMeshDataCount_Injected(IntPtr _unity_self, int vertexCount, int indexCount) { }

	private void SetSegmentCount(int geomCount) { }

	private static void SetSegmentCount_Injected(IntPtr _unity_self, int geomCount) { }

}

