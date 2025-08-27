namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RemoveMutatorsFromBloon : ProjectileBehavior
{
	public RemoveMutatorsFromBloonModel removeMutatorsFromBloonModel; //Field offset: 0x68
	private readonly List<BehaviorMutator> mutators; //Field offset: 0x70

	public RemoveMutatorsFromBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

