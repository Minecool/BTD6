namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CollectCashZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CollectCashZoneModel : TowerBehaviorModel
{
	public float attractRange; //Field offset: 0x30
	public float collectRange; //Field offset: 0x34
	public float lerpMultiplier; //Field offset: 0x38
	public string towerFilter; //Field offset: 0x40
	public bool useTowerRange; //Field offset: 0x48
	public bool countCollectedCash; //Field offset: 0x49
	public bool animateTower; //Field offset: 0x4A
	public bool rotate; //Field offset: 0x4B
	public bool onlyAttractsCamo; //Field offset: 0x4C
	public float minEmitWaitTime; //Field offset: 0x50
	public int minEmitWaitTimeFrames; //Field offset: 0x54

	public CollectCashZoneModel(string name, float attractRange, float collectRange, float lerpMultiplier, string towerFilter, bool useTowerRange, bool countCollectedCash, bool animateTower, bool rotate, bool onlyAttractsCamo, float minEmitWaitTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

