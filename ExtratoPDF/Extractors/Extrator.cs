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

        Type? type;
        object? obj;
        

        public Extrator() {
            try
            {

                string dllPath = Path.Join(Directory.GetCurrentDirectory(), "ExtratoPDFLibrary.dll");
                Assembly assembly = Assembly.LoadFile(dllPath);

                type = assembly.GetType("ExtratoPDFLibrary.Extrator");
            
                if(type != null)
                {
                    obj = Activator.CreateInstance(type);
                }
            } catch
            {

            }
        }

        public static Extrator Factory()
        {
            return new Extrator();
        }

        public bool IsLoaded()
        {
            return type != null;
        }
        
        public string GetVersion()
        {
            
            try
            {
                var methodBankList = type.GetMethod("GetVersion");

                if (methodBankList != null)
                {
                    return methodBankList.Invoke(obj, null) as string;
                }

                return "-";
            }
            catch { 
                return "-";
            }
        }

        public  string[] GetBankList()
        {
            try
            {

                var methodBankList = type.GetMethod("GetBanksList");

                var list = (string[])methodBankList.Invoke(obj, null);


                return list ?? [];
            }
            catch
            {
                return [];
            }
        }

        public  List<ExtratoItem> Extract(string bank, string text) 
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
