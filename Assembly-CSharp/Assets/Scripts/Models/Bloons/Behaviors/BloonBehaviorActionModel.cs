namespace Assets.Scripts.Models.Bloons.Behaviors;

public abstract class BloonBehaviorActionModel : BloonBehaviorModel
{
	public string actionId; //Field offset: 0x30

	protected BloonBehaviorActionModel() { }

	protected BloonBehaviorActionModel(string name, string actionId) { }

}

