namespace Assets.Scripts.Models.Towers.Behaviors.Emissions;

[Implementation(typeof(RandomEmission), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomEmissionModel : EmissionModel
{
	public float angle; //Field offset: 0x38
	public int count; //Field offset: 0x3C
	public float startOffset; //Field offset: 0x40
	public bool useSpeedMultiplier; //Field offset: 0x44
	public float speedMultiplierMin; //Field offset: 0x48
	public float speedMultiplierMax; //Field offset: 0x4C
	public float ejectPointRandomness; //Field offset: 0x50
	public bool useMainAttackRotation; //Field offset: 0x54

	public RandomEmissionModel(string name, int count, float angle, float startOffset, EmissionBehaviorModel[] behaviors, bool useSpeedMultiplier, float speedMultiplierMin, float speedMultiplierMax, float ejectPointRandomness, bool useMainAttackRotation) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

