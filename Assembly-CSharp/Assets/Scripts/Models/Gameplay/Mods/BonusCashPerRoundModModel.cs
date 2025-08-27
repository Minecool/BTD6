namespace Assets.Scripts.Models.Gameplay.Mods;

public class BonusCashPerRoundModModel : MutatorModModel
{
	public float roundMultiple; //Field offset: 0x30
	public float baseCash; //Field offset: 0x34

	public BonusCashPerRoundModModel(string name, float roundMultiple, float baseCash) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

