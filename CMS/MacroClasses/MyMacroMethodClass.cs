using CMS.MacroEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CMS;
using CMS.MacroEngine;
using CMS.Helpers;
using CMSApp.MacroClasses;

[assembly: RegisterExtension(typeof(CustomMacroMethods), typeof(string))]
[assembly: RegisterExtension(typeof(CustomMacroMethods), typeof(StringNamespace))]
namespace CMSApp.MacroClasses
{
 
    public class CustomMacroMethods : MacroMethodContainer
    {
        [MacroMethod(typeof(string), "Combines two strings, or appends a culture suffix when called with one parameter.", 1)]
        [MacroMethodParam(0, "param1", typeof(string), "First part of the string.")]
        //[MacroMethodParam(1, "param2", typeof(string), "Second part of the string (optional).")]
        public static object ReverseAndUpperCase(EvaluationContext context, params object[] parameters)
        {
            if (parameters.Length == 0)
            {
                throw new Exception("Empty paranmeters!");
            }

            return Reverse((string)parameters[0]).ToUpper();
        }

        private static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}