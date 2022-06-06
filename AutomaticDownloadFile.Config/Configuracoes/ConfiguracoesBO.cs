using FileDados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticDownloadFile.Config.Configuracoes
{
    public class ConfiguracoesBO
    {
        Dados Dados;


        public ConfiguracoesBO()
        {
            Dados = new Dados();
        }

        public ConfiguracoesEntitie GetDadosConfiguracao()
        {
            ConfiguracoesEntitie entidade = new ConfiguracoesEntitie();
            entidade.Source = Dados.source_dir;


            return entidade;
        }



    }
}
