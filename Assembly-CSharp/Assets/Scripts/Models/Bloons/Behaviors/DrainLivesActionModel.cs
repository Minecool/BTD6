namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DrainLivesAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DrainLivesActionModel : BloonBehaviorActionModel
{
	public int livesDrained; //Field offset: 0x38
	public PrefabReference display; //Field offset: 0x40
	public float displayLifespan; //Field offset: 0x48

	public DrainLivesActionModel() { }

	public DrainLivesActionModel(string name, string actionId, int livesDrained, PrefabReference display, float displayLifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

