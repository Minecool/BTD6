namespace Assets.Scripts.Simulation.Map.Actions;

public class IncrementCaveMonkeyHitsAction : MapAction
{
	private IncrementCaveMonkeyHitsActionModel incrementCaveMonkeyHitsModel; //Field offset: 0x60

	public IncrementCaveMonkeyHitsAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

