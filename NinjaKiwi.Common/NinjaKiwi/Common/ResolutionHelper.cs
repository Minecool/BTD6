namespace NinjaKiwi.Common;

public static class ResolutionHelper
{
	public const float ReferenceDpi = 160; //Field offset: 0x0

	public static float DensityPixelRatio
	{
		 get { } //Length: 24
	}

	public static float HeightDp
	{
		 get { } //Length: 66
	}

	private static float ScreenDpi
	{
		private get { } //Length: 7
	}

	public static float SmallestWidthDp
	{
		 get { } //Length: 147
	}

	public static float WidthDp
	{
		 get { } //Length: 66
	}

	[Obsolete("Think really hard about if you want to use this function, you probably want `VariantBootstrap.ActiveResolution` instead", True)]
	public static ResolutionCategory DetermineScreenResolutionCategory() { }

	public static ResolutionCategory DetermineScreenResolutionCategory(float smallestWidthDp, float densityPixelRatio) { }

	public static float get_DensityPixelRatio() { }

	public static float get_HeightDp() { }

	private static float get_ScreenDpi() { }

	public static float get_SmallestWidthDp() { }

	public static float get_WidthDp() { }

	public static float ToDp(int px, float dpi) { }

}

