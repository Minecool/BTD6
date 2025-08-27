namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class IgnoreDmgImmunity : BloonBehavior
{
	internal class RemoveBloonPropertyMutator : BehaviorMutator
	{
		private BloonProperties propertiesToRemove; //Field offset: 0x70

		public RemoveBloonPropertyMutator(string mutationId, bool isUnique, BloonProperties propertiesToRemove) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public IgnoreDmgImmunityModel ignoreDmgImmunityModel; //Field offset: 0x70
	private HashSet<ObjectId> checkedProjectiles; //Field offset: 0x78
	private bool addedMutator; //Field offset: 0x80

	public IgnoreDmgImmunity() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PreCollision(Projectile proj) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

