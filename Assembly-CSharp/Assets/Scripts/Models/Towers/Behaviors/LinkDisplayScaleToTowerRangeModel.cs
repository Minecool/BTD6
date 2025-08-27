namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(LinkDisplayScaleToTowerRange), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LinkDisplayScaleToTowerRangeModel : TowerBehaviorModel
{
	public PrefabReference displayPath; //Field offset: 0x30
	public float baseTowerRange; //Field offset: 0x38
	public float displayRadius; //Field offset: 0x3C
	public string hideIfAttackPausedId; //Field offset: 0x40

	public LinkDisplayScaleToTowerRangeModel(string name, PrefabReference displayPath, float baseTowerRange, float displayRadius, string hideIfAttackPausedId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

