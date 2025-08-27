namespace Assets.Scripts.Unity.Bridge;

public class PowerToSimulation : Selectable
{
	private UnityToSimulation sim; //Field offset: 0x10
	private bool destroyed; //Field offset: 0x18
	private ObjectId Id; //Field offset: 0x1C
	private string powerId; //Field offset: 0x20
	private Tower powerTower; //Field offset: 0x28
	private Projectile powerProjectile; //Field offset: 0x30
	private bool isPowerTower; //Field offset: 0x38

	public string BaseId
	{
		 get { } //Length: 5
	}

	public virtual ObjectId id
	{
		 get { } //Length: 4
	}

	public bool IsDestroyed
	{
		 get { } //Length: 5
	}

	public Vector3 Position
	{
		 get { } //Length: 215
	}

	public Vector3 SimPosition
	{
		 get { } //Length: 83
	}

	public PowerToSimulation(UnityToSimulation sim, Tower powerTower, string powerId) { }

	public PowerToSimulation(UnityToSimulation sim, Projectile powerProjectile, string powerId) { }

	public void Destroy() { }

	public string get_BaseId() { }

	public virtual ObjectId get_id() { }

	public bool get_IsDestroyed() { }

	public Vector3 get_Position() { }

	public Vector3 get_SimPosition() { }

}

