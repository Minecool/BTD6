namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(RangeUpFromUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RangeUpFromUpgradeModel : TowerBehaviorModel
{
	public float rangePerUpgrade; //Field offset: 0x30
	public int upgradeTier; //Field offset: 0x34
	public int upgradePath; //Field offset: 0x38
	public string towerBaseId; //Field offset: 0x40

	public RangeUpFromUpgradeModel(string name, float rangePerUpgrade, int upgradeTier, int upgradePath, string towerBaseId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

