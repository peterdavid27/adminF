//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RECEPCION
    {
        public int ID_PRODUCTO { get; set; }
        public Nullable<int> CLIENTE { get; set; }
        public string PRODUCTO { get; set; }
        public string ESTADO { get; set; }
        public string FECHA_REGISTRO { get; set; }
        public string ORIGEN { get; set; }
        public Nullable<int> DESTINO { get; set; }
        public string PESO { get; set; }
        public string PRECIO { get; set; }
    
        public virtual CLIENTES CLIENTES { get; set; }
        [Display(Name ="Sucursal")]
        public virtual SUCURSAL SUCURSAL { get; set; }
    }
}
