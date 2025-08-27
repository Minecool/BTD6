namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(ToggleTowerUpgradeScreenAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ToggleTowerUpgradeScreenActionModel : EntityActionModel
{
	public string tower; //Field offset: 0x38
	public ToggleModdifier toggleModifier; //Field offset: 0x40

	public ToggleTowerUpgradeScreenActionModel(string name, string tower, ToggleModdifier toggleModifier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

