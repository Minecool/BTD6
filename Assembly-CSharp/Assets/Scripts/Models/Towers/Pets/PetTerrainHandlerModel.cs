namespace Assets.Scripts.Models.Towers.Pets;

[Implementation(typeof(PetTerrainHandler), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetTerrainHandlerModel : PetBehaviorModel
{
	public float LandHeightOffset; //Field offset: 0x30
	public float WaterHeightOffset; //Field offset: 0x34
	public float MoveSpeed; //Field offset: 0x38

	public PetTerrainHandlerModel(string name, float landHeightOffset, float waterHeightOffset, float moveSpeed) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

