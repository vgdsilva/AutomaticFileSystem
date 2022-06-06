using FileDados.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDados.Enuns
{
    public enum TiposArquivos
    {
        // Arquivos de Imagem
        [EnumDescrition(".jpg")]
        JPG = 0,
        [EnumDescrition(".png")]
        PNG = 1,
        [EnumDescrition(".jpeg")]
        JPEG = 2,

        [EnumDescrition(".pdf")]
        PDF = 3,
        [EnumDescrition(".txt")]
        TXT = 4,

        // Arquivos Word 
        [EnumDescrition(".doc")]
        DOC = 6,
        [EnumDescrition(".docx")]
        DOCX = 7,

        // Arquivos Excel
        [EnumDescrition(".xls")]
        XLS = 8,
        [EnumDescrition(".xlsx")]
        XLSX = 9,
    }
}
