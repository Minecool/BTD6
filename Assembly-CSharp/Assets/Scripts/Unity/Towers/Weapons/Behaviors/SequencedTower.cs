namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class SequencedTower : WeaponBehavior
{
	public SequencedTower parent; //Field offset: 0x90
	public Tower tower; //Field offset: 0x98
	public Tower expTower; //Field offset: 0xA0
	public GameObject display; //Field offset: 0xA8
	public GameObject expDisplay; //Field offset: 0xB0

	public SequencedTower() { }

}

