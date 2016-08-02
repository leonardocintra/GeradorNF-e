﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorNF.Model
{
    public class Emitente
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }

        [JsonProperty("inscricao_estadual")]
        public string InscricaoEstadual { get; set; }

        [JsonProperty("nome_razao")]
        public string RazaoSocial { get; set; }

        [JsonProperty("nome_fantasia")]
        public string NomeFantasia { get; set; }

        [JsonProperty("fone")]
        public string Fone { get; set; }

        [JsonProperty("cep")]
        public string CEP { get; set; }

        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty("numero_casa")]
        public string NumeroCasa { get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("cidade_codigo")]
        public int? CidadeCodigo { get; set; }

        [JsonProperty("cidade")]
        public string Cidade { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

        [JsonProperty("im")]
        public string IM { get; set; }

        [JsonProperty("cnae")]
        public string CNAE { get; set; }

        [JsonProperty("pais_codigo")]
        public int PaisCodigo { get; set; }

        [JsonProperty("pais")]
        public string Pais { get; set; }

        [JsonProperty("data_cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}