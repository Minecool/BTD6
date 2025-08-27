namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionRotationOffDisplay : EmissionBehavior
{
	public EmissionRotationOffDisplay parent; //Field offset: 0x88
	public int offsetAngle; //Field offset: 0x90
	public string expOffsetAngle; //Field offset: 0x98

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public EmissionRotationOffDisplay() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

