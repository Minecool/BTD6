namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(Monkeyopolis), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyopolisModel : TowerBehaviorModel
{
	public string filterTower; //Field offset: 0x30
	public int valueRequiredForCrate; //Field offset: 0x38
	public int cashFromCrate; //Field offset: 0x3C
	public int baseIncome; //Field offset: 0x40
	public int cratesPerRound; //Field offset: 0x44

	public MonkeyopolisModel(string name, string filterTower, int valueRequiredForCrate, int cashFromCrate, int baseIncome, int cratesPerRound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

