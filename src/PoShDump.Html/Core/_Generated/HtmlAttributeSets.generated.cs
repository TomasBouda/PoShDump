using PoShDump.Html.Core.Attributes;
// ReSharper disable All

namespace PoShDump.Html.Core.Attributes
{
	public class aAttr : HtmlAttribute, IdownloadAttribute, IhrefAttribute, IhreflangAttribute, ImediaAttribute, IpingAttribute, IreferrerpolicyAttribute, IrelAttribute, ItargetAttribute, ItypeAttribute
	{
		public aAttr() { }
		public aAttr(string name, object value) : base(name, value) { }
	}
	public class areaAttr : HtmlAttribute, IaltAttribute, IcoordsAttribute, IdownloadAttribute, IhrefAttribute, IhreflangAttribute, ImediaAttribute, IreferrerpolicyAttribute, IrelAttribute, IshapeAttribute, ItargetAttribute, ItypeAttribute
	{
		public areaAttr() { }
		public areaAttr(string name, object value) : base(name, value) { }
	}
	public class audioAttr : HtmlAttribute, IautoplayAttribute, IcontrolsAttribute, IloopAttribute, ImutedAttribute, IpreloadAttribute, IsrcAttribute
	{
		public audioAttr() { }
		public audioAttr(string name, object value) : base(name, value) { }
	}
	public class @baseAttr : HtmlAttribute, IhrefAttribute, ItargetAttribute
	{
		public @baseAttr() { }
		public @baseAttr(string name, object value) : base(name, value) { }
	}
	public class bdoAttr : HtmlAttribute
		{
		public bdoAttr() { }
		public bdoAttr(string name, object value) : base(name, value) { }
	}
	public class blockquoteAttr : HtmlAttribute, IciteAttribute
	{
		public blockquoteAttr() { }
		public blockquoteAttr(string name, object value) : base(name, value) { }
	}
	public class buttonAttr : HtmlAttribute, IautofocusAttribute, IdisabledAttribute, IformAttribute, IformactionAttribute, IformenctypeAttribute, IformmethodAttribute, IformnovalidateAttribute, IformtargetAttribute, InameAttribute, ItypeAttribute, IvalueAttribute
	{
		public buttonAttr() { }
		public buttonAttr(string name, object value) : base(name, value) { }
	}
	public class canvasAttr : HtmlAttribute, IheightAttribute, IwidthAttribute
	{
		public canvasAttr() { }
		public canvasAttr(string name, object value) : base(name, value) { }
	}
	public class colAttr : HtmlAttribute, IspanAttribute
	{
		public colAttr() { }
		public colAttr(string name, object value) : base(name, value) { }
	}
	public class colgroupAttr : HtmlAttribute, IspanAttribute
	{
		public colgroupAttr() { }
		public colgroupAttr(string name, object value) : base(name, value) { }
	}
	public class dataAttr : HtmlAttribute, IvalueAttribute
	{
		public dataAttr() { }
		public dataAttr(string name, object value) : base(name, value) { }
	}
	public class delAttr : HtmlAttribute, IciteAttribute, IdatetimeAttribute
	{
		public delAttr() { }
		public delAttr(string name, object value) : base(name, value) { }
	}
	public class detailsAttr : HtmlAttribute, IopenAttribute
	{
		public detailsAttr() { }
		public detailsAttr(string name, object value) : base(name, value) { }
	}
	public class dialogAttr : HtmlAttribute, IopenAttribute
	{
		public dialogAttr() { }
		public dialogAttr(string name, object value) : base(name, value) { }
	}
	public class embedAttr : HtmlAttribute, IheightAttribute, IsrcAttribute, ItypeAttribute, IwidthAttribute
	{
		public embedAttr() { }
		public embedAttr(string name, object value) : base(name, value) { }
	}
	public class fieldsetAttr : HtmlAttribute, IdisabledAttribute, IformAttribute, InameAttribute
	{
		public fieldsetAttr() { }
		public fieldsetAttr(string name, object value) : base(name, value) { }
	}
	public class formAttr : HtmlAttribute, Iaccept_charsetAttribute, IactionAttribute, IautocompleteAttribute, IenctypeAttribute, ImethodAttribute, InameAttribute, InovalidateAttribute, IrelAttribute, ItargetAttribute
	{
		public formAttr() { }
		public formAttr(string name, object value) : base(name, value) { }
	}
	public class htmlAttr : HtmlAttribute, IxmlnsAttribute
	{
		public htmlAttr() { }
		public htmlAttr(string name, object value) : base(name, value) { }
	}
	public class iframeAttr : HtmlAttribute, IallowAttribute, IallowfullscreenAttribute, IallowpaymentrequestAttribute, IheightAttribute, IloadingAttribute, InameAttribute, IreferrerpolicyAttribute, IsandboxAttribute, IsrcAttribute, IsrcdocAttribute, IwidthAttribute
	{
		public iframeAttr() { }
		public iframeAttr(string name, object value) : base(name, value) { }
	}
	public class imgAttr : HtmlAttribute, IaltAttribute, IcrossoriginAttribute, IheightAttribute, IismapAttribute, IloadingAttribute, IlongdescAttribute, IreferrerpolicyAttribute, IsizesAttribute, IsrcAttribute, IsrcsetAttribute, IusemapAttribute, IwidthAttribute
	{
		public imgAttr() { }
		public imgAttr(string name, object value) : base(name, value) { }
	}
	public class inputAttr : HtmlAttribute, IacceptAttribute, IaltAttribute, IautocompleteAttribute, IautofocusAttribute, IcheckedAttribute, IdirnameAttribute, IdisabledAttribute, IformAttribute, IformactionAttribute, IformenctypeAttribute, IformmethodAttribute, IformnovalidateAttribute, IformtargetAttribute, IheightAttribute, IlistAttribute, ImaxAttribute, ImaxlengthAttribute, IminAttribute, IminlengthAttribute, ImultipleAttribute, InameAttribute, IpatternAttribute, IplaceholderAttribute, IreadonlyAttribute, IrequiredAttribute, IsizeAttribute, IsrcAttribute, IstepAttribute, ItypeAttribute, IvalueAttribute, IwidthAttribute
	{
		public inputAttr() { }
		public inputAttr(string name, object value) : base(name, value) { }
	}
	public class insAttr : HtmlAttribute, IciteAttribute, IdatetimeAttribute
	{
		public insAttr() { }
		public insAttr(string name, object value) : base(name, value) { }
	}
	public class labelAttr : HtmlAttribute, IforAttribute, IformAttribute
	{
		public labelAttr() { }
		public labelAttr(string name, object value) : base(name, value) { }
	}
	public class liAttr : HtmlAttribute, IvalueAttribute
	{
		public liAttr() { }
		public liAttr(string name, object value) : base(name, value) { }
	}
	public class linkAttr : HtmlAttribute, IcrossoriginAttribute, IhrefAttribute, IhreflangAttribute, ImediaAttribute, IreferrerpolicyAttribute, IrelAttribute, IsizesAttribute, ItypeAttribute
	{
		public linkAttr() { }
		public linkAttr(string name, object value) : base(name, value) { }
	}
	public class mapAttr : HtmlAttribute, InameAttribute
	{
		public mapAttr() { }
		public mapAttr(string name, object value) : base(name, value) { }
	}
	public class metaAttr : HtmlAttribute, IcharsetAttribute, IcontentAttribute, Ihttp_equivAttribute, InameAttribute
	{
		public metaAttr() { }
		public metaAttr(string name, object value) : base(name, value) { }
	}
	public class meterAttr : HtmlAttribute, IformAttribute, IhighAttribute, IlowAttribute, ImaxAttribute, IminAttribute, IoptimumAttribute, IvalueAttribute
	{
		public meterAttr() { }
		public meterAttr(string name, object value) : base(name, value) { }
	}
	public class @objectAttr : HtmlAttribute, IdataAttribute, IformAttribute, IheightAttribute, InameAttribute, ItypeAttribute, ItypemustmatchAttribute, IusemapAttribute, IwidthAttribute
	{
		public @objectAttr() { }
		public @objectAttr(string name, object value) : base(name, value) { }
	}
	public class olAttr : HtmlAttribute, IreversedAttribute, IstartAttribute, ItypeAttribute
	{
		public olAttr() { }
		public olAttr(string name, object value) : base(name, value) { }
	}
	public class optgroupAttr : HtmlAttribute, IdisabledAttribute, IlabelAttribute
	{
		public optgroupAttr() { }
		public optgroupAttr(string name, object value) : base(name, value) { }
	}
	public class optionAttr : HtmlAttribute, IdisabledAttribute, IlabelAttribute, IselectedAttribute, IvalueAttribute
	{
		public optionAttr() { }
		public optionAttr(string name, object value) : base(name, value) { }
	}
	public class outputAttr : HtmlAttribute, IforAttribute, IformAttribute, InameAttribute
	{
		public outputAttr() { }
		public outputAttr(string name, object value) : base(name, value) { }
	}
	public class paramAttr : HtmlAttribute, InameAttribute, IvalueAttribute
	{
		public paramAttr() { }
		public paramAttr(string name, object value) : base(name, value) { }
	}
	public class progressAttr : HtmlAttribute, ImaxAttribute, IvalueAttribute
	{
		public progressAttr() { }
		public progressAttr(string name, object value) : base(name, value) { }
	}
	public class qAttr : HtmlAttribute, IciteAttribute
	{
		public qAttr() { }
		public qAttr(string name, object value) : base(name, value) { }
	}
	public class scriptAttr : HtmlAttribute, IasyncAttribute, IcrossoriginAttribute, IdeferAttribute, IintegrityAttribute, InomoduleAttribute, IreferrerpolicyAttribute, IsrcAttribute, ItypeAttribute
	{
		public scriptAttr() { }
		public scriptAttr(string name, object value) : base(name, value) { }
	}
	public class selectAttr : HtmlAttribute, IautofocusAttribute, IdisabledAttribute, IformAttribute, ImultipleAttribute, InameAttribute, IrequiredAttribute, IsizeAttribute
	{
		public selectAttr() { }
		public selectAttr(string name, object value) : base(name, value) { }
	}
	public class sourceAttr : HtmlAttribute, ImediaAttribute, IsizesAttribute, IsrcAttribute, IsrcsetAttribute, ItypeAttribute
	{
		public sourceAttr() { }
		public sourceAttr(string name, object value) : base(name, value) { }
	}
	public class styleAttr : HtmlAttribute, ImediaAttribute, ItypeAttribute
	{
		public styleAttr() { }
		public styleAttr(string name, object value) : base(name, value) { }
	}
	public class tdAttr : HtmlAttribute, IcolspanAttribute, IheadersAttribute, IrowspanAttribute
	{
		public tdAttr() { }
		public tdAttr(string name, object value) : base(name, value) { }
	}
	public class textareaAttr : HtmlAttribute, IautofocusAttribute, IcolsAttribute, IdirnameAttribute, IdisabledAttribute, IformAttribute, ImaxlengthAttribute, InameAttribute, IplaceholderAttribute, IreadonlyAttribute, IrequiredAttribute, IrowsAttribute, IwrapAttribute
	{
		public textareaAttr() { }
		public textareaAttr(string name, object value) : base(name, value) { }
	}
	public class thAttr : HtmlAttribute, IabbrAttribute, IcolspanAttribute, IheadersAttribute, IrowspanAttribute, IscopeAttribute
	{
		public thAttr() { }
		public thAttr(string name, object value) : base(name, value) { }
	}
	public class timeAttr : HtmlAttribute, IdatetimeAttribute
	{
		public timeAttr() { }
		public timeAttr(string name, object value) : base(name, value) { }
	}
	public class trackAttr : HtmlAttribute, IdefaultAttribute, IkindAttribute, IlabelAttribute, IsrcAttribute, IsrclangAttribute
	{
		public trackAttr() { }
		public trackAttr(string name, object value) : base(name, value) { }
	}
	public class videoAttr : HtmlAttribute, IautoplayAttribute, IcontrolsAttribute, IheightAttribute, IloopAttribute, ImutedAttribute, IposterAttribute, IpreloadAttribute, IsrcAttribute, IwidthAttribute
	{
		public videoAttr() { }
		public videoAttr(string name, object value) : base(name, value) { }
	}
}
