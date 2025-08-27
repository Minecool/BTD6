namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(ManageMainHudAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ManageMainHudActionModel : EntityActionModel
{
	public ToggleModdifier homeButton; //Field offset: 0x38
	public ToggleModdifier autoStartSetting; //Field offset: 0x3C

	public ManageMainHudActionModel(string name, ToggleModdifier homeButton, ToggleModdifier autoStartSetting) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

