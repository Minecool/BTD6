namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class SoulbindManager : TowerBehavior
{
	public SoulbindManagerModel soulbindManagerModel; //Field offset: 0x68
	public List<String> currentSoulboundTowerIds; //Field offset: 0x70

	public SoulbindManager() { }

	public void AddSoulBoundTower(Tower tow) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public virtual void OnLivesLost(bool fromLeak) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

