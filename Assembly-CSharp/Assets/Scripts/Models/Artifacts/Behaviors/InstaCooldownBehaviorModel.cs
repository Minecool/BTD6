namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(InstaCooldownBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class InstaCooldownBehaviorModel : ItemArtifactBehaviorModel
{
	public string towerType; //Field offset: 0x30
	public int addedCooldown; //Field offset: 0x38

	private InstaCooldownBehaviorModel(string name, string towerType, int addedCooldown) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

