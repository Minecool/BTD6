namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateEffectOnContact : ProjectileBehavior
{
	private CreateEffectOnContactModel createEffectOnContactModel; //Field offset: 0x68
	private Vector3 spawnPosition; //Field offset: 0x70

	public CreateEffectOnContact() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual bool CollideMap(MapBlocker blocker) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

