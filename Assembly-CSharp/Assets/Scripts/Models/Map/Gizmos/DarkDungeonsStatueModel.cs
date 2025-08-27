namespace Assets.Scripts.Models.Map.Gizmos;

[Implementation(typeof(DarkDungeonsStatue), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DarkDungeonsStatueModel : MapGizmoBehaviorModel
{
	public int cost; //Field offset: 0x38
	public MapActionModel createTowerModel; //Field offset: 0x40
	public DarkDungeonsStatueActiveTriggerModel statueActiveTriggerModel; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler<FireActivatedEventArgs> OnFireActivated; //Field offset: 0x50

	public event EventHandler<FireActivatedEventArgs> OnFireActivated
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public DarkDungeonsStatueModel(string name, int cost, MapActionModel createTowerModel, DarkDungeonsStatueActiveTriggerModel statueActiveTriggerModel) { }

	[CompilerGenerated]
	public void add_OnFireActivated(EventHandler<FireActivatedEventArgs> value) { }

	public virtual Model Clone() { }

	public void FireActivated(DarkDungeonsFire fire, float duration) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	[CompilerGenerated]
	public void remove_OnFireActivated(EventHandler<FireActivatedEventArgs> value) { }

}

