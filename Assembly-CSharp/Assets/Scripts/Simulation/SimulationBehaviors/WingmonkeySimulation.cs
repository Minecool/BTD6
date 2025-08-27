namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class WingmonkeySimulation : SimulationBehavior
{
	private const int groupSize = 3; //Field offset: 0x0
	public WingmonkeySimulationModel wingmonkeySimulationModel; //Field offset: 0x58
	private List<WingmonkeyPattern> wingmonkeys; //Field offset: 0x60

	public WingmonkeySimulation() { }

	public int GetGroupIndex(WingmonkeyPattern wingmonkey) { }

	public Vector3 GetGroupOffset(WingmonkeyPattern wingmonkey) { }

	public WingmonkeyPattern GetLeader(WingmonkeyPattern wingmonkey) { }

	public Vector3 GetPositionInGroup(WingmonkeyPattern wingmonkey) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsLeader(WingmonkeyPattern wingmonkey) { }

	protected virtual void OnDestroy() { }

	public void OnTowerSetFromWingmonkey(WingmonkeyPattern wingmonkey) { }

	public void OnTowerSetToWingmonkey(WingmonkeyPattern wingmonkey) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

