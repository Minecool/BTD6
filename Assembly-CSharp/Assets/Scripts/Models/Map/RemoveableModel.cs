namespace Assets.Scripts.Models.Map;

[Implementation(typeof(Removeable), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemoveableModel : Model
{
	public readonly bool isActive; //Field offset: 0x30
	public readonly AreaType defaultType; //Field offset: 0x34
	public readonly string objecName; //Field offset: 0x38
	public readonly string menuName; //Field offset: 0x40
	public readonly string textKey; //Field offset: 0x48
	public readonly string menuDescription; //Field offset: 0x50
	public int removealCost; //Field offset: 0x58
	public readonly Vector3 position; //Field offset: 0x5C
	public readonly bool denySellIfStackedTowers; //Field offset: 0x68
	public readonly bool destroyArea; //Field offset: 0x69
	public readonly string modPathId; //Field offset: 0x70
	public readonly Nullable<Single> modPathBloonHeightOffset; //Field offset: 0x78
	public readonly Nullable<Single> modPathMoabHeightOffset; //Field offset: 0x80
	public readonly Nullable<Single> modPathBloonScale; //Field offset: 0x88
	public readonly Nullable<Single> modPathMoabScale; //Field offset: 0x90
	public readonly Nullable<Boolean> modPathBloonInvulnerability; //Field offset: 0x98
	public readonly Nullable<Boolean> modPathMoabInvulnerability; //Field offset: 0x9A
	public List<ObjectId> ids; //Field offset: 0xA0

	public RemoveableModel(string name, string objecName, bool isActive, AreaType defaultType, int removealCost, string menuName, string menuDescription, Vector3 position, bool denySellIfStackedTowers, bool destroyArea, string textKey, string modPathId, Nullable<Single> modPathBloonHeightOffset, Nullable<Single> modPathMoabHeightOffset, Nullable<Single> modPathBloonScale, Nullable<Single> modPathMoabScale, Nullable<Boolean> modPathBloonInvulnerability, Nullable<Boolean> modPathMoabInvulnerability) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

