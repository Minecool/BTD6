namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class FighterPilotPatternStrong : FighterPilotPattern
{
	public FighterPilotPatternStrongModel fighterPilotPatternStrongModel; //Field offset: 0x100

	public FighterPilotPatternStrong() { }

	public virtual string GetName() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnSwitchedTo() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

