namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(DestroyBloonsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyBloonsActionModel : EntityActionModel
{
	public float range; //Field offset: 0x38
	public String[] bloonIds; //Field offset: 0x40
	public bool camoOnly; //Field offset: 0x48
	public bool regrowOnly; //Field offset: 0x49
	public bool fortifiedOnly; //Field offset: 0x4A
	public bool moabOnly; //Field offset: 0x4B
	public bool inverseChecks; //Field offset: 0x4C

	public DestroyBloonsActionModel(string name, float range, String[] bloonIds, bool camoOnly, bool regrowOnly, bool fortifiedOnly, bool moabOnly, bool inverseChecks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

