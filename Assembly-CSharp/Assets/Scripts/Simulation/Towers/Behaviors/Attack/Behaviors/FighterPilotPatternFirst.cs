namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class FighterPilotPatternFirst : FighterPilotPattern
{
	public FighterPilotPatternFirstModel fighterPilotPatternFirstModel; //Field offset: 0x100

	public FighterPilotPatternFirst() { }

	public virtual string GetName() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSwitchedTo() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

