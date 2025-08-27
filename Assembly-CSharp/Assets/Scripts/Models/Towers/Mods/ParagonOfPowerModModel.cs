namespace Assets.Scripts.Models.Towers.Mods;

public class ParagonOfPowerModModel : MutatorModModel
{
	public float rateMultiplier; //Field offset: 0x30
	public string buffLocsName; //Field offset: 0x38
	public string buffIconName; //Field offset: 0x40

	public ParagonOfPowerModModel(string name, float rateMultiplier, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

