using ExtratoPDF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExtratoPDF.Extractors
{
    internal class Extrator
    {
        static string dllPath = Path.Join(Directory.GetCurrentDirectory(), "ExtratoPDFLibrary.dll");
        static Assembly assembly = Assembly.LoadFile(dllPath);
        static Type type = assembly.GetType("ExtratoPDFLibrary.Extrator");
        static object obj = Activator.CreateInstance(type);
        
        public static string GetVersion()
        {
            var methodBankList = type.GetMethod("GetVersion");

            if (methodBankList != null) {
                return methodBankList.Invoke(obj, null) as string;
            }

            return "-";
        }

        public static string[] GetBankList()
        {
            var methodBankList = type.GetMethod("GetBanksList");

            var list = (string[])methodBankList.Invoke(obj, null);


            return list ?? [];
        }

        public static List<ExtratoItem> Extract(string bank, string text) 
        {
            if (type == null) {
                throw new Exception($"Type not found");
            }

            var method = type.GetMethod("GetJSONItems");

            var jsonText = (string)method.Invoke(obj, new object[] { bank, text });

            return JsonSerializer.Deserialize<List<ExtratoItem>>(jsonText);
        }
    }
}
