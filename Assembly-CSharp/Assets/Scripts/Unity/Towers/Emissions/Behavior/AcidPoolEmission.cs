namespace Assets.Scripts.Unity.Towers.Emissions.Behavior;

public class AcidPoolEmission : EmissionBehavior
{
	public AcidPoolEmission parent; //Field offset: 0x88
	public int alwaysPoolOnCount; //Field offset: 0x90
	public string expAlwaysPoolOnCount; //Field offset: 0x98

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public AcidPoolEmission() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

