using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticDownloadFile.Enuns
{
    public enum TiposArquivos
    {
        // Arquivos de Imagem
        [Description(".jpg")]
        JPG = 0,
        [Description(".png")]
        PNG = 1,
        [Description(".jpeg")]
        JPEG = 2,

        [Description(".pdf")]
        PDF = 3,
        [Description(".txt")]
        TXT = 4,

        // Arquivos Word 
        [Description(".doc")]
        DOC = 6,
        [Description(".docx")]
        DOCX = 7,

        // Arquivos Excel
        [Description(".xls")]
        XLS = 8,
        [Description(".xlsx")]
        XLSX = 9,





    }
}
