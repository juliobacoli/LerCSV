using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace TesteCSV;

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
                csv.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.Add("NULL");
                var atendimentos = csv.GetRecords<Atendimento>().ToList();

                foreach (var atendimento in atendimentos)
                    Console.WriteLine($"Paciente: {atendimento.NomePaciente}, Dt Nascimento: {atendimento.DataNascimento} ,Clinica: {atendimento.NomeClinica}");

            }

        }

    }
}