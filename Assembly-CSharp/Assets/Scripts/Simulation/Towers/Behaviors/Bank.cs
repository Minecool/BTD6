namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class Bank : TowerBehavior
{
	public BankModel bankModel; //Field offset: 0x68
	private bool displayedFull; //Field offset: 0x70
	private Entity fullEffect; //Field offset: 0x78
	private float cash; //Field offset: 0x80
	public float depositedCash; //Field offset: 0x84
	public float calculateInterestFrom; //Field offset: 0x88

	public float Cash
	{
		 get { } //Length: 9
		 set { } //Length: 361
	}

	public bool IsAtMaxCapacity
	{
		 get { } //Length: 38
	}

	public Bank() { }

	public virtual void Attatched() { }

	public float Collect() { }

	public void DepositCash(float amount) { }

	private void DisplayFull() { }

	public float get_Cash() { }

	public bool get_IsAtMaxCapacity() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PayInterest(int round) { }

	private void RemoveFullDisplay() { }

	public void set_Cash(float value) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

