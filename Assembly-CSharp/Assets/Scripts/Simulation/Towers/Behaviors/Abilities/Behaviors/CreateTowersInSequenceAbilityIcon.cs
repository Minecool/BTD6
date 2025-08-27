namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CreateTowersInSequenceAbilityIcon : AbilityBehavior
{
	public CreateTowersInSequenceAbilityIconModel createTowersInSequenceAbilityIconModel; //Field offset: 0x68
	private CreateSequencedTypedTowerCurrentIndex createSequencedTypedTowerCurrentIndex; //Field offset: 0x70

	public CreateTowersInSequenceAbilityIcon() { }

	public virtual SpriteReference GetAbilityIcon() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

