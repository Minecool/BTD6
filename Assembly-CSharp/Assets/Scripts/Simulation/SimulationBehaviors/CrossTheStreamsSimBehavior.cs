namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class CrossTheStreamsSimBehavior : SimulationBehavior
{
	public CrossTheStreamsSimBehaviorModel crossTheStreamsSimBehaviorModel; //Field offset: 0x58
	private int timeOfLastExplosion; //Field offset: 0x60
	private SingleEmission emission; //Field offset: 0x68
	private List<KeyValuePair`2<Tower, Tower>> emittedForPairs; //Field offset: 0x70

	public CrossTheStreamsSimBehavior() { }

	private bool GetLineStartAndEndPoints(Tower tower, out Vector2 startPoint, out Vector2 endPoint) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

