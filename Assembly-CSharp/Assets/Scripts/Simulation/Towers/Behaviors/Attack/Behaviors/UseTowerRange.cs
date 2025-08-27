namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class UseTowerRange : AttackBehavior
{
	public UseTowerRangeModel useTowerRangeModel; //Field offset: 0x68

	public UseTowerRange() { }

	public virtual Nullable<Single> GetRange() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

