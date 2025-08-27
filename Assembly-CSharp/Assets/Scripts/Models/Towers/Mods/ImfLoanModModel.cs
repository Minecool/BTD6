namespace Assets.Scripts.Models.Towers.Mods;

public class ImfLoanModModel : MutatorModModel
{
	public float additionalLoanAmount; //Field offset: 0x30
	public float interestRateDecreaseAmount; //Field offset: 0x34

	public ImfLoanModModel(string name, float additionalLoanAmount, float interestRateDecreaseAmount) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

