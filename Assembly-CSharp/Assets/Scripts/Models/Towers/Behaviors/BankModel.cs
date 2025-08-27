namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(Bank), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BankModel : TowerBehaviorModel
{
	public float capacity; //Field offset: 0x30
	public float interest; //Field offset: 0x34
	public PrefabReference assetId; //Field offset: 0x38
	public PrefabReference fullBankAssetId; //Field offset: 0x40
	public float lifespan; //Field offset: 0x48
	public bool autoCollect; //Field offset: 0x4C
	public int collectAnimation; //Field offset: 0x50

	public BankModel(string name, float capacity, float interest, PrefabReference assetId, PrefabReference fullBankAssetId, float lifespan, bool autoCollect, int collectAnimation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

