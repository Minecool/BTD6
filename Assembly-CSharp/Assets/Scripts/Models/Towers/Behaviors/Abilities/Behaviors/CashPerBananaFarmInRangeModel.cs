namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CashPerBananaFarmInRange), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CashPerBananaFarmInRangeModel : AbilityBehaviorModel
{
	public float baseCash; //Field offset: 0x30
	public float cash; //Field offset: 0x34
	public float rangeIncrease; //Field offset: 0x38
	public PrefabReference textAssetId; //Field offset: 0x40
	public float textLifespan; //Field offset: 0x48

	public CashPerBananaFarmInRangeModel(string name, float baseCash, float cash, float rangeIncrease, PrefabReference textAssetId, float textLifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

