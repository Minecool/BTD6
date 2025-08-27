namespace Assets.Scripts.Models.TowerSets;

[Flags]
public enum TowerSet
{
	None = 0,
	Primary = 1,
	Military = 2,
	Magic = 4,
	Support = 8,
	Hero = 16,
	Paragon = 32,
	Items = 64,
	AllMonkeyTowerSets = 15,
}

