namespace Assets.Scripts.Models.Gameplay.Mods;

public class BloonHealthModel : MutatorModModel
{
	public float healthMod; //Field offset: 0x30
	public string bloonTag; //Field offset: 0x38

	public BloonHealthModel(string name, float healthMod, string bloonTag) { }

	[CompilerGenerated]
	private bool <Mutate>b__3_0(BloonModel bloon) { }

	public virtual Model Clone() { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

	public virtual bool Mutate(BloonModel model, BloonModel unmodded, string target = "") { }

}

