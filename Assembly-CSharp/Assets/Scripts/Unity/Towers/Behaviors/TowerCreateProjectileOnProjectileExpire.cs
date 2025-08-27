namespace Assets.Scripts.Unity.Towers.Behaviors;

public class TowerCreateProjectileOnProjectileExpire : TowerBehavior
{
	public TowerCreateProjectileOnProjectileExpire parent; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public Emission emission; //Field offset: 0xB0
	public Emission expEmission; //Field offset: 0xB8
	public Effect effect; //Field offset: 0xC0
	public Effect expEffect; //Field offset: 0xC8
	public string dontAddIfScriptsExists; //Field offset: 0xD0
	public string expDontAddIfScriptsExists; //Field offset: 0xD8
	public string onlyAddIfScriptsExists; //Field offset: 0xE0
	public string expOnlyAddIfScriptsExists; //Field offset: 0xE8
	public bool useChance; //Field offset: 0xF0
	public string expUseChance; //Field offset: 0xF8
	public float chance; //Field offset: 0x100
	public string expChance; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 415
	}

	public TowerCreateProjectileOnProjectileExpire() { }

	public virtual TowerBehaviorModel get_Def() { }

}

