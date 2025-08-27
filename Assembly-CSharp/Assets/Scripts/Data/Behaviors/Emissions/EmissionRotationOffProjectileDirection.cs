namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionRotationOffProjectileDirection", menuName = "BTD6/Behaviors/Emissions/EmissionRotationOffProjectileDirection")]
public class EmissionRotationOffProjectileDirection : EmissionBehavior
{
	public float startingOffset; //Field offset: 0x28
	public float angleInBetween; //Field offset: 0x2C
	public bool alwaysCentre; //Field offset: 0x30

	public virtual EmissionBehaviorModel Def
	{
		 get { } //Length: 148
	}

	public EmissionRotationOffProjectileDirection() { }

	public virtual EmissionBehaviorModel get_Def() { }

}

