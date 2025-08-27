namespace Assets.Scripts.Models.Towers.Mods;

public class ComeOnEverybodyModModel : MutatorModModel
{
	public float discountMultiplier; //Field offset: 0x30
	public float rateMultiplier; //Field offset: 0x34
	public string buffLocsNameRate; //Field offset: 0x38
	public string buffIconNameRate; //Field offset: 0x40
	public string buffLocsNamePrice; //Field offset: 0x48
	public string buffIconNamePrice; //Field offset: 0x50

	public ComeOnEverybodyModModel(string name, float discountMultiplier, float rateMultiplier, string buffLocsNameRate, string buffIconNameRate, string buffLocsNamePrice, string buffIconNamePrice) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

