namespace Assets.Scripts.Models.Towers;

public abstract class TowerBehaviorWithAbilityCooldownScaleModel : TowerBehaviorModel
{
	public float abilityCooldownScale; //Field offset: 0x30

	protected TowerBehaviorWithAbilityCooldownScaleModel(string name, float abilityCooldownScale) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

