namespace Assets.Scripts.Simulation.SimulationBehaviors;

public class ImfLoanCollection : SimulationBehavior
{
	private float collected; //Field offset: 0x58
	public ImfLoanCollectionModel imfLoanCollectionModel; //Field offset: 0x60
	public ObjectId towerId; //Field offset: 0x68
	public int inputId; //Field offset: 0x6C

	public ImfLoanCollection() { }

	public virtual double AddCashTransform(double amount, CashType from, CashSource source) { }

	public float GetCollectedAmount() { }

	public float GetCollectionRate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void SetCollectedAmount(float amount) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

