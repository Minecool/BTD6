namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(InstaTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class InstaTowerModel : PowerBehaviorModel
{
	public TowerModel towerModel; //Field offset: 0x30
	public TowerModel baseTowerModel; //Field offset: 0x38

	public InstaTowerModel(string name, TowerModel baseTowerModel, TowerModel towerModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

