namespace Assets.Scripts.Data.AnimCurves;

public class AnimCurve : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetAnimCurveData>b__0(AnimCurveData x) { }

	}

	[ReorderableList("items", True)]
	[SerializeField]
	private AnimCurveContainer list; //Field offset: 0x18

	public AnimCurveData[] curves
	{
		 get { } //Length: 27
	}

	public AnimCurve() { }

	public AnimCurveData[] get_curves() { }

	public AnimCurveData GetAnimCurveData(string id) { }

}

