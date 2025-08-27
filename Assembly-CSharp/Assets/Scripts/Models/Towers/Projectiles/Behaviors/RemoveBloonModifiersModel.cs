namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(RemoveBloonModifiers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveBloonModifiersModel : ProjectileBehaviorModel
{
	public bool cleanseRegen; //Field offset: 0x38
	public bool cleanseCamo; //Field offset: 0x39
	public bool cleanseLead; //Field offset: 0x3A
	public bool cleanseFortified; //Field offset: 0x3B
	public bool cleanseOnlyIfDamaged; //Field offset: 0x3C
	public String[] bloonTagExcludeList; //Field offset: 0x40
	public String[] bloonTagExplicitList; //Field offset: 0x48

	public RemoveBloonModifiersModel(string name, bool cleanseRegen, bool cleanseCamo, bool cleanseLead, bool cleanseFortified, bool cleanseOnlyIfDamaged, String[] bloonTagExcludeList, String[] bloonTagExplicitList) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

