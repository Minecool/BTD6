namespace Assets.Scripts.Models.Towers.Behaviors.Attack.Behaviors;

[Implementation(typeof(RandomPositionBasic), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RandomPositionBasicModel : TargetSupplierModel
{
	public float minRadius; //Field offset: 0x38
	public float maxRadius; //Field offset: 0x3C
	public float mapBorder; //Field offset: 0x40
	public bool useTerrainHeight; //Field offset: 0x44

	public RandomPositionBasicModel(string name, float minRadius, float maxRadius, float mapBorder, bool useTerrainHeight) { }

	public virtual Model Clone() { }

	public virtual bool GetIsActionable() { }

	public virtual string GetName() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public virtual bool IsSelectable() { }

}

