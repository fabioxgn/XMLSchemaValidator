using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace XMLSchemaValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (XML_XSD_Validator.Validate(@"D:\Dev\Monde\Monde-trunk\lib-nfse\dunit\NF.XML")) //@"C:\Users\Fábio\Desktop\Abrasf\Exemplos\EnviarLoteRpsEnvio.xml"))
                Console.WriteLine("Validação OK");
            else
                Console.WriteLine(XML_XSD_Validator.GetError());

            Console.ReadKey();
        }
    }

    public static class XML_XSD_Validator
    {
        static int numErrors = 0;
        static string msgError = "";

        public static bool Validate(string XMLPath)
        {
            ClearErrorMessage();
            try
            {
                XmlSchemaSet schema = new XmlSchemaSet();

                XmlTextReader tr = new XmlTextReader(GetFileStream(@"D:\Dev\Monde\dados\Ginfes\schemas_v300\servico_enviar_lote_rps_envio_v03.xsd"));
                schema.Add(null, tr);
                //tr = new XmlTextReader(GetFileStream(@"D:\Dev\Monde\dados\Ginfes\schemas_v300\tipos_complexos_v03.xsd"));
                //schema.Add(null, tr);
                tr = new XmlTextReader(GetFileStream(@"D:\Dev\Monde\dados\Ginfes\schemas_v300\tipos_v03.xsd"));
                schema.Add(null, tr);
                tr = new XmlTextReader(GetFileStream(@"D:\Dev\Monde\dados\Ginfes\schemas_v300\xmldsig-core-schema20020212_v03.xsd"));
                schema.Add(null, tr);

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add(schema);
                settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
                settings.ValidationEventHandler += new ValidationEventHandler(ErrorHandler);
                
                XmlReader reader = XmlReader.Create(XMLPath, settings);

                ValidarXML(reader);

                // exception if validation failed
                if (numErrors > 0)
                    throw new Exception(msgError);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                msgError = "Validation failed\r\n" + msgError;
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
