namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class CarpetBombAbility : AbilityBehavior
{
	public CarpetBombAbility parent; //Field offset: 0x88
	public GameObject targetDisplay; //Field offset: 0x90
	public GameObject expTargetDisplay; //Field offset: 0x98
	public Projectile projectile; //Field offset: 0xA0
	public Projectile expProjectile; //Field offset: 0xA8
	public GameObject bombersPrefab; //Field offset: 0xB0
	public GameObject expBombersPrefab; //Field offset: 0xB8
	public GameObject lineDisplayGreenIndicator; //Field offset: 0xC0
	public GameObject expLineDisplayGreenIndicator; //Field offset: 0xC8
	public GameObject lineDisplayRedIndicator; //Field offset: 0xD0
	public GameObject expLineDisplayRedIndicator; //Field offset: 0xD8
	public GameObject ejectMarkers; //Field offset: 0xE0
	public GameObject expEjectMarkers; //Field offset: 0xE8
	public float bomberDropDelay; //Field offset: 0xF0
	public string expBomberDropDelay; //Field offset: 0xF8
	public float pointSwitchDistance; //Field offset: 0x100
	public string expPointSwitchDistance; //Field offset: 0x108
	public float minPathDistance; //Field offset: 0x110
	public string expMinPathDistance; //Field offset: 0x118
	public float lineDelay; //Field offset: 0x120
	public string expLineDelay; //Field offset: 0x128
	public float dotSpacing; //Field offset: 0x130
	public string expDotSpacing; //Field offset: 0x138
	public float dotOffset; //Field offset: 0x140
	public string expDotOffset; //Field offset: 0x148
	public float numProjectiles; //Field offset: 0x150
	public string expNumProjectiles; //Field offset: 0x158

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 553
	}

	public CarpetBombAbility() { }

	public virtual AbilityBehaviorModel get_Def() { }

	private Vector3[] GetBomberEjectLocations() { }

}

