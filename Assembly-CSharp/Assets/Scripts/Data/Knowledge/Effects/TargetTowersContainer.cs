namespace Assets.Scripts.Data.Knowledge.Effects;

public class TargetTowersContainer
{
	public const string AllTowers = "All Towers"; //Field offset: 0x0
	public const string AllRegularTowers = "All Regular (non-Hero) Towers"; //Field offset: 0x0
	public const string AllHeroes = "All Heroes"; //Field offset: 0x0
	public String[] targetTowerNames; //Field offset: 0x10

	public TargetTowersContainer() { }

}

