﻿using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCSV
{
    public class Atendimento
    {
        //AQUI VAI OS MOMES DAS COLUNAS DO SEU CSV
        //Classe de propriedades. É o nome desta classe que será referenciada no GetRecords<>()
        
        [Name("id")]
        public int Id { get; set; }

        [Name("nome_clinica")]
        public string NomeClinica { get; set; }

        [Name("nome_paciente")]
        public string NomePaciente { get; set; }

        [Name("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Name("data_atendimento")]
        public DateTime DataAtendimento { get; set; }

        [Name("especialidade")]
        public string Especialidade { get; set; }
    }
}
