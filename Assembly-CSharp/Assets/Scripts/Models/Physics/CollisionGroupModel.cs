namespace Assets.Scripts.Models.Physics;

public class CollisionGroupModel : Model
{
	internal class CollisionGroupData
	{
		public Vector2 offset; //Field offset: 0x10
		public float radius; //Field offset: 0x18
		public Vector2 precalculatedOffset; //Field offset: 0x1C

		public CollisionGroupData() { }

	}

	public CollisionGroupData[] collisionGroup; //Field offset: 0x30

	public CollisionGroupModel(string id, CollisionGroupData[] collisionGroup) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

