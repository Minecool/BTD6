namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(DestroyChildTowersOnUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyChildTowersOnUpgradeModel : TowerBehaviorModel
{
	public string towerId; //Field offset: 0x30

	public DestroyChildTowersOnUpgradeModel(string name, string towerId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

