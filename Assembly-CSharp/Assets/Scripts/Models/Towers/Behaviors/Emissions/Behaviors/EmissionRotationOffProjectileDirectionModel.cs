namespace Assets.Scripts.Models.Towers.Behaviors.Emissions.Behaviors;

[Implementation(typeof(EmissionRotationOffProjectileDirection), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EmissionRotationOffProjectileDirectionModel : EmissionBehaviorModel
{
	public float startingOffset; //Field offset: 0x30
	public float angleInBetween; //Field offset: 0x34
	public bool alwaysCentre; //Field offset: 0x38

	public EmissionRotationOffProjectileDirectionModel(string name, float startingOffset, float angleInBetween, bool alwaysCentre) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

