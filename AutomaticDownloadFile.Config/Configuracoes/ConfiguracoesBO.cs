using FileDados.Entidades;
using FileDados.Regras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticDownloadFile.Config.Configuracoes
{
    public class ConfiguracoesBO
    {

        public ConfiguracoesBO()
        {

        }

        public ConfiguracoesEntitie GetDadosConfiguracao()
        {
            ConfiguracoesEntitie entidade = new ConfiguracoesEntitie();
            Dados dados = new DadosBO().GetDadosFiles();
            entidade.Source = dados.source_dir;


            return entidade;
        }



    }
}
