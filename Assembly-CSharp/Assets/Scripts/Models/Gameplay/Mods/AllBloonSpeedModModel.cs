namespace Assets.Scripts.Models.Gameplay.Mods;

public class AllBloonSpeedModModel : MutatorModModel
{
	public float speedMod; //Field offset: 0x30
	public string bloonTags; //Field offset: 0x38
	private String[] tagsList; //Field offset: 0x40

	public AllBloonSpeedModModel(string name, float speedMod, string bloonTag) { }

	[CompilerGenerated]
	private bool <Mutate>b__4_0(BloonModel bloon) { }

	public virtual Model Clone() { }

	public static bool Intersect(String[] tagsList, String[] tags) { }

	public virtual bool Mutate(GameModel model, GameModel unmodded) { }

	public virtual bool Mutate(BloonModel model, BloonModel unmodded, string target = "") { }

}

