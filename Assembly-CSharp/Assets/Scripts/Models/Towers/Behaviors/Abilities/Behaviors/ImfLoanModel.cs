namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ImfLoan), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ImfLoanModel : AbilityBehaviorModel
{
	public float amount; //Field offset: 0x30
	public float incomeRecoveryRate; //Field offset: 0x34
	public PrefabReference assetId; //Field offset: 0x38
	public float lifespan; //Field offset: 0x40
	public ImfLoanCollectionModel imfLoanCollection; //Field offset: 0x48

	public ImfLoanModel(string name, float amount, float incomeRecoveryRate, PrefabReference assetId, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

