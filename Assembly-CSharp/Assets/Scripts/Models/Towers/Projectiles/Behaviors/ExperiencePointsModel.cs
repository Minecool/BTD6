namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(ExperiencePoints), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ExperiencePointsModel : ProjectileBehaviorModel
{
	public float amount; //Field offset: 0x38

	public ExperiencePointsModel(string name, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

