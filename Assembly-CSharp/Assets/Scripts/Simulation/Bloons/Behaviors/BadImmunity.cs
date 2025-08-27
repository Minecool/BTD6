namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class BadImmunity : BloonBehavior
{
	public static readonly String[] mutatorImmunityIds; //Field offset: 0x0
	public static readonly String[] mutatorImmunityTags; //Field offset: 0x8
	public BadImmunityModel badImmunityModel; //Field offset: 0x70

	private static BadImmunity() { }

	public BadImmunity() { }

	public virtual bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

