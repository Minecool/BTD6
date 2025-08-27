namespace Assets.Scripts.Unity.Towers.Behaviors;

public class Monkeyopolis : TowerBehavior
{
	public Monkeyopolis parent; //Field offset: 0x98
	public string filterTower; //Field offset: 0xA0
	public string expFilterTower; //Field offset: 0xA8
	public int valueRequiredForCrate; //Field offset: 0xB0
	public string expValueRequiredForCrate; //Field offset: 0xB8
	public int cashFromCrate; //Field offset: 0xC0
	public string expCashFromCrate; //Field offset: 0xC8
	public int baseIncome; //Field offset: 0xD0
	public string expBaseIncome; //Field offset: 0xD8
	public int cratesPerRound; //Field offset: 0xE0
	public string expCratesPerRound; //Field offset: 0xE8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 184
	}

	public Monkeyopolis() { }

	public virtual TowerBehaviorModel get_Def() { }

}

