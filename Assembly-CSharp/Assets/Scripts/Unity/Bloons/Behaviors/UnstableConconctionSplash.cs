namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class UnstableConconctionSplash : EmitOnPop
{
	public UnstableConconctionSplash parent; //Field offset: 0xB8
	public float moabBloonDmg; //Field offset: 0xC0
	public string expMoabBloonDmg; //Field offset: 0xC8
	public float bfbBloonDmg; //Field offset: 0xD0
	public string expBfbBloonDmg; //Field offset: 0xD8
	public float zomgBloonDmg; //Field offset: 0xE0
	public string expZomgBloonDmg; //Field offset: 0xE8
	public float otherMoabBloonDmg; //Field offset: 0xF0
	public string expOtherMoabBloonDmg; //Field offset: 0xF8
	public float moabMoabDmg; //Field offset: 0x100
	public string expMoabMoabDmg; //Field offset: 0x108
	public float bfbMoabDmg; //Field offset: 0x110
	public string expBfbMoabDmg; //Field offset: 0x118
	public float zomgMoabDmg; //Field offset: 0x120
	public string expZomgMoabDmg; //Field offset: 0x128
	public float ddtMoabDmg; //Field offset: 0x130
	public string expDdtMoabDmg; //Field offset: 0x138
	public float badMoabDmg; //Field offset: 0x140
	public string expBadMoabDmg; //Field offset: 0x148
	public float bossMoabDmg; //Field offset: 0x150
	public string expBossMoabDmg; //Field offset: 0x158
	public float otherMoabMoabDmg; //Field offset: 0x160
	public string expOtherMoabMoabDmg; //Field offset: 0x168

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 815
	}

	public UnstableConconctionSplash() { }

	public virtual BloonBehaviorModel get_Def() { }

}

