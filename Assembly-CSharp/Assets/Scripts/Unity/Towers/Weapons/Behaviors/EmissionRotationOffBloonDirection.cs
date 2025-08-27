namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionRotationOffBloonDirection : EmissionBehavior
{
	public EmissionRotationOffBloonDirection parent; //Field offset: 0x88
	public bool useAirUnitPosition; //Field offset: 0x90
	public string expUseAirUnitPosition; //Field offset: 0x98
	public bool dontSetAfterEmit; //Field offset: 0xA0
	public string expDontSetAfterEmit; //Field offset: 0xA8

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public EmissionRotationOffBloonDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

