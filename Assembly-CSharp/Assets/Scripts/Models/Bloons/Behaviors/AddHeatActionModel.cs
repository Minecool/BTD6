namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(AddHeatAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddHeatActionModel : BloonBehaviorActionModel
{
	public float heatPercent; //Field offset: 0x38

	public AddHeatActionModel() { }

	public AddHeatActionModel(string name, float healPercent, string actionId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

