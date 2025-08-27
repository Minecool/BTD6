namespace Assets.Scripts.Data.AnimCurves;

public class AnimCurveData
{
	public string id; //Field offset: 0x10
	public AnimationCurve curvePosX; //Field offset: 0x18
	public AnimationCurve curvePosY; //Field offset: 0x20
	public AnimationCurve curvePosZ; //Field offset: 0x28
	public AnimationCurve curveScale; //Field offset: 0x30

	public AnimCurveData() { }

}

