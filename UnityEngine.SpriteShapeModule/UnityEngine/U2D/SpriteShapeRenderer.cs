namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeType(Header = "Modules/SpriteShape/Public/SpriteShapeRenderer.h")]
public class SpriteShapeRenderer : Renderer
{

	public Color color
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public SpriteShapeRenderer() { }

	public Color get_color() { }

	private void get_color_Injected(out Color ret) { }

	public SpriteMaskInteraction get_maskInteraction() { }

	public NativeArray<Bounds> GetBounds() { }

	private NativeSlice<T> GetChannelDataArray(SpriteShapeDataType dataType, VertexAttribute channel) { }

	private SpriteChannelInfo GetChannelInfo(VertexAttribute channel) { }

	private void GetChannelInfo_Injected(VertexAttribute channel, out SpriteChannelInfo ret) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Color32>& colors) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Color32>& colors, out NativeSlice<Vector4>& tangents, out NativeSlice<Vector3>& normals) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Vector4>& tangents, out NativeSlice<Vector3>& normals) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Color32>& colors, out NativeSlice<Vector4>& tangents) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords, out NativeSlice<Vector4>& tangents) { }

	public void GetChannels(int dataSize, out NativeArray<UInt16>& indices, out NativeSlice<Vector3>& vertices, out NativeSlice<Vector2>& texcoords) { }

	private SpriteChannelInfo GetDataInfo(SpriteShapeDataType arrayType) { }

	private void GetDataInfo_Injected(SpriteShapeDataType arrayType, out SpriteChannelInfo ret) { }

	private NativeArray<T> GetNativeDataArray(SpriteShapeDataType dataType) { }

	public NativeArray<SpriteShapeSegment> GetSegments(int dataSize) { }

	public void Prepare(JobHandle handle, SpriteShapeParameters shapeParams, Sprite[] sprites) { }

	private void Prepare_Injected(ref JobHandle handle, ref SpriteShapeParameters shapeParams, Sprite[] sprites) { }

	public void set_color(Color value) { }

	private void set_color_Injected(ref Color value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	public void SetLocalAABB(Bounds bounds) { }

	private void SetLocalAABB_Injected(ref Bounds bounds) { }

	private void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask) { }

	private void SetMeshDataCount(int vertexCount, int indexCount) { }

	private void SetSegmentCount(int geomCount) { }

}

