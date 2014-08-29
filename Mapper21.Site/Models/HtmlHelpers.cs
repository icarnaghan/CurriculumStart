using System;
using System.Globalization;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

public static class HtmlHelpers
{
    public static IHtmlString RemoveLink(this HtmlHelper htmlHelper, string linkText, string container,
        string deleteElement)
    {
        string js = string.Format("javascript:removeNestedForm(this,'{0}','{1}');return false;", container,
            deleteElement);
        var tb = new TagBuilder("a");
        tb.Attributes.Add("href", "#");
        tb.Attributes.Add("onclick", js);
        tb.InnerHtml = linkText;
        string tag = tb.ToString(TagRenderMode.Normal);
        return MvcHtmlString.Create(tag);
    }

    public static IHtmlString AddLink<TModel>(this HtmlHelper<TModel> htmlHelper, string linkText,
        string containerElement, string counterElement, string collectionProperty, Type nestedType)
    {
        long ticks = DateTime.UtcNow.Ticks;
        object nestedObject = Activator.CreateInstance(nestedType);
        string partial = htmlHelper.EditorFor(x => nestedObject).ToHtmlString().JsEncode();
        partial = partial.Replace("id=\\\"nestedObject", "id=\\\"" + collectionProperty + "_" + ticks + "_");
        partial = partial.Replace("name=\\\"nestedObject", "name=\\\"" + collectionProperty + "[" + ticks + "]");
        string js = string.Format("javascript:addNestedForm('{0}','{1}','{2}','{3}');return false;", containerElement,
            counterElement, ticks, partial);
        var tb = new TagBuilder("a");
        tb.Attributes.Add("href", "#");
        tb.Attributes.Add("onclick", js);
        tb.InnerHtml = linkText;
        string tag = tb.ToString(TagRenderMode.Normal);
        return MvcHtmlString.Create(tag);
    }

    private static string JsEncode(this string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        int i;
        int len = s.Length;
        var sb = new StringBuilder(len + 4);
        string t;
        for (i = 0; i < len; i += 1)
        {
            char c = s[i];
            switch (c)
            {
                case '>':
                case '"':
                case '\\':
                    sb.Append('\\');
                    sb.Append(c);
                    break;
                case '\b':
                    sb.Append("\\b");
                    break;
                case '\t':
                    sb.Append("\\t");
                    break;
                case '\n':
                    break;
                case '\f':
                    sb.Append("\\f");
                    break;
                case '\r':
                    break;
                default:
                    if (c < ' ')
                    {
                        var tmp = new string(c, 1);
                        t = "000" + int.Parse(tmp, NumberStyles.HexNumber);
                        sb.Append("\\u" + t.Substring(t.Length - 4));
                    }
                    else
                    {
                        sb.Append(c);
                    }
                    break;
            }
        }
        return sb.ToString();
    }
}