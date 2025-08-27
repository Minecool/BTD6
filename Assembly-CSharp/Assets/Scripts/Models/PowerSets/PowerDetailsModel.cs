namespace Assets.Scripts.Models.PowerSets;

public class PowerDetailsModel : Model
{
	public string powerId; //Field offset: 0x30
	public int powerIndex; //Field offset: 0x38
	public int powerCount; //Field offset: 0x3C
	public ApplyModModel[] mods; //Field offset: 0x40

	public PowerDetailsModel(string powerId, int powerIndex, int powerCount, ApplyModModel[] mods) { }

	public virtual Model Clone() { }

	public bool IsAvailable() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

