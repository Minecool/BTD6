namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ScaleHeroXpWithTowerCount), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ScaleHeroXpWithTowerCountModel : TowerBehaviorModel
{
	public string towerIds; //Field offset: 0x30
	public int tier; //Field offset: 0x38
	public int percentPerTower; //Field offset: 0x3C
	public int maxPercent; //Field offset: 0x40

	public ScaleHeroXpWithTowerCountModel(string name, string towerIds, int tier, int percentPerTower, int maxPercent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

