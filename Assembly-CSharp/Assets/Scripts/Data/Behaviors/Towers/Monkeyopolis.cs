namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "Monkeyopolis", menuName = "BTD6/Behaviors/Towers/Monkeyopolis")]
public class Monkeyopolis : TowerBehavior
{
	public string filterTower; //Field offset: 0x30
	public int valueRequiredForCrate; //Field offset: 0x38
	public int cashFromCrate; //Field offset: 0x3C
	public int baseIncome; //Field offset: 0x40
	public int cratesPerRound; //Field offset: 0x44

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 169
	}

	public Monkeyopolis() { }

	public virtual TowerBehaviorModel get_Def() { }

}

