namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RefreshMutatorsOnBloon : ProjectileBehavior
{
	public RefreshMutatorsOnBloonModel refreshMutatorsOnBloonModel; //Field offset: 0x68
	private readonly List<TimedMutator> mutators; //Field offset: 0x70

	public RefreshMutatorsOnBloon() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

