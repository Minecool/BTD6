namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionRotationOffDisplayOnEmit : EmissionBehavior
{
	public EmissionRotationOffDisplayOnEmit parent; //Field offset: 0x88
	public int offsetAngle; //Field offset: 0x90
	public string expOffsetAngle; //Field offset: 0x98

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public EmissionRotationOffDisplayOnEmit() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

