namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(AddHeatToBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddHeatToBloonModel : ProjectileBehaviorModel
{
	public float heatAmount; //Field offset: 0x38

	public AddHeatToBloonModel(string name, float heatAmount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

