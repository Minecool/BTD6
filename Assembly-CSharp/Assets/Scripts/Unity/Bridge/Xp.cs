namespace Assets.Scripts.Unity.Bridge;

public class Xp
{
	public float account; //Field offset: 0x10
	public Dictionary<String, Single> towers; //Field offset: 0x18

	public Xp() { }

	public Xp(Xp xp) { }

	public void AddTowerXp(string tower, float xp) { }

	public Xp Drain() { }

}

