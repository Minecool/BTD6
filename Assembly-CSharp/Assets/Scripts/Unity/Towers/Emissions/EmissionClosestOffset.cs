namespace Assets.Scripts.Unity.Towers.Emissions;

public class EmissionClosestOffset : Emission
{
	public EmissionClosestOffset parent; //Field offset: 0x88
	public bool rotateProjectileWithTower; //Field offset: 0x90
	public string expRotateProjectileWithTower; //Field offset: 0x98
	public int animationOriginState; //Field offset: 0xA0
	public string expAnimationOriginState; //Field offset: 0xA8
	public Effect effect; //Field offset: 0xB0
	public Effect expEffect; //Field offset: 0xB8

	public virtual EmissionModel Def
	{
		 get { } //Length: 373
	}

	public EmissionClosestOffset() { }

	public virtual EmissionModel get_Def() { }

}

