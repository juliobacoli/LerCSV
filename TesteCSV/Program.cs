using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.IO;
using System.Formats.Asn1;

namespace TesteCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter= ",",
            };

            using (var reader = new StreamReader("C:\\Projetos\\estudoCSV.csv"))
            {
                using (var csv = new CsvReader(reader, config))
                {
                    //23:40 - 05/12/2022 - O código só rodou depois de colocar essa linha. Estava recebendo um erro que não encontrava as colunas do csv.
                    csv.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.Add("NULL");
                    var atendimentos = csv.GetRecords<Atendimento>().ToList();

                    foreach (var atendimento in atendimentos)
                        Console.WriteLine($"Paciente: {atendimento.NomePaciente}, Dt Nascimento: {atendimento.DataNascimento} ,Clinica: {atendimento.NomeClinica}");

                }

            }

        }
    }
}