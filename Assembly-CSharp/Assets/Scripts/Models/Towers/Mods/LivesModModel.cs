namespace Assets.Scripts.Models.Towers.Mods;

public class LivesModModel : MutatorModModel
{
	public float percentBonus; //Field offset: 0x30

	public LivesModModel(string name, float percentBonus) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(TowerModel model, TowerModel unmodded, string target = "") { }

}

