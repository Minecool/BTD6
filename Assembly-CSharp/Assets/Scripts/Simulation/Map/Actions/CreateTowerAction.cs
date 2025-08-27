namespace Assets.Scripts.Simulation.Map.Actions;

public class CreateTowerAction : MapAction
{
	private CreateTowerActionModel createTowerActionModel; //Field offset: 0x60
	private CreateTowerActionSimBehavior simBehavior; //Field offset: 0x68

	public CreateTowerAction() { }

	public CreateTowerAction(Simulation sim) { }

	public virtual void GotoPostAction(int triggerCount, bool loadSave) { }

	public virtual void Init() { }

	public virtual void PerformAction() { }

}

