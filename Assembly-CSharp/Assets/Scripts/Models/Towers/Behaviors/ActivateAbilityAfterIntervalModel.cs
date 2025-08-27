namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ActivateAbilityAfterInterval), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateAbilityAfterIntervalModel : TowerBehaviorModel
{
	public AbilityModel abilityModel; //Field offset: 0x30
	[SerializeField]
	private float interval; //Field offset: 0x38
	public int intervalFrames; //Field offset: 0x3C

	public ActivateAbilityAfterIntervalModel(string name, AbilityModel abilityModel, float interval) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

