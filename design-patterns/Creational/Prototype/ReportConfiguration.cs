using System;
namespace design_patterns.Creational.Prototype
{
	public class ReportConfiguration : ICopyable
	{
	    int _fontSize;
		string _fontFace;
		bool _includeHeader;

		public ReportConfiguration(int fontSize, string fontFace, bool includeHeader)
		{
			_fontSize = fontSize;
			_fontFace = fontFace;
			_includeHeader = includeHeader;
		}

		public void SetFont(string fontFace)
		{
            _fontFace = fontFace; 
        }

		public ICopyable Copy()
        {
			return new ReportConfiguration(_fontSize, _fontFace, _includeHeader);
        }

		public string GetConfigInfo()
		{
			return $"Font face: {_fontFace},\nFont size: {_fontSize},\nInclude Headers: {_includeHeader}";
		}
    }
}

