namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(HealBloonAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HealBloonActionModel : BloonBehaviorActionModel
{
	public float healPercent; //Field offset: 0x38
	public float healAdditive; //Field offset: 0x3C

	public HealBloonActionModel() { }

	public HealBloonActionModel(string name, float healPercent, float healAdditive, string actionId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

