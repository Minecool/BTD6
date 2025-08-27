namespace Assets.Scripts.Data.Behaviors.Emissions;

[CreateAssetMenu(fileName = "EmissionClosestOffset", menuName = "BTD6/Behaviors/Emissions/EmissionClosestOffset")]
public class EmissionClosestOffset : Emission
{
	public bool rotateProjectileWithTower; //Field offset: 0x30
	public int animationOriginState; //Field offset: 0x34
	public Effect effect; //Field offset: 0x38
	public ThrowMarkerOffset[] throwMarkerOffsets; //Field offset: 0x40

	public virtual EmissionModel Def
	{
		 get { } //Length: 320
	}

	public EmissionClosestOffset() { }

	public virtual EmissionModel get_Def() { }

}

