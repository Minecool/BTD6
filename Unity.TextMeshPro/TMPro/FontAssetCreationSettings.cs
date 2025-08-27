namespace TMPro;

public struct FontAssetCreationSettings
{
	public string sourceFontFileName; //Field offset: 0x0
	public string sourceFontFileGUID; //Field offset: 0x8
	public int faceIndex; //Field offset: 0x10
	public int pointSizeSamplingMode; //Field offset: 0x14
	public int pointSize; //Field offset: 0x18
	public int padding; //Field offset: 0x1C
	public int paddingMode; //Field offset: 0x20
	public int packingMode; //Field offset: 0x24
	public int atlasWidth; //Field offset: 0x28
	public int atlasHeight; //Field offset: 0x2C
	public int characterSetSelectionMode; //Field offset: 0x30
	public string characterSequence; //Field offset: 0x38
	public string referencedFontAssetGUID; //Field offset: 0x40
	public string referencedTextAssetGUID; //Field offset: 0x48
	public int fontStyle; //Field offset: 0x50
	public float fontStyleModifier; //Field offset: 0x54
	public int renderMode; //Field offset: 0x58
	public bool includeFontFeatures; //Field offset: 0x5C

	internal FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }

}

