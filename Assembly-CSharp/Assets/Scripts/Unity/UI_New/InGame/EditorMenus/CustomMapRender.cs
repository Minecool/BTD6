namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public static class CustomMapRender
{
	[Flags]
	internal enum Options
	{
		None = 0,
		DrawBaseTexture = 1,
		DrawPaths = 2,
		DrawHiddenPaths = 4,
		HighlightPaths = 8,
		DrawAreas = 16,
		DrawHiddenAreas = 32,
		DrawProps = 64,
		DrawStamps = 128,
		Bake = 256,
	}

	public const Options kOptsForSim = 1; //Field offset: 0x0
	public const Options kOptsForThumb = 211; //Field offset: 0x0
	public const Options kOptsForEdit = 247; //Field offset: 0x0
	public const Options kOptsForPlay = 467; //Field offset: 0x0
	public const Options kOptsForPlayRerenderOnRemovableSold = 403; //Field offset: 0x0

}

