namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class FighterPilotPatternClose : FighterPilotPattern
{
	public FighterPilotPatternCloseModel fighterPilotPatternFirstModel; //Field offset: 0x100

	public FighterPilotPatternClose() { }

	public virtual string GetName() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSwitchedTo() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

