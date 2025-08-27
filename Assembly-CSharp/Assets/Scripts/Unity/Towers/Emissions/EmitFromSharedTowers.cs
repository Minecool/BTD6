namespace Assets.Scripts.Unity.Towers.Emissions;

public class EmitFromSharedTowers : Emission
{
	public EmitFromSharedTowers parent; //Field offset: 0x88
	public bool isUsingSharedRange; //Field offset: 0x90
	public string expIsUsingSharedRange; //Field offset: 0x98
	public string sharedRangeTowerTypes; //Field offset: 0xA0
	public string expSharedRangeTowerTypes; //Field offset: 0xA8

	public virtual EmissionModel Def
	{
		 get { } //Length: 264
	}

	public EmitFromSharedTowers() { }

	public virtual EmissionModel get_Def() { }

}

