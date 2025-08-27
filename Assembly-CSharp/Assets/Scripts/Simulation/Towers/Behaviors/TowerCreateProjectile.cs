namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerCreateProjectile : TowerBehavior
{
	public TowerCreateProjectileModel towerCreateProjectileModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70
	private int lastEmitAt; //Field offset: 0x78

	public TowerCreateProjectile() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

