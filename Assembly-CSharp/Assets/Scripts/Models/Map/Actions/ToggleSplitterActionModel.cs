namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(ToggleSplitterAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ToggleSplitterActionModel : MapActionModel
{
	public bool setActive; //Field offset: 0x38
	public String[] pathsToActivate; //Field offset: 0x40
	public String[] pathsToDeactivate; //Field offset: 0x48

	public ToggleSplitterActionModel(string name, bool setActive, String[] pathsToActivate, String[] pathsToDeactivate) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

