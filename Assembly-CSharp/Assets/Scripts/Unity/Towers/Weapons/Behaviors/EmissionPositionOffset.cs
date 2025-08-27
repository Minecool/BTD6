namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionPositionOffset : EmissionBehavior
{
	public EmissionPositionOffset parent; //Field offset: 0x88
	public float minOffset; //Field offset: 0x90
	public string expMinOffset; //Field offset: 0x98
	public float maxOffset; //Field offset: 0xA0
	public string expMaxOffset; //Field offset: 0xA8
	public float yOffset; //Field offset: 0xB0
	public string expYOffset; //Field offset: 0xB8

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 164
	}

	public EmissionPositionOffset() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

