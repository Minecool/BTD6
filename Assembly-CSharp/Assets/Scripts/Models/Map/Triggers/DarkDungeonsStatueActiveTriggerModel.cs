namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(DarkDungeonsStatueActiveTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DarkDungeonsStatueActiveTriggerModel : MapTriggerModel
{
	[CompilerGenerated]
	private EventHandler onActive; //Field offset: 0x38

	public event EventHandler onActive
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public DarkDungeonsStatueActiveTriggerModel(string name) { }

	[CompilerGenerated]
	public void add_onActive(EventHandler value) { }

	[CompilerGenerated]
	public void remove_onActive(EventHandler value) { }

	public void TriggerActive() { }

}

