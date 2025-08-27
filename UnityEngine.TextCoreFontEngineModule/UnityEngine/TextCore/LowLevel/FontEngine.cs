namespace UnityEngine.TextCore.LowLevel;

[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
public sealed class FontEngine
{
	private static Glyph[] s_Glyphs; //Field offset: 0x0
	private static UInt32[] s_GlyphIndexes_MarshallingArray_A; //Field offset: 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; //Field offset: 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; //Field offset: 0x18
	private static GlyphRect[] s_FreeGlyphRects; //Field offset: 0x20
	private static GlyphRect[] s_UsedGlyphRects; //Field offset: 0x28
	private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray; //Field offset: 0x30
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; //Field offset: 0x38
	private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray; //Field offset: 0x40
	private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray; //Field offset: 0x48
	private static Dictionary<UInt32, Glyph> s_GlyphLookupDictionary; //Field offset: 0x50

	private static FontEngine() { }

	private static void GenericListToMarshallingArray(ref List<T>& srcList, ref T[] dstArray) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllLigatureSubstitutionRecords", IsThreadSafe = True, IsFreeFunction = True)]
	internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToBaseAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToMarkAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllPairAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords() { }

	public static FaceInfo GetFaceInfo() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = True, IsFreeFunction = True)]
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	public static String[] GetFontFaces() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFontFaces", IsThreadSafe = True, IsFreeFunction = True)]
	private static String[] GetFontFaces_Internal() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	internal static uint GetGlyphIndex(uint unicode) { }

	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<UInt32> glyphIndexes, out int recordCount) { }

	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(UInt32[] glyphIndexes) { }

	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(List<UInt32> glyphIndexes) { }

	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetLigatureSubstitutionRecordsFromMarshallingArray(out LigatureSubstitutionRecord[] ligatureSubstitutionRecords) { }

	private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(UInt32[] glyphIndexes) { }

	internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(out MarkToBaseAdjustmentRecord[] adjustmentRecords) { }

	internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(List<UInt32> glyphIndexes) { }

	private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(UInt32[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(out MarkToMarkAdjustmentRecord[] adjustmentRecords) { }

	private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(UInt32[] glyphIndexes) { }

	internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetPairAdjustmentRecordsFromMarshallingArray(out GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetVariantGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode) { }

	private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref UInt32[] dstArray) { }

	public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	public static FontEngineError LoadFontFace(string filePath) { }

	public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_Internal(string filePath) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulateLigatureSubstitutionRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulatePairAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = True)]
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(UInt32[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = True)]
	internal static void ResetAtlasTexture(Texture2D texture) { }

	private static void SetMarshallingArraySize(ref T[] marshallingArray, int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = True, IsFreeFunction = True)]
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	internal static bool TryAddGlyphsToTexture(List<UInt32> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	public static FontEngineError UnloadFontFace() { }

	[NativeMethod(Name = "TextCore::FontEngine::UnloadFontFace", IsFreeFunction = True)]
	private static int UnloadFontFace_Internal() { }

}

