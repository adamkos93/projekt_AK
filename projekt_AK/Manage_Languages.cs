using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace projekt_AK
{
    public class Manage_Languages
    {
        public static List<Langugages> AvailableLanguages = new List<Langugages>
        {
            new Langugages{ LangFullName="Polski", LangCultureName="pl"},
            new Langugages{ LangFullName="English",LangCultureName="en"}
        };
        public static bool IsLanguageAvailable(string lang)
        {
            return AvailableLanguages.Where(a => a.LangCultureName.Equals(lang)).FirstOrDefault() != null ? true : false;
        }

        public static string GetDefaulLanguage()
        {
            return AvailableLanguages[0].LangCultureName;
        }
        public void SetLanguage(string lang)
        {
            try
            {
                if (!IsLanguageAvailable(lang))
                {
                    lang = GetDefaulLanguage();
                }
                else
                {


                    var CultureInfo = new CultureInfo(lang);
                    Thread.CurrentThread.CurrentUICulture = CultureInfo;
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(CultureInfo.Name);
                    HttpCookie langCookie = new HttpCookie("culture", lang);
                    langCookie.Expires = DateTime.Now.AddYears(1);
                    HttpContext.Current.Response.Cookies.Add(langCookie);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
    public class Langugages
    {
        public string LangFullName { get; set; }
        public string LangCultureName { get; set; }
    }
}