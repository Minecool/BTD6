namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class FighterPilotPatternLast : FighterPilotPattern
{
	public FighterPilotPatternLastModel fighterPilotPatternLastModel; //Field offset: 0x100

	public FighterPilotPatternLast() { }

	public virtual string GetName() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSwitchedTo() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

