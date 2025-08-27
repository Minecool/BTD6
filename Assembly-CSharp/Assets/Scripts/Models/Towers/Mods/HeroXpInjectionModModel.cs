namespace Assets.Scripts.Models.Towers.Mods;

public class HeroXpInjectionModModel : MutatorModModel
{
	public int amount; //Field offset: 0x30
	public int levels; //Field offset: 0x34
	public bool subtractHeroCost; //Field offset: 0x38

	public HeroXpInjectionModModel(string name, int amount, int levels, bool subtractHeroCost) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

}

