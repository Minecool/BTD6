namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DelayBloonChildrenSpawning : ProjectileBehavior
{
	internal class Mutator : BehaviorMutator
	{

		public Mutator(string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class WindMutator : BehaviorMutator
	{
		public int delaySpawnDuration; //Field offset: 0x70
		public Vector3 ejectLocation; //Field offset: 0x74

		public WindMutator(string id, int delaySpawnDuration, Vector3 ejectLocation) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public DelayBloonChildrenSpawningModel behaviorModel; //Field offset: 0x68

	public DelayBloonChildrenSpawning() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

