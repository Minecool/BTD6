namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ClearHitBloonsWhenNoLongerColliding : ProjectileBehavior
{
	public ClearHitBloonsWhenNoLongerCollidingModel clearHitBloonsWhenNoLongerCollidingModel; //Field offset: 0x68
	private float lastClear; //Field offset: 0x70
	private List<ObjectId> collidedWithLayerIds; //Field offset: 0x78
	private List<Bloon> currentCollisionList; //Field offset: 0x80
	private List<ObjectId> stillCollidingWith; //Field offset: 0x88

	public ClearHitBloonsWhenNoLongerColliding() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

