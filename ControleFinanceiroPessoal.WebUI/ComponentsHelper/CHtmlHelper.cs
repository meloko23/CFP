using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControleFinanceiroPessoal.WebUI.ComponentsHelper {
    public static class CHtmlHelper {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Class"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static MvcHtmlString ActionLinkButton(string target, string Class, string text, string title = null, string id = null, string name = null) {
            
            if (String.IsNullOrEmpty(title)) {
                title = text;
            }

            return MvcHtmlString.Create(String.Format("<a href='{0}' type='button' class='{1}' title='{3}' id='{4}' name='{5}'>" +
                                                      "{2}" +
                                                      "</a>", target, Class, text, title, id, name));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Class"></param>
        /// <param name="iconClass"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static MvcHtmlString ActionLinkButtonIcon(string target, string Class, string iconClass, string text, string title = null, string id = null, string name = null) {

            if (String.IsNullOrEmpty(title)) {
                title = text;
            }

            return MvcHtmlString.Create(String.Format("<a href='{0}' type='button' class='{1}' title='{4}' id='{5}' name='{6}'>" +
                                                      "<span class='glyphicon {2}'></span> {3}" +
                                                      "</a>", target, Class, iconClass, text, title, id, name));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Class"></param>
        /// <param name="value"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static MvcHtmlString Submit(string Class, string value, string id = null, string name = null) {

            return MvcHtmlString.Create(String.Format("<input type='submit' class='btn {0}' id='{2}' name='{3}' value='{1}' />", 
                Class, value, id, name));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cssClass"></param>
        /// <param name="cssClassIcon"></param>
        /// <param name="value"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static MvcHtmlString SubmitWithIcon(string cssClass, string cssClassIcon, string value, string id = null, string name = null) {

            return MvcHtmlString.Create(String.Format("<button type='submit' class='btn {0}' id='{3}' name='{4}'>" +
                                                      "<span class='glyphicon {1}'></span> {2}" +
                                                      "</button>", cssClass, cssClassIcon, value, id, name));
        }

    }
}
