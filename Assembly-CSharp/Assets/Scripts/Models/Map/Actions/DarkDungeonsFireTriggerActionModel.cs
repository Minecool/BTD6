namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(DarkDungeonsFireTriggerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DarkDungeonsFireTriggerActionModel : MapActionModel
{
	public DarkDungeonsStatueModel statue; //Field offset: 0x38
	public DarkDungeonsFire fire; //Field offset: 0x40
	public float activationDuration; //Field offset: 0x44

	public DarkDungeonsFireTriggerActionModel(string name, DarkDungeonsStatueModel statue, DarkDungeonsFire fire, float activationDuration) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

