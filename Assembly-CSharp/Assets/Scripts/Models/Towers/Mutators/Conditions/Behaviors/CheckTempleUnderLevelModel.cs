namespace Assets.Scripts.Models.Towers.Mutators.Conditions.Behaviors;

[Implementation(typeof(CheckTempleUnderLevel), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CheckTempleUnderLevelModel : ConditionalModel
{
	public int cost; //Field offset: 0x30
	public TowerSet towerSet; //Field offset: 0x34
	public string templeType; //Field offset: 0x38

	public CheckTempleUnderLevelModel(string name, int cost, TowerSet towerSet, string templeType) { }

	public virtual Model Clone() { }

}

