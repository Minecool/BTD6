namespace Assets.Scripts.Models.Map;

public class CoopPlayerIndicatorModel : Model
{
	public DisplayModel displayModel; //Field offset: 0x30

	public CoopPlayerIndicatorModel(DisplayModel displayModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

