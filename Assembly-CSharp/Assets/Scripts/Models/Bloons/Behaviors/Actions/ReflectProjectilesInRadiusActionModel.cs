namespace Assets.Scripts.Models.Bloons.Behaviors.Actions;

[Implementation(typeof(ReflectProjectilesInRadiusAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ReflectProjectilesInRadiusActionModel : BloonBehaviorActionModel
{
	public float lifespan; //Field offset: 0x38
	public float innerRadius; //Field offset: 0x3C
	public float outerRadius; //Field offset: 0x40
	public float reflectionDamper; //Field offset: 0x44

	public ReflectProjectilesInRadiusActionModel() { }

	public ReflectProjectilesInRadiusActionModel(string name, string actionId, float lifespan, float innerRadius, float outerRadius, float reflectionDamper) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

