namespace Assets.Scripts.Data.MapEditor;

[Flags]
public enum MapEditorItemTag
{
	Halloween = 1,
	Christmas = 2,
	Easter = 4,
	Meadow = 256,
	Swamp = 512,
	Ocean = 1024,
	Desert = 2048,
	Snow = 4096,
	Forest = 8192,
	Plains = 16384,
	Urban = 32768,
	Candy = 65536,
	Spring = 131072,
	Tree = 16777216,
	Shrub = 33554432,
	Fence = 67108864,
	Building = 134217728,
	Decoration = 268435456,
	Critter = 536870912,
	Pet = 1073741824,
	Effect = 2147483648,
	Plant = 4294967296,
	Rock = 8589934592,
	Platform = 17179869184,
	Blocking = 34359738368,
	Interactable = 68719476736,
	Quest = 137438953472,
	Removeable = 274877906944,
	ActionProp = 549755813888,
	CustomProp = 1099511627776,
}

