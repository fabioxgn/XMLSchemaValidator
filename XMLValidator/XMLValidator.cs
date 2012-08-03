using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace XMLValidator
{
    public class XMLValidator
    {
        static int numErrors = 0;
        static string msgError = "";
        
        public static bool Validate(string XMLPath, string[] SchemaPaths)
        {
            ClearErrorMessage();
            try
            {
                XmlSchemaSet schema = new XmlSchemaSet();

                XmlTextReader TextReader;
                foreach(var s in SchemaPaths)
                {
                    TextReader = new XmlTextReader(GetFileStream(@s));
                    schema.Add(null, TextReader);
                    TextReader.Close();
                }

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add(schema);
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationEventHandler += new ValidationEventHandler(ErrorHandler);

                XmlReader reader = XmlReader.Create(XMLPath, settings);

                numErrors = 0;
                ValidarXML(reader);                
                if (numErrors > 0)
                    throw new Exception(msgError);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                msgError = "Validation failed\r\n" + e.Message;
                return false;
            }
        }

        private static void ValidarXML(XmlReader reader)
        {
            try
            {
                while (reader.Read()) ;
            }
            finally
            {
                reader.Close();
            }
        }

        private static void ErrorHandler(object sender, ValidationEventArgs args)
        {
            msgError = msgError + "\r\n" + args.Message;
            numErrors++;
        }

        public static string GetError()
        {
            return msgError;
        }

        private static void ClearErrorMessage()
        {
            msgError = "";
            numErrors = 0;
        }

        private static Stream GetFileStream(string filename)
        {
            return new FileStream(filename, FileMode.Open);
        }
    }
}
