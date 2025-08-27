namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerExpire : TowerBehavior
{
	public TowerExpireModel towerExpireModel; //Field offset: 0x68
	public int roundsRemaining; //Field offset: 0x70

	public TowerExpire() { }

	public virtual void Attatched() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void OnDefeatScreen() { }

	protected virtual void OnDestroy() { }

	public virtual void OnRoundComplete(int roundArrayIndex) { }

	public void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

