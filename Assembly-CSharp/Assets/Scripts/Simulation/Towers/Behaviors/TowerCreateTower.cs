namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerCreateTower : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public int idFromSave; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <LateSetSaveMetaData>b__0(Tower towerInFactory) { }

	}

	public TowerCreateTowerModel createTowerModel; //Field offset: 0x68
	private Tower createdTower; //Field offset: 0x70

	public TowerCreateTower() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	private void OnCreatedTowerDestroyed(RootObject obj) { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgrade(bool playEffect) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

