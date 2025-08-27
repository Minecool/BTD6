namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(ShowGlowOnTowerButtonAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ShowGlowOnTowerButtonActionModel : EntityActionModel
{
	[TowerType]
	public string tower; //Field offset: 0x38
	public ToggleModdifier showGlowOnTowerButton; //Field offset: 0x40

	public ShowGlowOnTowerButtonActionModel(string name, string tower, ToggleModdifier showGlowOnTowerButton) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

