namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(ImfLoanCollection), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ImfLoanCollectionModel : SimulationBehaviorModel
{
	public float collectionRate; //Field offset: 0x30
	public float amount; //Field offset: 0x34

	public ImfLoanCollectionModel(string name, float collectionRate, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

