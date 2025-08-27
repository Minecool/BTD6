namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionRotationOffset : EmissionBehavior
{
	public EmissionRotationOffset parent; //Field offset: 0x88
	public int offsetAngle; //Field offset: 0x90
	public string expOffsetAngle; //Field offset: 0x98

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 111
	}

	public EmissionRotationOffset() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

