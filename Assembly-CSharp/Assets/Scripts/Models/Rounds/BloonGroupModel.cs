namespace Assets.Scripts.Models.Rounds;

public class BloonGroupModel : Model
{
	public string bloon; //Field offset: 0x30
	public float start; //Field offset: 0x38
	public float end; //Field offset: 0x3C
	public int count; //Field offset: 0x40

	public BloonGroupModel(string name, string bloon, float start, float end, int count) { }

	public virtual Model Clone() { }

	public BloonEmissionModel[] GetEmissions() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

