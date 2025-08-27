namespace Assets.Scripts.Data.Behaviors.Filters;

[CreateAssetMenu(fileName = "FilterBloonsToWithinAngle", menuName = "BTD6/Behaviors/Filters/FilterBloonsToWithinAngle")]
public class FilterBloonsToWithinAngle : Filter
{
	public float originDegrees; //Field offset: 0x30
	public float angleDegrees; //Field offset: 0x34
	public bool useTowerOrigin; //Field offset: 0x38

	public virtual FilterModel Def
	{
		 get { } //Length: 148
	}

	public FilterBloonsToWithinAngle() { }

	public virtual FilterModel get_Def() { }

}

