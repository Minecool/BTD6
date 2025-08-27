namespace Assets.Scripts.Models.Towers.Mods;

public class BloonSpeedModModel : MutatorModModel
{
	public float speedMultiplier; //Field offset: 0x30
	public string tags; //Field offset: 0x38
	private String[] tagsList; //Field offset: 0x40

	public BloonSpeedModModel(string name, float speedMultiplier, string tags) { }

	public virtual Model Clone() { }

	public static bool Intersect(String[] tagsList, String[] tags) { }

	public virtual bool Mutate(BloonModel model, BloonModel unmodded, string target = "") { }

}

