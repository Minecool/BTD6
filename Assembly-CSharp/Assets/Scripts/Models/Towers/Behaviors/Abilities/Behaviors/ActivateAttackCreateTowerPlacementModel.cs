namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(ActivateAttackCreateTowerPlacement), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ActivateAttackCreateTowerPlacementModel : AbilityBehaviorModel
{
	public AttackModel[] attacks; //Field offset: 0x30

	public ActivateAttackCreateTowerPlacementModel(string name, AttackModel[] attacks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

