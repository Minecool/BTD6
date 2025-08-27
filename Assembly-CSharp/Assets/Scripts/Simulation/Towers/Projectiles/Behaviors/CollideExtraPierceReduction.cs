namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CollideExtraPierceReduction : ProjectileBehavior
{
	public CollideExtraPierceReductionModel collideExtraPierceReductionModel; //Field offset: 0x68

	public CollideExtraPierceReduction() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

