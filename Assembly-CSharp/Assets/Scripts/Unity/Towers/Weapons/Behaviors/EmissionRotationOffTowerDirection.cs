namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionRotationOffTowerDirection : EmissionBehavior
{
	public EmissionRotationOffTowerDirection parent; //Field offset: 0x88
	public int offsetAngle; //Field offset: 0x90
	public string expOffsetAngle; //Field offset: 0x98

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public EmissionRotationOffTowerDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

