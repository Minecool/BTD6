namespace Assets.Scripts.Unity.Towers.Filters;

public class FilterBloonsToWithinAngle : Filter
{
	public FilterBloonsToWithinAngle parent; //Field offset: 0x88
	public float originDegrees; //Field offset: 0x90
	public string expOriginDegrees; //Field offset: 0x98
	public float angleDegrees; //Field offset: 0xA0
	public string expAngleDegrees; //Field offset: 0xA8
	public bool useTowerOrigin; //Field offset: 0xB0
	public string expUseTowerOrigin; //Field offset: 0xB8

	public virtual FilterModel Def
	{
		 get { } //Length: 157
	}

	public FilterBloonsToWithinAngle() { }

	public virtual FilterModel get_Def() { }

}

