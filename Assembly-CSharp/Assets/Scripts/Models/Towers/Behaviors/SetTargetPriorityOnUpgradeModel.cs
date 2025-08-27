namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SetTargetPriorityOnUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetTargetPriorityOnUpgradeModel : TowerBehaviorModel
{
	public int firstPath; //Field offset: 0x30
	public int secondPath; //Field offset: 0x34
	public int thirdPath; //Field offset: 0x38
	public string targetTypeId; //Field offset: 0x40

	public SetTargetPriorityOnUpgradeModel(string name, int firstPath, int secondPath, int thirdPath, string targetTypeId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

