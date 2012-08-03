using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using XMLValidator;

namespace XMLSchemaValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xsd = new string[4];

            xsd[0] = @"C:\Users\fabio.gomes\Documents\Dev\Dados\NotaControl\renfse\Schemas\servico_enviar_lote_rps_envio.xsd";
            xsd[1] = @"C:\Users\fabio.gomes\Documents\Dev\Dados\NotaControl\renfse\Schemas\tipos_complexos.xsd";
            xsd[2] = @"C:\Users\fabio.gomes\Documents\Dev\Dados\NotaControl\renfse\Schemas\tipos_simples.xsd";
            xsd[3] = @"C:\Users\fabio.gomes\Documents\Dev\Dados\NotaControl\renfse\Schemas\xmldsig-core-schema20020212.xsd";

            if (XMLValidator.XMLValidator.Validate(@"C:\Users\fabio.gomes\Desktop\Case103460.xml", xsd))
                Console.WriteLine("Validação OK");
            else
                Console.WriteLine(XMLValidator.XMLValidator.GetError());

            Console.ReadKey();
        }
    }

}
