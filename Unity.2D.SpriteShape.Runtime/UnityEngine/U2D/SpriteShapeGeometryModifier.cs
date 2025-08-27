namespace UnityEngine.U2D;

public abstract class SpriteShapeGeometryModifier : ScriptableObject
{

	protected SpriteShapeGeometryModifier() { }

	public override int GetVersion() { }

	public abstract JobHandle MakeModifierJob(JobHandle generator, SpriteShapeController spriteShapeController, NativeArray<UInt16> indices, NativeSlice<Vector3> positions, NativeSlice<Vector2> texCoords, NativeSlice<Vector4> tangents, NativeArray<SpriteShapeSegment> segments, NativeArray<float2> colliderData) { }

}

