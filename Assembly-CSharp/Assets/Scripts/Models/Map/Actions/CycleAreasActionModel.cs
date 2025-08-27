namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(CycleAreasAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CycleAreasActionModel : MapActionModel
{
	public String[] areaNames; //Field offset: 0x38
	public bool invert; //Field offset: 0x40
	public bool fromStartingRound; //Field offset: 0x41
	public int roundsPerRotate; //Field offset: 0x44

	public CycleAreasActionModel(string name, String[] areaNames, bool invert, bool fromStartingRound, int roundsPerRotate) { }

}

