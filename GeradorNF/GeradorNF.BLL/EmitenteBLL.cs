﻿using GeradorNF.DAO;
using GeradorNF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GeradorNF.BLL
{
    public class EmitenteBLL
    {
        public static async Task<List<Emitente>> GetEmitenteBLL()
        {
            return await EmitenteDAO.GetEmitenteDAO();
        }

        public static async Task<HttpResponseMessage> AdicionarEmitenteBLL(Emitente emitente)
        {
            if (emitente.NomeFantasia == string.Empty)
                throw new Exception("Nome do emitente é obrigatório!");

            if (emitente.CNPJ == string.Empty)
                throw new Exception("CNPJ do emitente é obrigatório!");

            emitente.Pais = "BRASIL";
            emitente.PaisCodigo = 1058;

            return await EmitenteDAO.AdicionarEmitenteDAO(emitente);
        }

        public static async Task<HttpResponseMessage> DeletarEmitenteBLL(int id)
        {
            if (id < 1)
                throw new Exception("O Emitente não pode ser zero ou negativo. Verifique");

            return await EmitenteDAO.DeletarEmitenteDAO(id);

        }

        public static async Task<HttpResponseMessage> AtualizarEmitenteBLL(Emitente emitente)
        {
            if (emitente.NomeFantasia == string.Empty)
                throw new Exception("Nome do emitente é obrigatório!");

            if (emitente.CNPJ == string.Empty)
                throw new Exception("CNPJ do emitente é obrigatório!");

            emitente.Pais = "BRASIL";
            emitente.PaisCodigo = 1058;

            return await EmitenteDAO.AtualizarEmitenteDAO(emitente);
        }
    }
}
