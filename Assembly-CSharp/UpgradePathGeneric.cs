//Type is in global namespace

public abstract class UpgradePathGeneric : MonoBehaviour
{
	private Upgradeable last; //Field offset: 0x20
	private MonoBehaviour lastUpgrade; //Field offset: 0x28
	private Cache<Upgradeable> _cache; //Field offset: 0x30

	public Cache<Upgradeable> Cache
	{
		 get { } //Length: 192
	}

	public bool IsWeak
	{
		 get { } //Length: 101
	}

	protected UpgradePathGeneric() { }

	public override Upgradeable Get(bool bust = false) { }

	public Cache<Upgradeable> get_Cache() { }

	public bool get_IsWeak() { }

	private Upgradeable GetForCache() { }

	public string GetName() { }

	public abstract Upgradeable GetSolid() { }

	public abstract MonoBehaviour GetUpgrade() { }

	public override List<String> GetUpgrades() { }

	public GenericVariable[] GetVariables() { }

	private Upgradeable GetWeak() { }

	public bool IsValid() { }

	private void Update() { }

}

