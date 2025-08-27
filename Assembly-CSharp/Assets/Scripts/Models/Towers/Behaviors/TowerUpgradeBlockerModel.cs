namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(TowerUpgradeBlocker), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerUpgradeBlockerModel : TowerBehaviorModel
{
	public int path1Max; //Field offset: 0x30
	public int path2Max; //Field offset: 0x34
	public int path3Max; //Field offset: 0x38
	public Int32[] pathMaxes; //Field offset: 0x40
	public string blockId; //Field offset: 0x48
	public bool blockAllUpgrades; //Field offset: 0x50

	public TowerUpgradeBlockerModel(string name, int path1Max, int path2Max, int path3Max, string blockId, bool blockAllUpgrades) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

