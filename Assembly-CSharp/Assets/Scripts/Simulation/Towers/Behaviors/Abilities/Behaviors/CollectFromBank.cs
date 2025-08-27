namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CollectFromBank : AbilityBehavior
{
	public CollectFromBankModel collectFromBankModel; //Field offset: 0x68

	public CollectFromBank() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

