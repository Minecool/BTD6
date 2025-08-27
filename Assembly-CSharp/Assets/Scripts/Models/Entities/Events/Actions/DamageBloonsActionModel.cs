namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(DamageBloonsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageBloonsActionModel : EntityActionModel
{
	public int damage; //Field offset: 0x38
	public float range; //Field offset: 0x3C
	public String[] bloonIds; //Field offset: 0x40
	public bool camoOnly; //Field offset: 0x48
	public bool regrowOnly; //Field offset: 0x49
	public bool fortifiedOnly; //Field offset: 0x4A
	public bool moabOnly; //Field offset: 0x4B
	public bool inverseChecks; //Field offset: 0x4C

	public DamageBloonsActionModel(string name, int damage, float range, String[] bloonIds, bool camoOnly, bool regrowOnly, bool fortifiedOnly, bool moabOnly, bool inverseChecks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

