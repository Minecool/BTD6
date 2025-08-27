namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ArtilleryCommand : AbilityBehavior
{
	public class ArtilleryCommandDamageMutator : BehaviorMutator
	{

		public ArtilleryCommandDamageMutator() { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	private static String[] towerFilterList; //Field offset: 0x0
	public ArtilleryCommandModel artilleryCommandModel; //Field offset: 0x68

	private static ArtilleryCommand() { }

	public ArtilleryCommand() { }

	public virtual void Activate() { }

	private void AddEffectToTower(Tower thisTower) { }

	public virtual bool CanUseAbility() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

