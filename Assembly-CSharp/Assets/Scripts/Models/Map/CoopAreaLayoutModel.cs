namespace Assets.Scripts.Models.Map;

public class CoopAreaLayoutModel : Model
{
	public readonly CoopAreaModel[] areaModels; //Field offset: 0x30
	public readonly AreaLayoutType areaLayoutType; //Field offset: 0x38

	public CoopAreaLayoutModel(CoopAreaModel[] areaModels, AreaLayoutType areaLayoutType) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

