namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RemoveMutatorOnUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveMutatorOnUpgradeModel : TowerBehaviorModel
{
	public string mutatorId; //Field offset: 0x30
	public int firstPath; //Field offset: 0x38
	public int secondPath; //Field offset: 0x3C
	public int thirdPath; //Field offset: 0x40
	public Int32[] paths; //Field offset: 0x48

	public RemoveMutatorOnUpgradeModel(string name, string mutatorId, int firstPath, int secondPath, int thirdPath) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

