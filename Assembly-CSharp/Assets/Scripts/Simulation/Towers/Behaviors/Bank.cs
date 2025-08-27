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
		 set { } //Length: 358
	}

	public Bank() { }

	public virtual void Attatched() { }

	public void Collect() { }

	public void DepositCash(float amount) { }

	private void DisplayFull() { }

	public float get_Cash() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void PayInterest(int round) { }

	private void RemoveFullDisplay() { }

	public void set_Cash(float value) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

