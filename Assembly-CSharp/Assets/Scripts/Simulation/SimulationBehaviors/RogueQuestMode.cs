namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class RogueQuestMode : SimulationBehavior
{
	public RogueQuestModeModel behaviorModel; //Field offset: 0x58

	public RogueQuestMode() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

