namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(FindDeploymentLocation), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FindDeploymentLocationModel : AbilityBehaviorModel
{
	public float searchRadius; //Field offset: 0x30
	public float pointDistance; //Field offset: 0x34
	public TowerModel towerModel; //Field offset: 0x38

	public FindDeploymentLocationModel(string name, float searchRadius, float pointDistance, TowerModel towerModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

