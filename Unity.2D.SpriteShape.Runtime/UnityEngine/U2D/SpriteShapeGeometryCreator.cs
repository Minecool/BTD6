namespace UnityEngine.U2D;

public abstract class SpriteShapeGeometryCreator : ScriptableObject
{

	protected SpriteShapeGeometryCreator() { }

	public override int GetVersion() { }

	public abstract int GetVertexArrayCount(SpriteShapeController spriteShapeController) { }

	public abstract JobHandle MakeCreatorJob(SpriteShapeController spriteShapeController, NativeArray<UInt16> indices, NativeSlice<Vector3> positions, NativeSlice<Vector2> texCoords, NativeSlice<Vector4> tangents, NativeArray<SpriteShapeSegment> segments, NativeArray<float2> colliderData) { }

}

