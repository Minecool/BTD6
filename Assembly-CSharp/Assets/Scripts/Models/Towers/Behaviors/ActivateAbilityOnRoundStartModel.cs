namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ActivateAbilityOnRoundStart), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateAbilityOnRoundStartModel : TowerBehaviorModel
{
	public AbilityModel abilityModel; //Field offset: 0x30

	public ActivateAbilityOnRoundStartModel(string name, AbilityModel abilityModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

