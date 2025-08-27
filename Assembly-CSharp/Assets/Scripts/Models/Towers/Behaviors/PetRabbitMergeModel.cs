namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(PetRabbitMerge), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetRabbitMergeModel : TowerBehaviorModel
{
	public string wererabbitTowerId; //Field offset: 0x30
	public int mergeAmountRequired; //Field offset: 0x38
	public PrefabReference effectDuringMergeId; //Field offset: 0x40

	public PetRabbitMergeModel(string name, string wererabbitTowerId, int mergeAmountRequired, PrefabReference effectDuringMergeId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

