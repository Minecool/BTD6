namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class SyphonManaFromGraveyards : AbilityBehavior
{
	public SyphonManaFromGraveyardsModel syphonManaFromGraveyardsModel; //Field offset: 0x68

	public SyphonManaFromGraveyards() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

