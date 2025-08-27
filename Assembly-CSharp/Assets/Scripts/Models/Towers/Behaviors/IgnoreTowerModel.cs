namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(IgnoreTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IgnoreTowerModel : TowerBehaviorModel
{
	public string ignoreId; //Field offset: 0x30

	public IgnoreTowerModel(string name, string ignoreId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

