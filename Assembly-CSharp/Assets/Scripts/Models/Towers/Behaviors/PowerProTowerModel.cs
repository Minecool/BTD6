namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PowerProTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PowerProTowerModel : TowerBehaviorModel
{
	public string powerId; //Field offset: 0x30

	public PowerProTowerModel(string name, string powerId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

