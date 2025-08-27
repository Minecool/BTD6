namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class PropSpawningChallenge : SimulationBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Prop prop; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal GroupedLayerSpawnerData <OnMatchReady>b__0(int key) { }

		internal GroupedLayerSpawnerData <OnMatchReady>b__1(int key, GroupedLayerSpawnerData existingValue) { }

	}

	internal struct GroupedLayerSpawnerData
	{
		public List<Prop> propsOnLayer; //Field offset: 0x0
		public int currSpawnIndex; //Field offset: 0x8
		public int currPropEmitterIndex; //Field offset: 0xC

	}

	internal class PropRemoveableCostMutator : BehaviorMutator
	{
		private PropRemoveableCostModel removeableCostModel; //Field offset: 0x70

		public PropRemoveableCostMutator(PropRemoveableCostModel removeableCostModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public PropSpawningChallengeModel behaviorModel; //Field offset: 0x58
	public ConcurrentDictionary<Int32, GroupedLayerSpawnerData> propLayerData; //Field offset: 0x60
	private PropRemoveableCostMutator mutator; //Field offset: 0x68
	private int totalPropsAlive; //Field offset: 0x70
	public bool defeatTriggered; //Field offset: 0x74

	public PropSpawningChallenge() { }

	private void CountTotalPropsSpawned() { }

	private Prop FindNextDisabledPropOnLayer(int layerId, GroupedLayerSpawnerData layerData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnMatchReady(bool loadedSave) { }

	public void OnPropRemoved(PropBase prop) { }

	public virtual void OnRoundEnd(int roundArrayIndex) { }

	private void TriggerDefeat() { }

	private void TriggerVictory() { }

	private bool TrySpawnPropOnLayer(int layerId, GroupedLayerSpawnerData layerData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

