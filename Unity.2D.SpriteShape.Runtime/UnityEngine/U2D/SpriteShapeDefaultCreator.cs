namespace UnityEngine.U2D;

internal class SpriteShapeDefaultCreator : SpriteShapeGeometryCreator
{
	private static SpriteShapeDefaultCreator creator; //Field offset: 0x0

	internal static SpriteShapeDefaultCreator defaultInstance
	{
		internal get { } //Length: 204
	}

	public SpriteShapeDefaultCreator() { }

	internal static SpriteShapeDefaultCreator get_defaultInstance() { }

	public virtual int GetVersion() { }

	public virtual int GetVertexArrayCount(SpriteShapeController sc) { }

	public virtual JobHandle MakeCreatorJob(SpriteShapeController sc, NativeArray<UInt16> indices, NativeSlice<Vector3> positions, NativeSlice<Vector2> texCoords, NativeSlice<Vector4> tangents, NativeArray<SpriteShapeSegment> segments, NativeArray<float2> colliderData) { }

}

